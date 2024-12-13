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
        private int thawal;
        private int thakhir;
        private string deskripsi;

        public KisahHidup(Organisasi organisasi, int thawal, int thakhir, string deskripsi)
        {
            this.Organisasi = organisasi;
            this.Thawal = thawal;
            this.Thakhir = thakhir;
            this.Deskripsi = deskripsi;
        }

        public Organisasi Organisasi { get => organisasi; set => organisasi = value; }
        public int Thawal { get => thawal; set => thawal = value; }
        public int Thakhir { get => thakhir; set => thakhir = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        public override string ToString()
        {
            string text = "";
            text = this.Organisasi.Nama + " dari tahun " + this.thawal + " hingga " + this.thakhir + "\n";
            return text;
        }
    }
}
