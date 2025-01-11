namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_Chat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelContactName = new System.Windows.Forms.Label();
            this.panelContactHeader = new System.Windows.Forms.Panel();
            this.flowLayoutPanelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.PictureBox();
            this.panelSendMessage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelContactHeader.SuspendLayout();
            this.panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).BeginInit();
            this.panelSendMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::PamerYukFormsApp.Properties.Resources.default_profile_picture;
            this.pictureBoxProfile.Location = new System.Drawing.Point(20, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactName.Location = new System.Drawing.Point(127, 29);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(165, 29);
            this.labelContactName.TabIndex = 4;
            this.labelContactName.Text = "Contact Name";
            // 
            // panelContactHeader
            // 
            this.panelContactHeader.Controls.Add(this.labelContactName);
            this.panelContactHeader.Controls.Add(this.pictureBoxProfile);
            this.panelContactHeader.Location = new System.Drawing.Point(442, 0);
            this.panelContactHeader.Name = "panelContactHeader";
            this.panelContactHeader.Size = new System.Drawing.Size(836, 89);
            this.panelContactHeader.TabIndex = 7;
            // 
            // flowLayoutPanelChat
            // 
            this.flowLayoutPanelChat.AutoScroll = true;
            this.flowLayoutPanelChat.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanelChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChat.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            this.flowLayoutPanelChat.Size = new System.Drawing.Size(442, 683);
            this.flowLayoutPanelChat.TabIndex = 6;
            this.flowLayoutPanelChat.WrapContents = false;
            // 
            // panelChat
            // 
            this.panelChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChat.Controls.Add(this.listBoxChat);
            this.panelChat.Location = new System.Drawing.Point(442, 86);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(836, 515);
            this.panelChat.TabIndex = 8;
            // 
            // listBoxChat
            // 
            this.listBoxChat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 20;
            this.listBoxChat.Location = new System.Drawing.Point(0, 0);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(836, 515);
            this.listBoxChat.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 44);
            this.textBox1.TabIndex = 7;
            // 
            // btnKirim
            // 
            this.btnKirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKirim.Image = global::PamerYukFormsApp.Properties.Resources.SendMessage;
            this.btnKirim.Location = new System.Drawing.Point(745, 14);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(50, 50);
            this.btnKirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKirim.TabIndex = 8;
            this.btnKirim.TabStop = false;
            // 
            // panelSendMessage
            // 
            this.panelSendMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSendMessage.Controls.Add(this.btnKirim);
            this.panelSendMessage.Controls.Add(this.textBox1);
            this.panelSendMessage.Location = new System.Drawing.Point(442, 587);
            this.panelSendMessage.Name = "panelSendMessage";
            this.panelSendMessage.Size = new System.Drawing.Size(836, 191);
            this.panelSendMessage.TabIndex = 9;
            // 
            // UC_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelSendMessage);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.flowLayoutPanelChat);
            this.Controls.Add(this.panelContactHeader);
            this.Name = "UC_Chat";
            this.Size = new System.Drawing.Size(1278, 778);
            this.Load += new System.EventHandler(this.UC_Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelContactHeader.ResumeLayout(false);
            this.panelContactHeader.PerformLayout();
            this.panelChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).EndInit();
            this.panelSendMessage.ResumeLayout(false);
            this.panelSendMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.Panel panelContactHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChat;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btnKirim;
        private System.Windows.Forms.Panel panelSendMessage;
    }
}
