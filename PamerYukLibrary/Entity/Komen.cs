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
        private User user;
        private Konten konten;

        public Komen(int id, string komentar, DateTime tgl, User user, Konten konten)
        {
            this.Id = id;
            this.Komentar = komentar;
            this.Tgl = tgl;
            this.User = user;
            this.Konten = konten;
        }

        public int Id { get => id; set => id = value; }
        public string Komentar { get => komentar; set => komentar = value; }
        public DateTime Tgl { get => tgl; set => tgl = value; }
        public User User { get => user; set => user = value; }
        public Konten Konten { get => konten; set => konten = value; }
    }
}