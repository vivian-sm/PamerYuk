namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_ChatListItem
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
            this.labelLastMessage = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastMessage
            // 
            this.labelLastMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLastMessage.AutoEllipsis = true;
            this.labelLastMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastMessage.Location = new System.Drawing.Point(187, 85);
            this.labelLastMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastMessage.Name = "labelLastMessage";
            this.labelLastMessage.Size = new System.Drawing.Size(222, 29);
            this.labelLastMessage.TabIndex = 51;
            this.labelLastMessage.Text = "Message";
            // 
            // labelContactName
            // 
            this.labelContactName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContactName.AutoEllipsis = true;
            this.labelContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactName.Location = new System.Drawing.Point(187, 39);
            this.labelContactName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(223, 32);
            this.labelContactName.TabIndex = 50;
            this.labelContactName.Text = "Contact Name";
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.profilePicture.Location = new System.Drawing.Point(33, 14);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(132, 122);
            this.profilePicture.TabIndex = 49;
            this.profilePicture.TabStop = false;
            // 
            // UC_ChatListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.labelLastMessage);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.profilePicture);
            this.Name = "UC_ChatListItem";
            this.Size = new System.Drawing.Size(442, 150);
            this.Load += new System.EventHandler(this.UC_ChatListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelLastMessage;
        public System.Windows.Forms.Label labelContactName;
        public System.Windows.Forms.PictureBox profilePicture;
    }
}
