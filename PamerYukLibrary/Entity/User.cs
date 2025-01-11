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
        private string namaLengkap;
        private DateTime tglLahir;
        private string noKTP;
        private string fotoDiri;
        private string fotoProfil;
        private string email;
        private Kota kota;
        private List<KisahHidup> listKisahHidup;
        private List<Konten> listKonten;

        #endregion

        #region CONSTRUCTORS
        public User(string username, string password, string namaLengkap, DateTime tglLahir, string noKTP, string fotoDiri, string fotoProfil, string email, Kota kota)
        {
            this.Username = username;
            this.Password = password;
            this.NamaLengkap = namaLengkap;
            this.TglLahir = tglLahir;
            this.NoKTP = noKTP;
            this.FotoDiri = fotoDiri;
            this.FotoProfil = fotoProfil;
            this.Email = email;
            this.Kota = kota;
            this.ListKonten = new List<Konten>();
            this.ListKisahHidup = new List<KisahHidup>();
        }

        public User(string username, string namaLengkap, DateTime tglLahir, string noKTP, string fotoDiri, string fotoProfil, string email, Kota kota)
        {
            this.Username = username;
            this.Password = null;
            this.NamaLengkap = namaLengkap;
            this.TglLahir = tglLahir;
            this.NoKTP = noKTP;
            this.FotoDiri = fotoDiri;
            this.FotoProfil = fotoProfil;
            this.Email = email;
            this.Kota = kota;
            this.ListKonten = new List<Konten>();
            this.ListKisahHidup = new List<KisahHidup>();
        }
        #endregion

        #region PROPERTIES
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string NamaLengkap { get => namaLengkap; set => namaLengkap = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string NoKTP { get => noKTP; set => noKTP = value; }
        public string FotoDiri { get => fotoDiri; set => fotoDiri = value; }
        public string FotoProfil { get => fotoProfil; set => fotoProfil = value; }
        public string Email { get => email; set => email = value; }
        public Kota Kota { get => kota; set => kota = value; }
        public List<KisahHidup> ListKisahHidup { get => listKisahHidup; set => listKisahHidup = value; }
        public List<Konten> ListKonten { get => listKonten; set => listKonten=value; }
        #endregion

        #region METHOD
        #endregion
    }
}