using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_TambahKonten : UserControl
    {
        UC_DaftarKonten uc;
        public UC_TambahKonten(UC_DaftarKonten uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_TambahKonten_Load_1(object sender, EventArgs e)
        {
            MainForm.service.Initiate_Konten();

        }

        private void textBoxCaption_TextChanged(object sender, EventArgs e)
        {
            textBoxCaption.Clear();
        }

        private void textBoxCaption_Click(object sender, EventArgs e)
        {
            if (textBoxCaption.Text == "Caption")
            {
                textBoxCaption.Clear();
            }
        }
    }
}
