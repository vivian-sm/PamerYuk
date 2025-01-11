using PamerYukLibrary;
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
    public partial class UC_ProfilTeman : UserControl
    {
        UC_Home uc;
        User selectedUser;
        public UC_ProfilTeman(UC_Home uc, Teman selectedTeman)
        {
            InitializeComponent();
            this.uc = uc;
            selectedUser = MainForm.service.Cari_AkunTeman(selectedTeman.Username);
        }
        private void UC_ProfilTeman_Load(object sender, EventArgs e)
        {
            flowLayoutPanelKonten.AutoScroll = true;
            flowLayoutPanelKonten.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelKonten.WrapContents = false;

            //Console.WriteLine("From UC_Chat Current User : "+MainForm.service.Current_user.ToString());

            //menyesuaikan jumlah konten yang sudah diuplaod pengguna
            for (int i = 0; i < 3; i++)
            {
                UC_KontenDetail cli = new UC_KontenDetail(this);

                this.flowLayoutPanelKonten.Controls.Add(cli);
            }
        }
    }
}
