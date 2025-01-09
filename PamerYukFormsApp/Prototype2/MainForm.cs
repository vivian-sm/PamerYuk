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
            /*this.panel1.Hide();
            this.NavigationBar.Hide();*/
            this.IsMdiContainer = true;
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

            //Kalau sudah ada yg login, baru OnLoad listOfFriends
            if (uC_Login.confirmLogin)
            {
                service.OnLoad();
            }

            //Pas aku pindah ke UC, code di bwh bikin error jadi kuakali pake condition di atas
            /*if (service.Current_user == null) //If user not logged in
            {
                Application.Exit();
            }*/

            //service.OnLoad();
            //            
        }
    }
}