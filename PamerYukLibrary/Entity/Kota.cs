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

        public int Id 
        { get => id; 
            set
            {
                if(value<0)
                {
                    throw new Exception("ID can't be lower than 0");
                }
                else
                {
                    id = value;
                }
            }
        }
        public string Nama 
        { 
            get => nama; 
            set
            {
                if(value=="")
                {
                    throw new Exception("Kota name can't be empty");
                }
                else
                {
                    nama = value;
                }
            }
        }

        public override string ToString()
        {
            return this.Nama;
        }
    }
}