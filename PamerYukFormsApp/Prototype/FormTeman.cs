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
    public partial class FormTeman : Form
    {
        Organisasi selectedOrganisasi = new Organisasi();
        public FormTeman()
        {
            InitializeComponent();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string usn = textBoxUsername.Text;
            if (textBoxUsername.Text != "")
            {
                dataGridViewDaftarTeman.DataSource = FormUtama.service.Cari_Teman(usn);
                dataGridViewDaftarTeman.Columns.RemoveAt(1);
            }
            if (comboBoxOrganisasi.SelectedIndex != -1)
            {
                dataGridViewDaftarTeman.DataSource = FormUtama.service.Cari_Teman(selectedOrganisasi);
                dataGridViewDaftarTeman.Columns.RemoveAt(1);
            }
            if(dataGridViewDaftarTeman.Columns.Count == 5)
            {
                DataGridViewButtonColumn buttonTambahTeman = new DataGridViewButtonColumn();
                buttonTambahTeman.Text = "Kirim Permintaan Pertemanan";
                buttonTambahTeman.HeaderText = "Tambah Teman";
                buttonTambahTeman.UseColumnTextForButtonValue = true;
                buttonTambahTeman.Name = "buttonTambahTeman";
                dataGridViewDaftarTeman.Columns.Add(buttonTambahTeman);
            }
        }

        private void FormTeman_Load(object sender, EventArgs e)
        {

            comboBoxOrganisasi.DataSource = FormUtama.service.Lihat_Organisasi_User();
            comboBoxOrganisasi.DisplayMember = "Nama";
            comboBoxOrganisasi.SelectedIndex = -1;
        }

        private void comboBoxOrganisasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOrganisasi = (Organisasi)comboBoxOrganisasi.SelectedItem;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewDaftarTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["buttonTambahTeman"].Index)
            {
                string username = dataGridViewDaftarTeman.CurrentRow.Cells["username"].Value.ToString();
                FormUtama.service.Request_Pertemanan(username);
            }
        }
    }
}
