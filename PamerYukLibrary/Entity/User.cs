using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PamerYukLibrary
{
    public class User
    {
        private string username;
        private string password;
        private DateTime tglLahir;
        private string noKTP;
        private string foto;
        private Kota kota;

        public User(string username, string password, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            this.Username = username;
            this.Password = password;
            this.TglLahir = tglLahir;
            this.NoKTP = noKTP;
            this.Foto = foto;
            this.Kota = kota;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string NoKTP { get => noKTP; set => noKTP = value; }
        public string Foto { get => foto; set => foto = value; }
        public Kota Kota { get => kota; set => kota = value; }
    }
}