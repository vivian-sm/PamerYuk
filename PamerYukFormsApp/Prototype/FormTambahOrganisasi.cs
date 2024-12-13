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
    public partial class FormTambahOrganisasi : Form
    {
        public FormTambahOrganisasi()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            Kota kota = (Kota)comboBoxKota.SelectedItem;
            Organisasi newOrganisasi = new Organisasi (nama, kota);
            FormUtama.service.Tambah_Organisasi(newOrganisasi);
            this.Close();
        }

        private void FormTambahOrganisasi_Load(object sender, EventArgs e)
        {
            comboBoxKota.DataSource = FormUtama.service.ListKota;
            comboBoxKota.DisplayMember = "Nama";
        }
    }
}
