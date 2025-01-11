using PamerYukFormsApp.Prototype2.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2
{
    public partial class UC_KontenSaya : UserControl
    {
        UC_DaftarKonten uc;
        UC_ProfilTeman uc_ProfilTeman;
        MainForm mainForm;
        public UC_KontenSaya(UC_DaftarKonten uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_KontenSaya_Load(object sender, EventArgs e)
        {
            flowLayoutPanelKontenSaya.AutoScroll = true;
            flowLayoutPanelKontenSaya.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelKontenSaya.WrapContents = false;

            //Console.WriteLine("From UC_Chat Current User : "+MainForm.service.Current_user.ToString());

            //menyesuaikan jumlah konten yang sudah diuplaod pengguna
            for (int i = 0; i < 3; i++)
            {
                UC_KontenDetail cli = new UC_KontenDetail(this);

                this.flowLayoutPanelKontenSaya.Controls.Add(cli);
            }
        }
    }
}
