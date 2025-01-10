using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PamerYukLibrary;
using PamerYukLibrary.DAO;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using PamerYukLibrary.Entity;

namespace PamerYukFormsApp
{
    public class Service //On Load
    {
        #region VARIABLES
        private User current_user;
        private List<Kota> listKota;
        private List<Organisasi> listOrganisasi;
        private List<Teman> listTeman;
        private string MediafilePath = @"C:\PamerYuk\";
        private string MediafilePathDB = @"C:\\PamerYuk\\";
        public Konten buffer_konten;
        #endregion

        #region CONSTRUCTOR
        public Service()
        {
            this.ListOrganisasi = DAO_Organisasi.Select_Organisasi();
            this.ListKota = DAO_Kota.Select_ListKota();
            CreateDirectory();
        }
        #endregion

        #region PROPERTIES

        public User Current_user { get => current_user; set => current_user = value; }
        public List<Kota> ListKota { get => listKota; set => listKota = value; }
        public List<Organisasi> ListOrganisasi { get => listOrganisasi; set => listOrganisasi = value; }
        public List<Teman> ListTeman { get => listTeman; set => listTeman = value; }
        #endregion

        #region ONLOAD
        public void OnLoad()
        {
            this.ListTeman = DAO_Teman.Select_ListTeman(this.Current_user.Username);       
        }
        #endregion

        #region METHOD (USER) 
        //For User
        public void LogIn(string username, string password)
        {
            this.Current_user = DAO_Users.User_Log_In(username, password);
        }

        public void Daftar(string username, string password, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            string newFotoPath = New_ProfilePictureFileName(username);
            File.Copy(foto, Path.Combine(this.MediafilePath, newFotoPath));
            User new_user = new User(username, password, tglLahir, noKTP,Path.Combine(this.MediafilePath,newFotoPath), kota);
            DAO_Users.User_Daftar(username, password, tglLahir, noKTP, Path.Combine(this.MediafilePathDB, newFotoPath), kota);
            this.Current_user = new_user;
        }

        #endregion

        #region METHOD (KISAH HIDUP)
        //For Kisah Hidup
        public void Tambah_KisahHidup(Organisasi organisasi, int thawal, int thakhir, string deskripsi)
        {
            KisahHidup newKisahHidup = new KisahHidup(organisasi, thawal, thakhir, deskripsi);
            DAO_KisahHidup.Insert_KisahHidup(newKisahHidup, this.Current_user);
            this.current_user.ListKisahHidup = DAO_KisahHidup.Select_ListKisahHidup(this.Current_user.Username);
        }

        #endregion

        #region METHOD (ORGANISASI)
        public void Tambah_Organisasi(Organisasi newOrganisasi)
        {
            DAO_Organisasi.Insert_Organisasi(newOrganisasi);
            this.ListOrganisasi = DAO_Organisasi.Select_Organisasi(); //Re-New the list
        }

        public List<Organisasi> Lihat_Organisasi_User()
        {
            List<Organisasi> result = new List<Organisasi>();
            foreach (KisahHidup kh in this.Current_user.ListKisahHidup)
            {
                result.Add(kh.Organisasi);
            }
            return result;
        }
        #endregion

        #region METHOD (TEMAN)
        public List<User> Cari_Teman(Organisasi organisasi)
        {
            return DAO_Users.Select_ListUser_ByOrganisasi(organisasi, this.Current_user);
        }

        public List<User> Cari_Teman(string username)
        {
            return DAO_Users.Select_ListUser_ByUSN(username);
        }

        public User Cari_AkunTeman(string username)
        {
            return DAO_Users.Select_User(username);
        }

        public void Request_Pertemanan(string username)
        {
            DAO_Teman.Insert_RequestPertemanan(this.Current_user.Username, username);
        }

        public void Terima_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(username, this.Current_user.Username, "Berteman");
            this.ListTeman = DAO_Teman.Select_ListTeman(this.Current_user.Username);
        }

        public void Tolak_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(username, this.Current_user.Username, "Ditolak");
        }
        public void KirimUlang_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(username, this.Current_user.Username, "Menunggu");
        }

        public List<Teman> Request_Pertemanan(bool jenis)
        {
            //true = sender, false = receiver
            return DAO_Teman.Select_RequestPertemanan(this.Current_user.Username, jenis);
        }
        #endregion

        #region METHOD (KONTEN)
        public Konten Tambah_Komen(Komen komen, Konten newKonten)
        {
            DAO_Komen.Insert_Komen(komen,newKonten.Id);
            newKonten.Comment = DAO_Komen.Select_Komen(newKonten.Id);
            return newKonten;
        }


        public void Tambah_Tag(string username)
        {
            this.buffer_konten.Tag.Add(DAO_Users.Select_User(username));
        }

        public Konten Lihat_Konten(int id)
        {
            return DAO_Konten.Select_Konten(id);
        }

        public void Initiate_Konten()
        {
            this.buffer_konten = new Konten();
        }

        public void Tambah_Konten(string caption, OpenFileDialog fdialog)
        {
            buffer_konten.Caption = caption;
            buffer_konten.TglUpload = DateTime.Now;
            string newPath = "";
            if (Path.GetExtension(fdialog.FileName) == ".jpg")
            {
                newPath = New_FileName(true);
                buffer_konten.Foto = Path.Combine(this.MediafilePathDB,newPath);
            }
            else
            {
                newPath = New_FileName(false);
                buffer_konten.Video = Path.Combine(this.MediafilePathDB, newPath);
            }
            File.Copy(fdialog.FileName, Path.Combine(this.MediafilePath, newPath));
            DAO_Konten.Insert_Konten(buffer_konten, this.Current_user.Username);
            this.Current_user.ListKonten = DAO_Konten.Select_ListKonten(this.current_user.Username);
            int konten_id = this.Current_user.ListKonten[(this.Current_user.ListKonten.Count - 1)].Id;
            foreach(User us in this.buffer_konten.Tag)
            {
                DAO_Tag.Insert_Tag(konten_id, us.Username);
            }
            this.buffer_konten = null;
        }

        public bool Check_Like(int konten_id)
        {
            return DAO_Like.CheckLike(konten_id,this.Current_user.Username);
        }

        public Konten Tambah_Like(int konten_id)
        {
            DAO_Like.Insert_Like(konten_id , this.Current_user.Username);
            return DAO_Konten.Select_Konten(konten_id);
        }

        public Konten Delete_Like(int konten_id)
        {
            DAO_Like.DELETE_Like(konten_id, this.Current_user.Username);
            return DAO_Konten.Select_Konten(konten_id);
        }
        #endregion

        #region METHOD
        //File Handling
        private string New_FileName(bool type)
        {

            string path = this.current_user.Username + "x" + DateTime.Now.ToString("yyyyMMddHHmmss") + "x" + DAO_Konten.Get_NewKonten_Id();
            if (type)
            {
                path += ".jpg";
            }
            else
            {
                path += ".mp4";
            }
            return path;
        }

        private string New_ProfilePictureFileName(string username)
        {
            return username + "xPFPx" + DateTime.Now.ToString("yyyyMMddHHmmss")+".jpg";
        }

        private void CreateDirectory()
        {
            if (!Directory.Exists(MediafilePath))
            {
                Directory.CreateDirectory(MediafilePath);
            }
        }

        #endregion

        #region CHAT

        public List<Chat> Buka_Chat(string username)
        {
            return DAO_Chat.Select_Chat(username, this.Current_user.Username);
        }

        public void Kirim_Chat(Chat chat)
        {
            DAO_Chat.Insert_Chat(chat);
        }
        #endregion
    }
}
