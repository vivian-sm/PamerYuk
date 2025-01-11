using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_DaftarDataDiri : UserControl
    {
        MainForm mainForm;
        FileDialog fileDialogFotoProfil;
        FileDialog fileDialogFotoDiri;
        public string username = "";
        public string password = "";
        public string confirm_password = "";


        public UC_DaftarDataDiri(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            UC_Login uc_login = new UC_Login(mainForm);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uc_login);
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string namaLengkap = textBoxNamaLengkap.Text;
            string noKTP = textBoxNoKtp.Text;
            Kota selected_kota = (Kota)comboBoxKota.SelectedItem;
            DateTime tanggalLahir = dateTimePickerTglLahir.Value.Date;
            string fotoDiri = @"C:\PamerYuk\default_image.jpg";//nanti set default image di Folder yang dicreate
            string fotoProfil = @"C:\PamerYuk\default_image.jpg";//nanti set default image di Folder yang dicreate
            if (fileDialogFotoDiri.FileName != null)
            {
                fotoDiri = fileDialogFotoDiri.FileName;
            }
            if (fileDialogFotoProfil.FileName != null)
            {
                fotoProfil = fileDialogFotoProfil.FileName;
            }
            string email = textBoxEmail.Text;
            MainForm.service.Daftar(username, password, namaLengkap, tanggalLahir, noKTP, fotoDiri, fotoProfil, email,selected_kota);

            MessageBox.Show("Account is succesfully created");

            this.pictureBox2.Image = Properties.Resources.Checked_true;
            //Proses login selesai, User Control close, Clear object yg show di panelUtama
            mainForm.panelUtama.Controls.Remove(this);

            //Change to uc_login before goes to HomePage
            UC_Login uc_login = new UC_Login(mainForm);
            mainForm.panelUtama.Controls.Add(uc_login);
            mainForm.panel1.Hide();


            /*mainForm.panelUtama.Show();*/
            mainForm.FormBorderStyle = FormBorderStyle.Sizable;
            mainForm.MaximizeBox = true;
            mainForm.MinimizeBox = true;


        }

        private void UC_DaftarDataDiri_Load(object sender, EventArgs e)
        {
            comboBoxKota.DataSource = FormUtama.service.ListKota;
            comboBoxKota.DisplayMember = "Nama";
        }

        private void buttonUploadFotoProfil_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialogFotoProfil = new OpenFileDialog();
                if (fileDialogFotoProfil.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialogFotoProfil.FileName) == ".jpg")
                    {
                        Image selectedImageFotoProfil = new Bitmap(fileDialogFotoProfil.FileName);
                        panelFotoProfil.BackgroundImage = selectedImageFotoProfil;
                        panelFotoProfil.BackgroundImageLayout = ImageLayout.Zoom;
                        panelFotoProfil.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Only support jpg.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUploadFotoDiri_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialogFotoDiri = new OpenFileDialog();
                if (fileDialogFotoDiri.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialogFotoDiri.FileName) == ".jpg")
                    {
                        Image selectedImageFotoDiri = new Bitmap(fileDialogFotoDiri.FileName);
                        panelFotoDiri.BackgroundImage = selectedImageFotoDiri;
                        panelFotoDiri.BackgroundImageLayout = ImageLayout.Zoom;
                        panelFotoDiri.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Only support jpg.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
