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
    public partial class FormKisahHidup : Form
    {
        public FormKisahHidup()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahOrganisasi frm = new FormTambahOrganisasi();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            Organisasi selected_organisasi = (Organisasi)comboBoxOrganisasi.SelectedItem;
            string deskripsi = textBoxDeskripsi.Text;
            int tahun_awal = (int)numericUpDownTahunAwal.Value;
            int tahun_akhir = (int)numericUpDownTahunAkhir.Value;
        }

        private void FormKisahHidup_Load(object sender, EventArgs e)
        {
            comboBoxOrganisasi.DataSource = FormUtama.service.ListOrganisasi;
            comboBoxOrganisasi.DisplayMember = "Nama";
        }
    }
}
