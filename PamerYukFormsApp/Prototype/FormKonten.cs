using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype
{
    public partial class FormKonten : Form
    {
        private Konten selectedKonten;
        public FormKonten(Konten konten)
        {
            InitializeComponent();
            this.selectedKonten = konten;
        }

        private void FormKonten_Load(object sender, EventArgs e)
        {
            //Access File from file address and display
            listBoxDeskripsi.Items.Clear();
            listBoxDeskripsi.Items.Add(this.selectedKonten.Caption);
            listBoxKomentar.DataSource = selectedKonten.Comment;
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            string comment = textBoxKomen.Text;
            Komen newKomen = new Komen(comment,DateTime.Now,FormUtama.service.Current_user.Username);
            selectedKonten = FormUtama.service.Tambah_Komen(newKomen,this.selectedKonten);
            FormKonten_Load(sender, e);
        }
    }
}
