namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_KontenDetail
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
            this.labelLikeQuantity = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.PictureBox();
            this.btnKirim = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.pictureBoxKonten = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLikeQuantity
            // 
            this.labelLikeQuantity.AutoSize = true;
            this.labelLikeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikeQuantity.Location = new System.Drawing.Point(114, 401);
            this.labelLikeQuantity.Name = "labelLikeQuantity";
            this.labelLikeQuantity.Size = new System.Drawing.Size(104, 20);
            this.labelLikeQuantity.TabIndex = 90;
            this.labelLikeQuantity.Text = "Jumlah Like";
            // 
            // buttonLike
            // 
            this.buttonLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLike.Image = global::PamerYukFormsApp.Properties.Resources.Like_false;
            this.buttonLike.Location = new System.Drawing.Point(65, 389);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(45, 46);
            this.buttonLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonLike.TabIndex = 89;
            this.buttonLike.TabStop = false;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // btnKirim
            // 
            this.btnKirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKirim.Image = global::PamerYukFormsApp.Properties.Resources.SendMessage;
            this.btnKirim.Location = new System.Drawing.Point(779, 395);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(36, 36);
            this.btnKirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKirim.TabIndex = 88;
            this.btnKirim.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 389);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(373, 46);
            this.textBox2.TabIndex = 87;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(389, 170);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 202);
            this.textBox1.TabIndex = 86;
            this.textBox1.Text = "Komentar";
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCaption.Location = new System.Drawing.Point(389, 65);
            this.textBoxCaption.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCaption.Multiline = true;
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(438, 86);
            this.textBoxCaption.TabIndex = 85;
            this.textBoxCaption.Text = "Caption";
            // 
            // pictureBoxKonten
            // 
            this.pictureBoxKonten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxKonten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKonten.Image = global::PamerYukFormsApp.Properties.Resources.Tambahkonten_false;
            this.pictureBoxKonten.Location = new System.Drawing.Point(49, 65);
            this.pictureBoxKonten.Name = "pictureBoxKonten";
            this.pictureBoxKonten.Size = new System.Drawing.Size(307, 307);
            this.pictureBoxKonten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxKonten.TabIndex = 84;
            this.pictureBoxKonten.TabStop = false;
            // 
            // UC_KontenDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelLikeQuantity);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxCaption);
            this.Controls.Add(this.pictureBoxKonten);
            this.Name = "UC_KontenDetail";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.UC_KontenDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLikeQuantity;
        private System.Windows.Forms.PictureBox buttonLike;
        private System.Windows.Forms.PictureBox btnKirim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.PictureBox pictureBoxKonten;
    }
}
