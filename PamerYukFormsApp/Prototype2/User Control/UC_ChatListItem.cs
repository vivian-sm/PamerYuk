using PamerYukLibrary;
using PamerYukLibrary.Entity;
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
    public partial class UC_ChatListItem : UserControl
    {
        UC_Chat uc_Chat;
        Panel panel;

        private string name;
        private string message;
        private Image image;

        public string Name1
        {
            get { return name; }
            set { name = value; labelContactName.Text = value; }
        }

        public string Message
        {
            get { return message; }
            set { Message = value; labelLastMessage.Text = value; }
        }

        public Image Image
        {
            get { return image; }
            set { Image = value; profilePicture.Image = value; }
        }

        public UC_ChatListItem(UC_Chat uc_Chat)
        {
            InitializeComponent();
            this.uc_Chat = uc_Chat;
        }



        private void UC_ChatListItem_Load(object sender, EventArgs e)
        {
            /*List<Chat> listChat = MainForm.service.Buka_Chat();*/
        }

        public void Testing(int index)
        {
            if (index == 0)
            {
                labelContactName.Text = "Nama1";
            }
            else if (index == 1)
            {
                labelContactName.Text = "Nama2";
            }
        }
    }
}
