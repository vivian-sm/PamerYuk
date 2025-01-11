using PamerYukFormsApp.Prototype;
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
    public partial class UC_Home : UserControl
    {
        MainForm mainForm;
        public UC_Home(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            mainForm.panel1.Show();
            mainForm.panel1.BringToFront();

            DisplayOnLoad();
        }

        private void labelPertemananTerkirim_Click(object sender, EventArgs e)
        {
            labelPertemananMasuk.ForeColor = Color.Gray;
            labelPertemananTerkirim.ForeColor = SystemColors.MenuHighlight;

            flowLayoutPanelRequestPertemanan.Controls.Clear();

            //jumlah object yg dibuat menyesuaikan jumlah permintaan pertemanan yang terkirim
            for (int i = 0; i < 2; i++)
            {
                UC_RequestPertemananTerkirim rpk = new UC_RequestPertemananTerkirim(this);

                this.flowLayoutPanelRequestPertemanan.Controls.Add(rpk);
            }
        }

        private void labelPertemananMasuk_Click(object sender, EventArgs e)
        {
            labelPertemananTerkirim.ForeColor = Color.Gray;
            labelPertemananMasuk.ForeColor = SystemColors.MenuHighlight;

            flowLayoutPanelRequestPertemanan.Controls.Clear();

            //jumlah object yg dibuat menyesuaikan jumlah permintaan pertemanan yang masuk
            for (int i = 0; i < 2; i++)
            {
                UC_RequestPertemananMasuk rpm = new UC_RequestPertemananMasuk(this);

                this.flowLayoutPanelRequestPertemanan.Controls.Add(rpm);
            }
        }

        private void buttonCariTeman_Click(object sender, EventArgs e)
        {
            mainForm.panelUtama.Controls.Clear();

            UC_CariTeman uC_Daftar = new UC_CariTeman(this);
            mainForm.panelUtama.Controls.Remove(this);
            mainForm.panelUtama.Controls.Add(uC_Daftar);
        }

        private void dataGridViewDaftarTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["buttonLihatAkun"].Index)
            {
                string username = dataGridViewDaftarTeman.CurrentRow.Cells["username"].Value.ToString();
                DateTime tglBerteman = DateTime.Parse(dataGridViewDaftarTeman.CurrentRow.Cells["tglBerteman"].Value.ToString());
                string status = dataGridViewDaftarTeman.CurrentRow.Cells["status"].Value.ToString();

                mainForm.panelUtama.Controls.Clear();

                UC_ProfilTeman uc_profileTeman = new UC_ProfilTeman(this, new Teman(username, tglBerteman, status));
                mainForm.panelUtama.Controls.Remove(this);
                mainForm.panelUtama.Controls.Add(uc_profileTeman);
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        #region METHOD 
        private void DisplayOnLoad()
        {
            //Header
            labelCurrentUser.Text = MainForm.service.Current_user.Username;
            labelHariIni.Text = DateTime.Now.ToString("D");

            DisplayDaftarTeman();
            DisplayRequestPertemanan();
        }

        private void DisplayDaftarTeman()
        {
            dataGridViewDaftarTeman.DataSource = MainForm.service.ListTeman;
            dataGridViewDaftarTeman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridViewDaftarTeman.Columns.Count == 3)
            {
                DataGridViewButtonColumn buttonLihatAkun = new DataGridViewButtonColumn();
                buttonLihatAkun.Text = "Lihat Profil";
                buttonLihatAkun.HeaderText = "Aksi";
                buttonLihatAkun.UseColumnTextForButtonValue = true;
                buttonLihatAkun.Name = "buttonLihatAkun";
                dataGridViewDaftarTeman.Columns.Add(buttonLihatAkun);
            }
        }

        private void DisplayRequestPertemanan()
        {
            flowLayoutPanelRequestPertemanan.AutoScroll = true;
            flowLayoutPanelRequestPertemanan.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelRequestPertemanan.WrapContents = false;
            flowLayoutPanelRequestPertemanan.Controls.Clear();

            for (int i = 0; i < 2; i++) // Note buat UI ini nanti kalian harus ganti foreach
            {
                UC_RequestPertemananMasuk rpm = new UC_RequestPertemananMasuk(this);

                this.flowLayoutPanelRequestPertemanan.Controls.Add(rpm);
            }
        }
        #endregion
    }
}
