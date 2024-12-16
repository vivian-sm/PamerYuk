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

namespace PamerYukFormsApp.Prototype
{
    public partial class FormDaftarKonten : Form
    {
        private User selectedUser;
        public FormDaftarKonten(User user)
        {
            InitializeComponent();
            this.selectedUser = user;
        }

        private void FormDaftarKonten_Load(object sender, EventArgs e)
        {
            foreach (Konten k in selectedUser.ListKonten)
            {
                dataGridViewDaftarKonten.Rows.Add(k.Id,k.Caption,k.TglUpload);
            }
            if(dataGridViewDaftarKonten.Columns.Count ==3)
            {
                DataGridViewButtonColumn btnLihat = new DataGridViewButtonColumn();
                btnLihat.Text = "Lihat";
                btnLihat.HeaderText = "Lihat Konten";
                btnLihat.UseColumnTextForButtonValue = true;
                btnLihat.Name = "btnLihat";
                dataGridViewDaftarKonten.Columns.Add(btnLihat);
            }
        }

        private void dataGridViewDaftarKonten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridViewDaftarKonten.Columns["btnLihat"].Index)
            {
                int kid = int.Parse(dataGridViewDaftarKonten.CurrentRow.Cells["id"].Value.ToString());
                FormKonten frm = new FormKonten(FormUtama.service.Lihat_Konten(kid));
                frm.Owner = this;
                frm.ShowDialog();
            }
        }
    }
}
