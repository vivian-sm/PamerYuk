﻿using System;
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

        public Organisasi(int id, string nama, Kota kota)
        {
            this.Id = id;
            this.Nama = nama;
            this.Kota = kota;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public Kota Kota { get => kota; set => kota = value; }
    }
}