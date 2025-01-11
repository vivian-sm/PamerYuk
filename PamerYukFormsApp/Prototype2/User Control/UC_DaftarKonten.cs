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
    public partial class UC_DaftarKonten : UserControl
    {
        MainForm mainForm;
        public UC_DaftarKonten(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void labelKontenSaya_Click(object sender, EventArgs e)
        {
            labelTambahKonten.ForeColor = Color.Gray;
            labelKontenSaya.ForeColor = SystemColors.MenuHighlight;

            panelKonten.Controls.Clear();

            UC_KontenSaya uC_KontenSaya = new UC_KontenSaya(this);
            panelKonten.Controls.Remove(this);
            panelKonten.Controls.Add(uC_KontenSaya);
        }

        private void labelTambahKonten_Click(object sender, EventArgs e)
        {
            labelTambahKonten.ForeColor = SystemColors.MenuHighlight;
            labelKontenSaya.ForeColor = Color.Gray;

            panelKonten.Controls.Clear();

            UC_TambahKonten uC_Daftar = new UC_TambahKonten(this);
            panelKonten.Controls.Remove(this);
            panelKonten.Controls.Add(uC_Daftar);
        }

        private void UC_DaftarKonten_Load(object sender, EventArgs e)
        {
            mainForm.panel1.Show();
            mainForm.panel1.BringToFront();
        }
    }
}
