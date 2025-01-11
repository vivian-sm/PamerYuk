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
    public partial class UC_TambahOrganisasi : UserControl
    {
        MainForm mainForm;
        UC_TambahKisahHidup uc;
        public UC_TambahOrganisasi(UC_TambahKisahHidup uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_TambahOrganisasi_Load(object sender, EventArgs e)
        {

        }
    }
}
