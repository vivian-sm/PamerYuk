using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PamerYuk Library
using PamerYukLibrary.Database;

namespace PamerYukFormsApp
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                KoneksiDatabase connectToDatabase = new KoneksiDatabase(PamerYuk.Default.Server, PamerYuk.Default.Database, PamerYuk.Default.User, PamerYuk.Default.Password);
                MessageBox.Show("Koneksi ke Database Berhasil.\n" + "Terhubung dengan, " + PamerYuk.Default.Server + " : " + PamerYuk.Default.Database);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke Database Gagal : \n" + ex.Message);
            }
        }
    }
}
