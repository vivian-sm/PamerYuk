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
        FileDialog fileDialog;
        public UC_Profile(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            mainForm.panel1.Show();
            mainForm.panel1.BringToFront();

            textBoxNamaLengkap.Text = MainForm.service.Current_user.NamaLengkap;
            textBoxUsername.Text = MainForm.service.Current_user.Username;
            textBoxEmail.Text = MainForm.service.Current_user.Email;
            textBoxNoKtp.Text = MainForm.service.Current_user.NoKTP;
            dateTimePickerTglLahir.Text = MainForm.service.Current_user.TglLahir.ToString();
            comboBoxKota.Text = MainForm.service.Current_user.Kota.Nama;
            Image profilePictureFotoDiri = new Bitmap(FormUtama.service.Current_user.FotoDiri);
            panelFotoDiri.BackgroundImage = profilePictureFotoDiri;
            panelFotoDiri.BackgroundImageLayout = ImageLayout.Zoom;
            Image profilePictureFotoProfil = new Bitmap(FormUtama.service.Current_user.FotoProfil);
            panelFotoProfil.BackgroundImage = profilePictureFotoProfil;
            panelFotoProfil.BackgroundImageLayout = ImageLayout.Zoom;

        }

        #region METHOD
        private List<string> DisplayKisahHidup()
        {
            List<string> list = new List<string>();
            foreach (KisahHidup kisah in FormUtama.service.Current_user.ListKisahHidup)
            {
                {
                    list.Add(kisah.ToString());
                }
            }
            return list;
        }
        #endregion

        private void buttonEditFotoDiri_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(fileDialog.FileName) == ".jpg")
                    {
                        Image selectedImage = new Bitmap(fileDialog.FileName);
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

        private void buttonEditFotoProfil_Click(object sender, EventArgs e)
        {

        }


        private void buttonTambahKisahHidup_Click(object sender, EventArgs e)
        {
            mainForm.panelUtama.Controls.Clear();

            UC_TambahKisahHidup uC_TambahKisah = new UC_TambahKisahHidup(this);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uC_TambahKisah);
        }
    }
}
