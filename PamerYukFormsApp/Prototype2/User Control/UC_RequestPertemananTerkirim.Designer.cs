namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_RequestPertemananTerkirim
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
            this.buttonKirimUlang = new System.Windows.Forms.Button();
            this.labelTanggalKirim = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKirimUlang
            // 
            this.buttonKirimUlang.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonKirimUlang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKirimUlang.Location = new System.Drawing.Point(893, 13);
            this.buttonKirimUlang.Name = "buttonKirimUlang";
            this.buttonKirimUlang.Size = new System.Drawing.Size(357, 54);
            this.buttonKirimUlang.TabIndex = 5;
            this.buttonKirimUlang.Text = "Kirim Ulang Permintaan Pertemanan";
            this.buttonKirimUlang.UseVisualStyleBackColor = false;
            // 
            // labelTanggalKirim
            // 
            this.labelTanggalKirim.AutoSize = true;
            this.labelTanggalKirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalKirim.Location = new System.Drawing.Point(468, 28);
            this.labelTanggalKirim.Name = "labelTanggalKirim";
            this.labelTanggalKirim.Size = new System.Drawing.Size(121, 22);
            this.labelTanggalKirim.TabIndex = 4;
            this.labelTanggalKirim.Text = "Tanggal Kirim";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(29, 28);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(92, 22);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // UC_RequestPertemananTerkirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.buttonKirimUlang);
            this.Controls.Add(this.labelTanggalKirim);
            this.Controls.Add(this.labelUsername);
            this.Name = "UC_RequestPertemananTerkirim";
            this.Size = new System.Drawing.Size(1278, 80);
            this.Load += new System.EventHandler(this.UC_RequestPertemananTerkirim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKirimUlang;
        private System.Windows.Forms.Label labelTanggalKirim;
        private System.Windows.Forms.Label labelUsername;
    }
}
