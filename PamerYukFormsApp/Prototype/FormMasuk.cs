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
    public partial class FormMasuk : Form
    {
        FormUtama formUtama;
        public FormMasuk()
        {
            InitializeComponent();
        }

        private void FormMasuk_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            FormDaftar formDaftar = new FormDaftar();
            formDaftar.Owner = this;
            formDaftar.ShowDialog();
        }
    }
}
