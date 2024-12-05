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
        #endregion

        #region PROPERTIES
        public string Username
        {
            get => username;
            set
            {
                if (value == "")
                {
                    throw new Exception("Username can't be empty");
                }
                else
                {
                    username = value;
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value == "")
                {
                    throw new Exception("Password can't be empty");
                }
                else
                {
                    password = value;
                }
            }
        }
        public DateTime TglLahir
        {
            get => tglLahir;
            set
            {
                if (value == null)
                {
                    throw new Exception("Birthdate can't be null");
                }
                else
                {
                    tglLahir = value;
                }
            }
        }
        public string NoKTP
        {
            get => noKTP;
            set
            {
                if (value == "" || !int.TryParse(value, out int result))
                {
                    throw new Exception("Identification number can't be empty or non numbers");
                }
                else
                {
                    noKTP = value;
                }
            }
        }
        public string Foto
        {
            get => foto;
            set
            {
                if (value == null)
                {
                    throw new Exception("Image can't be null");
                }
                else
                {
                    foto = value;
                }
            }
        }
        public Kota Kota 
        { 
            get => kota; 
            set
            {
                if(value == null)
                {
                    throw new Exception("City can't be null");
                }
                else
                {
                    kota = value;
                }
            }
        }
        public List<KisahHidup> ListKisahHidup { get => listKisahHidup; set => listKisahHidup = value; }
        #endregion

        #region METHOD
        private List<KisahHidup> Get_ListKisahHidup()
        {
            List<KisahHidup> list = new List<KisahHidup>();
            //Select List from Database
            list = DAO_Users.Select_ListKisahHidup_Users(this.Username);
      
            return list;
        }
        #endregion
    }
}