using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary
{
    public class KisahHidup
    {
        private Organisasi organisasi;
        private User user;
        private DateTime thawal;
        private DateTime thakhir;
        private string deskripsi;

        public KisahHidup(Organisasi organisasi, User user, DateTime thawal, DateTime thakhir, string deskripsi)
        {
            this.Organisasi = organisasi;
            this.User = user;
            this.Thawal = thawal;
            this.Thakhir = thakhir;
            this.Deskripsi = deskripsi;
        }

        public Organisasi Organisasi { get => organisasi; set => organisasi = value; }
        public User User { get => user; set => user = value; }
        public DateTime Thawal { get => thawal; set => thawal = value; }
        public DateTime Thakhir { get => thakhir; set => thakhir = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
    }
}
