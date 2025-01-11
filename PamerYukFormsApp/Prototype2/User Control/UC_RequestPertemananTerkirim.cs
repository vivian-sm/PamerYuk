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
    public partial class UC_RequestPertemananTerkirim : UserControl
    {
        UC_Home uc;
        public UC_RequestPertemananTerkirim(UC_Home uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void UC_RequestPertemananTerkirim_Load(object sender, EventArgs e)
        {

        }
    }
}
