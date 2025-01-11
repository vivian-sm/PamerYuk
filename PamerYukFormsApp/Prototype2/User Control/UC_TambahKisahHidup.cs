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
    public partial class UC_TambahKisahHidup : UserControl
    {
        MainForm mainForm;
        UC_Profile uc;
        public UC_TambahKisahHidup(UC_Profile uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_TambahKisahHidup_Load(object sender, EventArgs e)
        {

        }

        private void buttonTambahOrganisasi_Click(object sender, EventArgs e)
        {            
            this.panelKonten.Controls.Clear();

            UC_TambahOrganisasi uC_TambahOrganisasi = new UC_TambahOrganisasi(this);
            this.panelKonten.Controls.Remove(this);
            uC_TambahOrganisasi.Dock = DockStyle.Fill;
            this.panelKonten.Controls.Add(uC_TambahOrganisasi);
        }
    }
}
