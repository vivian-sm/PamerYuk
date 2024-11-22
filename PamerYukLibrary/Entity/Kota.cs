using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PamerYukLibrary
{
    public class Kota
    {
        private int id;
        private string nama;

        public Kota(int id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}