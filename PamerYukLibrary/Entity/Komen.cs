using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PamerYukLibrary
{
    public class Komen
    {
        private int id;
        private string komentar;
        private DateTime tgl;
        private string user;

        public Komen(int id, string komentar, DateTime tgl, string user)
        {
            this.Id = id;
            this.Komentar = komentar;
            this.Tgl = tgl;
            this.User = user;
        }
        public Komen(string komentar, DateTime time, string user) //New Comment
        {
            this.Komentar = komentar;
            this.Tgl = time;
            this.User = user;
        }

        public int Id { get => id; set => id = value; }
        public string Komentar { get => komentar; set => komentar = value; }
        public DateTime Tgl { get => tgl; set => tgl = value; }
        public string User { get => user; set => user = value; }

        public override string ToString()
        {
            return this.tgl + " -> "+ this.User + " : " + this.Komentar;
        }
    }
}