namespace PamerYukFormsApp.Prototype
{
    partial class FormTambahOrganisasi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKota = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.Organisasi = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelKota.Location = new System.Drawing.Point(283, 549);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(156, 54);
            this.labelKota.TabIndex = 56;
            this.labelKota.Text = "Kota : ";
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonInput.Location = new System.Drawing.Point(1250, 659);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(356, 75);
            this.buttonInput.TabIndex = 55;
            this.buttonInput.Text = "Input Organisasi";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNama.Location = new System.Drawing.Point(806, 425);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(800, 60);
            this.textBoxNama.TabIndex = 54;
            // 
            // Organisasi
            // 
            this.Organisasi.AutoSize = true;
            this.Organisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.Organisasi.Location = new System.Drawing.Point(475, 169);
            this.Organisasi.Name = "Organisasi";
            this.Organisasi.Size = new System.Drawing.Size(1004, 120);
            this.Organisasi.TabIndex = 53;
            this.Organisasi.Text = "Tambah Organisasi";
            this.Organisasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(283, 431);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(422, 54);
            this.labelUsername.TabIndex = 52;
            this.labelUsername.Text = "Nama Organisasi : ";
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(806, 549);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(800, 62);
            this.comboBoxKota.TabIndex = 58;
            // 
            // FormTambahOrganisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.comboBoxKota);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.Organisasi);
            this.Controls.Add(this.labelUsername);
            this.Name = "FormTambahOrganisasi";
            this.Text = "FormTambahOrganisasi";
            this.Load += new System.EventHandler(this.FormTambahOrganisasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label Organisasi;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ComboBox comboBoxKota;
    }
}