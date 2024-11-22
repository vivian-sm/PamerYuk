using PamerYukLibrary.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PamerYukLibrary
{
    public class Teman
    {
        private User user;
        private DateTime tglBerteman;
        private StatusPertemanan status;

        public Teman(User user, DateTime tglBerteman, StatusPertemanan status)
        {
            this.User = user;
            this.TglBerteman = tglBerteman;
            this.Status = status;
        }

        public User User { get => user; set => user = value; }
        public DateTime TglBerteman { get => tglBerteman; set => tglBerteman = value; }
        public StatusPertemanan Status { get => status; set => status = value; }
    }
}