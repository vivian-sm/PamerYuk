namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_RequestPertemananMasuk
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
            this.buttonTerima = new System.Windows.Forms.Button();
            this.buttonTolak = new System.Windows.Forms.Button();
            this.labelTanggalKirim = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTerima
            // 
            this.buttonTerima.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonTerima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerima.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTerima.Location = new System.Drawing.Point(620, 13);
            this.buttonTerima.Name = "buttonTerima";
            this.buttonTerima.Size = new System.Drawing.Size(280, 54);
            this.buttonTerima.TabIndex = 10;
            this.buttonTerima.Text = "Terima Permintaan Pertemanan";
            this.buttonTerima.UseVisualStyleBackColor = false;
            // 
            // buttonTolak
            // 
            this.buttonTolak.BackColor = System.Drawing.Color.Red;
            this.buttonTolak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTolak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTolak.Location = new System.Drawing.Point(973, 13);
            this.buttonTolak.Name = "buttonTolak";
            this.buttonTolak.Size = new System.Drawing.Size(280, 54);
            this.buttonTolak.TabIndex = 9;
            this.buttonTolak.Text = "Tolak Permintaan Pertemanan";
            this.buttonTolak.UseVisualStyleBackColor = false;
            // 
            // labelTanggalKirim
            // 
            this.labelTanggalKirim.AutoSize = true;
            this.labelTanggalKirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggalKirim.Location = new System.Drawing.Point(308, 28);
            this.labelTanggalKirim.Name = "labelTanggalKirim";
            this.labelTanggalKirim.Size = new System.Drawing.Size(121, 22);
            this.labelTanggalKirim.TabIndex = 8;
            this.labelTanggalKirim.Text = "Tanggal Kirim";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(26, 28);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(92, 22);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // UC_RequestPertemananMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.buttonTerima);
            this.Controls.Add(this.buttonTolak);
            this.Controls.Add(this.labelTanggalKirim);
            this.Controls.Add(this.labelUsername);
            this.Name = "UC_RequestPertemananMasuk";
            this.Size = new System.Drawing.Size(1278, 80);
            this.Load += new System.EventHandler(this.UC_RequestPertemananMasuk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTerima;
        private System.Windows.Forms.Button buttonTolak;
        private System.Windows.Forms.Label labelTanggalKirim;
        private System.Windows.Forms.Label labelUsername;
    }
}
