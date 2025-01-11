namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_TambahOrganisasi
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
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrganisasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(149, 387);
            this.comboBoxKota.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(980, 40);
            this.comboBoxKota.TabIndex = 119;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSimpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSimpan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSimpan.Location = new System.Drawing.Point(149, 473);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(980, 50);
            this.buttonSimpan.TabIndex = 118;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(460, 55);
            this.label10.TabIndex = 117;
            this.label10.Text = "Tambah Organisasi";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 115;
            this.label7.Text = "Organisasi:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 114;
            this.label1.Text = "Kota:";
            // 
            // textBoxOrganisasi
            // 
            this.textBoxOrganisasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOrganisasi.BackColor = System.Drawing.Color.White;
            this.textBoxOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxOrganisasi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxOrganisasi.Location = new System.Drawing.Point(149, 266);
            this.textBoxOrganisasi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrganisasi.Name = "textBoxOrganisasi";
            this.textBoxOrganisasi.Size = new System.Drawing.Size(980, 39);
            this.textBoxOrganisasi.TabIndex = 123;
            // 
            // UC_TambahOrganisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.textBoxOrganisasi);
            this.Controls.Add(this.comboBoxKota);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "UC_TambahOrganisasi";
            this.Size = new System.Drawing.Size(1296, 816);
            this.Load += new System.EventHandler(this.UC_TambahOrganisasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrganisasi;
    }
}
