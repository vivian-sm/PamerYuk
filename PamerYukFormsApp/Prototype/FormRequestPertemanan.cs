using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype
{
    public partial class FormRequestPertemanan : Form
    {
        public FormRequestPertemanan()
        {
            InitializeComponent();
        }

        private void FormRequestPertemanan_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonTerima_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTerima.Checked == true)
            {
                dataGridViewDaftarTeman.DataSource = FormUtama.service.Request_Pertemanan(false);
                if(dataGridViewDaftarTeman.Columns.Count == 3)
                {
                    DataGridViewButtonColumn btnTerima = new DataGridViewButtonColumn();
                    btnTerima.Text = "Terima";
                    btnTerima.HeaderText = "Terima";
                    btnTerima.UseColumnTextForButtonValue = true;
                    btnTerima.Name = "btnTerima";
                    dataGridViewDaftarTeman.Columns.Add(btnTerima);

                    DataGridViewButtonColumn btnTolak = new DataGridViewButtonColumn();
                    btnTolak.Text = "Tolak";
                    btnTolak.HeaderText = "Tolak";
                    btnTolak.UseColumnTextForButtonValue = true;
                    btnTolak.Name = "btnTolak";
                    dataGridViewDaftarTeman.Columns.Add(btnTolak);
                }
                else
                {
                    dataGridViewDaftarTeman.Columns.Remove("btnKirim");

                    DataGridViewButtonColumn btnTerima = new DataGridViewButtonColumn();
                    btnTerima.Text = "Terima";
                    btnTerima.HeaderText = "Terima";
                    btnTerima.UseColumnTextForButtonValue = true;
                    btnTerima.Name = "btnTerima";
                    dataGridViewDaftarTeman.Columns.Add(btnTerima);

                    DataGridViewButtonColumn btnTolak = new DataGridViewButtonColumn();
                    btnTolak.Text = "Tolak";
                    btnTolak.HeaderText = "Tolak";
                    btnTolak.UseColumnTextForButtonValue = true;
                    btnTolak.Name = "btnTolak";
                    dataGridViewDaftarTeman.Columns.Add(btnTolak);
                }
            }
        }

        private void radioButtonKirim_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKirim.Checked == true)
            {
                dataGridViewDaftarTeman.DataSource = FormUtama.service.Request_Pertemanan(true);
                if (dataGridViewDaftarTeman.Columns.Count == 3)
                {
                    DataGridViewButtonColumn btnKirim = new DataGridViewButtonColumn();
                    btnKirim.Text = "Kirim Ulang";
                    btnKirim.HeaderText = "Kirim Ulang Permintaan";
                    btnKirim.UseColumnTextForButtonValue = true;
                    btnKirim.Name = "btnKirim";
                    dataGridViewDaftarTeman.Columns.Add(btnKirim);
                }
                else
                {
                    dataGridViewDaftarTeman.Columns.Remove("btnTerima");
                    dataGridViewDaftarTeman.Columns.Remove("btnTolak");

                    DataGridViewButtonColumn btnKirim = new DataGridViewButtonColumn();
                    btnKirim.Text = "Kirim Ulang";
                    btnKirim.HeaderText = "Kirim Ulang Permintaan";
                    btnKirim.UseColumnTextForButtonValue = true;
                    btnKirim.Name = "btnKirim";
                    dataGridViewDaftarTeman.Columns.Add(btnKirim);
                }
            }

        }

        private void dataGridViewDaftarTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string username = dataGridViewDaftarTeman.CurrentRow.Cells["username"].Value.ToString();
            if(radioButtonTerima.Checked == true)
            {
                if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["btnTerima"].Index)
                {
                    FormUtama.service.Terima_Pertemanan(username);
                }
                if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["btnTolak"].Index)
                {
                    FormUtama.service.Tolak_Pertemanan(username);
                }

            }
            else
            {
                if (e.ColumnIndex == dataGridViewDaftarTeman.Columns["btnKirim"].Index)
                {
                    FormUtama.service.KirimUlang_Pertemanan(username);
                }
            }

        }
    }
}
