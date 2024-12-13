using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PamerYukFormsApp.Prototype;
using PamerYukLibrary;

//PamerYuk Library
using PamerYukLibrary.Database;

namespace PamerYukFormsApp
{
    public partial class FormUtama : Form
    {
        public static Service service = new Service();
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

            this.IsMdiContainer = true;
            
            try
            {
                KoneksiDatabase connectToDatabase = new KoneksiDatabase(PamerYuk.Default.Server, PamerYuk.Default.Database, PamerYuk.Default.User, PamerYuk.Default.Password);
                MessageBox.Show("Koneksi ke Database Berhasil.\n" + "Terhubung dengan, " + PamerYuk.Default.Server + " : " + PamerYuk.Default.Database);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke Database Gagal : \n" + ex.Message);
            }
            FormMasuk formMasuk = new FormMasuk();
            formMasuk.Owner = this;
            formMasuk.ShowDialog();
            if (service.Current_user == null) //If user not logged in
            {
                Application.Exit();
            }
        }

        private void profilSayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormAkun"];
            if (f == null)
            {
                FormAkun frm = new FormAkun();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void tambahKisahHidupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f = Application.OpenForms["FormKisahHidup"];
            if (f == null)
            {
                FormKisahHidup frm = new FormKisahHidup();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }
    }
}
