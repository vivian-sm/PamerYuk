using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PamerYukLibrary.Database;
using PamerYukFormsApp.Prototype2.User_Control;

namespace PamerYukFormsApp.Prototype2
{
    public partial class MainForm : Form
    {
        public static Service service = new Service();
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            //biar wkt load, yg lgsg ke load uC_Login
            this.Visible = false;
            try
            {
                KoneksiDatabase connectToDatabase = new KoneksiDatabase(PamerYuk.Default.Server, PamerYuk.Default.Database, PamerYuk.Default.User, PamerYuk.Default.Password);
                MessageBox.Show("Koneksi ke Database Berhasil.\n" + "Terhubung dengan, " + PamerYuk.Default.Server + " : " + PamerYuk.Default.Database);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke Database Gagal : \n" + ex.Message);
            }
            this.Visible = true;

            //Menampilkan user control Login di panelUtama
            UC_Login uC_Login = new UC_Login(this);
            panelUtama.Controls.Add(uC_Login);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelUtama.Controls.Clear();
            panelUtama.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            UC_Home uc_home = new UC_Home(this);
            AddUserControl(uc_home);
            ResetNavigationBar();
            this.buttonHome.Image = Properties.Resources.Home_true;
        }

        private void buttonTambahKonten_Click(object sender, EventArgs e)
        {
            UC_DaftarKonten uc_tambah = new UC_DaftarKonten(this);
            AddUserControl(uc_tambah);
            ResetNavigationBar();
            this.buttonTambahKonten.Image = Properties.Resources.Tambahkonten_true;
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            UC_Chat uc_chat = new UC_Chat(this);
            AddUserControl(uc_chat);
            ResetNavigationBar();
            this.buttonChat.Image = Properties.Resources.Chat_true;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            UC_Profile uc_profile = new UC_Profile(this);
            AddUserControl(uc_profile);
            ResetNavigationBar();
            this.buttonProfile.Image = Properties.Resources.Profile_true;
        }

        private void ResetNavigationBar()
        {
            this.buttonHome.Image = Properties.Resources.Home_true;
            this.buttonChat.Image = Properties.Resources.Chat_false;
            this.buttonTambahKonten.Image = Properties.Resources.Tambahkonten_false;
            this.buttonProfile.Image = Properties.Resources.Profile_false;
        }

        private void panelUtama_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}