using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using MySqlX.XDevAPI.Relational;
using PamerYukLibrary.DAO;

namespace PamerYukLibrary
{
    public class User
    {
        #region MEMBERS
        private string username;
        private string password;
        private DateTime tglLahir;
        private string noKTP;
        private string foto;
        private Kota kota;
        private List<KisahHidup> listKisahHidup;

        #endregion

        #region CONSTRUCTORS
        public User(string username, string password, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            this.Username = username;
            this.Password = password;
            this.TglLahir = tglLahir;
            this.NoKTP = noKTP;
            this.Foto = foto;
            this.Kota = kota;
            this.ListKisahHidup = Get_ListKisahHidup(); //Composition
        }

        public User()
        {
        }
        #endregion

        #region PROPERTIES
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string NoKTP { get => noKTP; set => noKTP = value; }
        public string Foto { get => foto; set => foto = value; }
        public Kota Kota { get => kota; set => kota = value; }
        public List<KisahHidup> ListKisahHidup { get => listKisahHidup; set => listKisahHidup = value; }
        #endregion

        #region METHOD
        private List<KisahHidup> Get_ListKisahHidup()
        {
            List<KisahHidup> list = new List<KisahHidup>();
            //Select List from Database
            list = DAO_KisahHidup.Select_ListKisahHidup(this.Username);
      
            return list;
        }

        public string Check_Password()
        {
            return this.Password;
        }
        #endregion
    }
}