namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_DaftarKonten
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
            this.panelKonten = new System.Windows.Forms.Panel();
            this.panelOption = new System.Windows.Forms.Panel();
            this.labelTambahKonten = new System.Windows.Forms.Label();
            this.labelKontenSaya = new System.Windows.Forms.Label();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonten.Location = new System.Drawing.Point(0, 100);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(1278, 678);
            this.panelKonten.TabIndex = 3;
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelOption.Controls.Add(this.labelTambahKonten);
            this.panelOption.Controls.Add(this.labelKontenSaya);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(1278, 100);
            this.panelOption.TabIndex = 2;
            // 
            // labelTambahKonten
            // 
            this.labelTambahKonten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTambahKonten.AutoSize = true;
            this.labelTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahKonten.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTambahKonten.Location = new System.Drawing.Point(237, 36);
            this.labelTambahKonten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTambahKonten.Name = "labelTambahKonten";
            this.labelTambahKonten.Size = new System.Drawing.Size(259, 37);
            this.labelTambahKonten.TabIndex = 40;
            this.labelTambahKonten.Text = "Tambah Konten";
            this.labelTambahKonten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTambahKonten.Click += new System.EventHandler(this.labelTambahKonten_Click);
            // 
            // labelKontenSaya
            // 
            this.labelKontenSaya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelKontenSaya.AutoSize = true;
            this.labelKontenSaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKontenSaya.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelKontenSaya.Location = new System.Drawing.Point(760, 36);
            this.labelKontenSaya.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKontenSaya.Name = "labelKontenSaya";
            this.labelKontenSaya.Size = new System.Drawing.Size(210, 37);
            this.labelKontenSaya.TabIndex = 39;
            this.labelKontenSaya.Text = "Konten Saya";
            this.labelKontenSaya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKontenSaya.Click += new System.EventHandler(this.labelKontenSaya_Click);
            // 
            // UC_DaftarKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelOption);
            this.Name = "UC_DaftarKonten";
            this.Size = new System.Drawing.Size(1278, 778);
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Label labelTambahKonten;
        private System.Windows.Forms.Label labelKontenSaya;
    }
}
