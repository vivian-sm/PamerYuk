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
    public partial class FormDaftar : Form
    {
        public FormDaftar()
        {
            InitializeComponent();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirm_password = textBoxKonfirmasi.Text;
            Kota selected_kota = (Kota)comboBoxKota.SelectedItem;
            DateTime tanggalLahir = dateTimePicker1.Value.Date;
            string profile_picture = "null.jpg"; //untuk sementara ku ga isi picture nya belum belajar buat path file di C#
            string noKTP = textBoxNoKTP.Text;
            if(CheckPassword(password,confirm_password))
            {
                FormUtama.service.Current_user = FormUtama.service.Daftar(username, password, tanggalLahir, noKTP, profile_picture, selected_kota);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please make sure password and confirmation password have the same value");
            }
        }

        private void FormDaftar_Load(object sender, EventArgs e)
        {
            comboBoxKota.DataSource = FormUtama.service.ListKota;
            comboBoxKota.DisplayMember = "Nama";
        }

        #region METHOD
        private bool CheckPassword(string pass, string confirm_pass)
        {
            return pass == confirm_pass;
        }
        #endregion
    }
}
