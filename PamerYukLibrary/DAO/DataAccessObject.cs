using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;

namespace PamerYukLibrary.DAO
{
    public class DataAccessObject
    {
        //This class exist to connect repositories to database

        #region USERS DAO
        //Users

        //For a user kisah hidup
        public static List<KisahHidup> Select_ListKisahHidup_Users(string username)
        {
            string perintah;
            perintah = "select * from kisahhidup kh	inner join organisasi o ON o.ID = kh.Organisasi_id inner join Kota K on o.Kota_Id = k.id where kh.username ='" + username + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<KisahHidup> listData = new List<KisahHidup>();

            while (dr.Read() == true)
            {
                //Taken from database
                //KisahHidup
                int organisasi_ID_fk = int.Parse(dr.GetValue(0).ToString());
                string username_fk = dr.GetValue(1).ToString();
                int thawal = int.Parse(dr.GetValue(2).ToString());
                int thakhir = int.Parse(dr.GetValue(3).ToString());
                string deskripsi = dr.GetValue(4).ToString();

                //Organisasi 
                int id_organisasi = int.Parse(dr.GetValue(5).ToString());
                string nama_organisasi = dr.GetValue(6).ToString();
                int kota_id_fk = int.Parse(dr.GetValue(7).ToString());

                //Kota
                int kota_id = int.Parse(dr.GetValue(8).ToString());
                string nama_Kota = dr.GetValue(9).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id, nama_Kota);

                //Create Organisasi
                Organisasi newOrganisasi = new Organisasi(id_organisasi, nama_organisasi, newKota);

                //Create Kisah Hidup
                KisahHidup newKisah = new KisahHidup(newOrganisasi, thawal, thakhir, deskripsi);

                //tambahkan ke list
                listData.Add(newKisah);
            }
            //kirim kembali list ke pemanggilnya
            return listData;
        }

        public static User User_Log_In(string username, string password)
        {
            string perintah;
            perintah = "select * from user u inner join kota k on u.kota_id = k.id where username ='" + username + "' and password ='" + password + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            User user;
            if (dr.Read())
            {
                //User
                username = dr.GetValue(0).ToString();
                password = dr.GetValue(1).ToString();
                DateTime tgllahir = DateTime.Parse(dr.GetValue(2).ToString());
                string noKTP = dr.GetValue(3).ToString();
                Image foto = (Image)dr.GetValue(4); //Still confuse with this image data format
                int kota_id_fk = int.Parse(dr.GetValue(4).ToString());

                //Kota
                int kota_id = int.Parse(dr.GetValue(4).ToString());
                string nama = dr.GetValue(4).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id, nama);

                //Create User
                user = new User(username, password, tgllahir, noKTP, foto, newKota);
            }
            else
            {
                throw new Exception("User password or username is incorrect");
            }
            return user;
        }

        public static void User_Daftar(User user)
        {
            //Still confuse with this image data format
            string command = "INSERT INTO `user` (`username`, `password`, `tglLahir`, `noKTP`,'foto','kota_id') values('" + user.Username + "','" + user.Password + "','" + user.TglLahir.ToString("yyyy-MM-dd") + "','" + user.NoKTP + "','" + user.Foto + "','" + user.Kota.Id + "');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }
        #endregion

        #region ORGANISASI DAO
        #endregion

        #region KOTA DAO
        #endregion
    }
}
