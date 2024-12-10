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
    public partial class FormAkun : Form
    {
        public FormAkun()
        {
            InitializeComponent();
        }

        private void FormAkun_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = FormUtama.service.Current_user.Username;
            textBoxNoKTP.Text = FormUtama.service.Current_user.NoKTP;
            textBoxTanggalLahir.Text = FormUtama.service.Current_user.TglLahir.ToString();
            textBoxKota.Text = FormUtama.service.Current_user.Kota.Nama;

        }
    }
}
