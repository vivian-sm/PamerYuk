using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace PamerYukLibrary
{
    public class Organisasi
    {
        private int id;
        private string nama;
        private Kota kota;

        public Organisasi(int id, string nama, Kota kota) //From DB
        {
            this.Id = id;
            this.Nama = nama;
            this.Kota = kota;
        }

        public Organisasi(string nama, Kota kota) //New Insert
        {
            this.Nama = nama;
            this.Kota = kota;
        }
        public Organisasi()
        {
            this.Id = -1;
            this.Nama = "";
            this.Kota = null;
        }
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public Kota Kota { get => kota; set => kota = value; }
    }
}