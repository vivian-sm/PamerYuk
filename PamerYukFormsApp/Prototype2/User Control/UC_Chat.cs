using PamerYukLibrary;
using PamerYukLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PamerYukFormsApp.Prototype2.User_Control
{
    public partial class UC_Chat : UserControl
    {
        MainForm mainForm;
        public string pickChat;
        public UC_Chat(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void UC_Chat_Load(object sender, EventArgs e)
        {
            /* mainForm.panel1.Show();
             mainForm.panel1.BringToFront();
 */
            flowLayoutPanelChat.AutoScroll = true;
            flowLayoutPanelChat.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelChat.WrapContents = false;

            //Console.WriteLine("From UC_Chat Current User : "+MainForm.service.Current_user.ToString());
            /*for (int i = 0; i < 8; i++)
            {
                UC_ChatListItem cli = new UC_ChatListItem(this);
                cli.Testing(i);

                this.flowLayoutPanelChat.Controls.Add(cli);
            }*/

            Console.WriteLine("Jumlah Teman : "+MainForm.service.ListTeman.Count);

            for (int i = 0; i < MainForm.service.ListTeman.Count; i++)
            {
                UC_ChatListItem uc_chatListItem = new UC_ChatListItem(this);
                flowLayoutPanelChat.Controls.Add(uc_chatListItem);

            }
            // Clear the controls once, before adding all items            
            //UC_ChatListItem[] jumlahChat = new UC_ChatListItem[MainForm.service.ListTeman.Count];
            /*for (int i = 0; i < jumlahChat.Length; i++)
            {
                jumlahChat[i] = new UC_ChatListItem(this);
                jumlahChat[i].Name1 = "Kontak";
                jumlahChat[i].Message = "Message";

                // Add the new item to the flow layout panel
                flowLayoutPanelChat.Controls.Add(jumlahChat[i]);
                Console.WriteLine("Kontrol ditambahkan: " + jumlahChat[i].Name1);
            }*/

        }

    }
}
