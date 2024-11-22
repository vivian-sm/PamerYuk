using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PamerYukLibrary
{
    public class Konten
    {
        private int id;
        private string caption;
        private Image foto;
        private string Video;
        private DateTime tglUpload;
        private List<User> tag;

        public Konten(int id, string caption, Image foto, string video, DateTime tglUpload, List<User> tag)
        {
            this.Id = id;
            this.Caption = caption;
            this.Foto = foto;
            Video1 = video;
            this.TglUpload = tglUpload;
            this.Tag = tag;
        }

        public int Id { get => id; set => id = value; }
        public string Caption { get => caption; set => caption = value; }
        public Image Foto { get => foto; set => foto = value; }
        public string Video1 { get => Video; set => Video = value; }
        public DateTime TglUpload { get => tglUpload; set => tglUpload = value; }
        public List<User> Tag { get => tag; set => tag = value; }
    }
}