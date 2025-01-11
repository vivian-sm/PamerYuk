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
    public partial class UC_KontenDetail : UserControl
    {
        UC_KontenSaya uc;
        UC_ProfilTeman uC_ProfilTeman;

        public UC_KontenDetail(UC_KontenSaya uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        public UC_KontenDetail(UC_ProfilTeman uc)
        {
            InitializeComponent();
            this.uC_ProfilTeman = uc;
        }

        private void UC_KontenDetail_Load(object sender, EventArgs e)
        {

        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            if (buttonLike.Image == Properties.Resources.Like_true)
            {
                buttonLike.Image = Properties.Resources.Like_false;
            }
            else if (buttonLike.Image == Properties.Resources.Like_false)
            {
                buttonLike.Image = Properties.Resources.Like_true;
            }
        }
    }
}
