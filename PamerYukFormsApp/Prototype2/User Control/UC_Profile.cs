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
    public partial class UC_Profile : UserControl
    {
        MainForm mainForm;
        FileDialog fileDialogFotoProfil;
        FileDialog fileDialogFotoDiri;
        public UC_Profile(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            mainForm.panel1.Show();
            mainForm.panel1.BringToFront();
            DisplayOnLoad();
        }

        private void buttonEditFotoDiri_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialogFotoDiri = new OpenFileDialog();
                if (fileDialogFotoDiri.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialogFotoDiri.FileName) == ".jpg")
                    {
                        Image selectedImage = new Bitmap(fileDialogFotoDiri.FileName);
                        panelFotoDiri.BackgroundImage = selectedImage;
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

        private void buttonEditFotoProfil_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialogFotoProfil = new OpenFileDialog();
                if (fileDialogFotoProfil.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialogFotoProfil.FileName) == ".jpg")
                    {
                        Image selectedImage = new Bitmap(fileDialogFotoProfil.FileName);
                        panelFotoProfil.BackgroundImage = selectedImage;
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


        private void buttonTambahKisahHidup_Click(object sender, EventArgs e)
        {
            mainForm.panelUtama.Controls.Clear();

            UC_TambahKisahHidup uC_TambahKisah = new UC_TambahKisahHidup(this);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uC_TambahKisah);
        }

        private void buttonSimpanUpdateProfile_Click(object sender, EventArgs e)
        {
            string new_usn = textBoxUsername.Text;
            string new_ktp = textBoxNoKtp.Text;
            string new_email = textBoxEmail.Text;
            string new_nama = textBoxNamaLengkap.Text;
            DateTime newTanggal = dateTimePickerTglLahir.Value;
            Kota newKota = (Kota)comboBoxKota.SelectedItem;

            //Kalau ada waktu nanti bisa dibuat lebih storage efficient
            string new_fd = MainForm.service.Current_user.FotoDiri;
            string new_fp = MainForm.service.Current_user.FotoProfil;
            if (fileDialogFotoDiri.FileName != null)
            {
                new_fd = fileDialogFotoDiri.FileName;
            }
            if (fileDialogFotoProfil.FileName != null)
            {
                new_fp = fileDialogFotoProfil.FileName;
            }
            MainForm.service.UpdateUser(new_usn,new_nama,newTanggal,new_ktp,new_fd,new_fp,new_email,newKota);
        }

        #region METHOD
        private void DisplayOnLoad()
        {
            textBoxNamaLengkap.Text = MainForm.service.Current_user.NamaLengkap;
            textBoxUsername.Text = MainForm.service.Current_user.Username;
            textBoxEmail.Text = MainForm.service.Current_user.Email;
            textBoxNoKtp.Text = MainForm.service.Current_user.NoKTP;
            dateTimePickerTglLahir.Text = MainForm.service.Current_user.TglLahir.ToString();
            comboBoxKota.DataSource = MainForm.service.ListKota;
            comboBoxKota.Text = MainForm.service.Current_user.Kota.Nama;

            Image profilePictureFotoDiri = new Bitmap(MainForm.service.Current_user.FotoDiri);
            panelFotoDiri.BackgroundImage = profilePictureFotoDiri;
            panelFotoDiri.BackgroundImageLayout = ImageLayout.Zoom;

            Image profilePictureFotoProfil = new Bitmap(MainForm.service.Current_user.FotoProfil);
            panelFotoProfil.BackgroundImage = profilePictureFotoProfil;
            panelFotoProfil.BackgroundImageLayout = ImageLayout.Zoom;

            listBoxKisahHidup.DataSource = MainForm.service.Current_user.ListKisahHidup;
        }
        #endregion
    }
}
