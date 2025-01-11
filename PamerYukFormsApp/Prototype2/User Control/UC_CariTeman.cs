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
    public partial class UC_CariTeman : UserControl
    {
        UC_Home uc;
        public UC_CariTeman(UC_Home uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_CariTeman_Load(object sender, EventArgs e)
        {

        }
    }
}
