﻿namespace PamerYukFormsApp.Prototype
{
    partial class FormTambahKonten
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
            this.buttonGantiGambar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.listBoxDeskripsi = new System.Windows.Forms.ListBox();
            this.labelDeskripsi = new System.Windows.Forms.Label();
            this.labelGambar = new System.Windows.Forms.Label();
            this.labelFormTambahKonten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGantiGambar
            // 
            this.buttonGantiGambar.Location = new System.Drawing.Point(511, 509);
            this.buttonGantiGambar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGantiGambar.Name = "buttonGantiGambar";
            this.buttonGantiGambar.Size = new System.Drawing.Size(207, 82);
            this.buttonGantiGambar.TabIndex = 74;
            this.buttonGantiGambar.Text = "Ganti Gambar";
            this.buttonGantiGambar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(71, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 413);
            this.panel1.TabIndex = 73;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonTambah.Location = new System.Drawing.Point(1612, 928);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(227, 63);
            this.buttonTambah.TabIndex = 72;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // listBoxDeskripsi
            // 
            this.listBoxDeskripsi.FormattingEnabled = true;
            this.listBoxDeskripsi.ItemHeight = 31;
            this.listBoxDeskripsi.Location = new System.Drawing.Point(60, 707);
            this.listBoxDeskripsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxDeskripsi.Name = "listBoxDeskripsi";
            this.listBoxDeskripsi.Size = new System.Drawing.Size(1777, 190);
            this.listBoxDeskripsi.TabIndex = 71;
            // 
            // labelDeskripsi
            // 
            this.labelDeskripsi.AutoSize = true;
            this.labelDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDeskripsi.Location = new System.Drawing.Point(49, 622);
            this.labelDeskripsi.Name = "labelDeskripsi";
            this.labelDeskripsi.Size = new System.Drawing.Size(254, 54);
            this.labelDeskripsi.TabIndex = 70;
            this.labelDeskripsi.Text = "Deskripsi : ";
            // 
            // labelGambar
            // 
            this.labelGambar.AutoSize = true;
            this.labelGambar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelGambar.Location = new System.Drawing.Point(73, 110);
            this.labelGambar.Name = "labelGambar";
            this.labelGambar.Size = new System.Drawing.Size(230, 54);
            this.labelGambar.TabIndex = 67;
            this.labelGambar.Text = "Gambar : ";
            // 
            // labelFormTambahKonten
            // 
            this.labelFormTambahKonten.AutoSize = true;
            this.labelFormTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormTambahKonten.Location = new System.Drawing.Point(503, 2);
            this.labelFormTambahKonten.Name = "labelFormTambahKonten";
            this.labelFormTambahKonten.Size = new System.Drawing.Size(826, 120);
            this.labelFormTambahKonten.TabIndex = 66;
            this.labelFormTambahKonten.Text = "Tambah Konten";
            this.labelFormTambahKonten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTambahKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 1019);
            this.Controls.Add(this.buttonGantiGambar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.listBoxDeskripsi);
            this.Controls.Add(this.labelDeskripsi);
            this.Controls.Add(this.labelGambar);
            this.Controls.Add(this.labelFormTambahKonten);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTambahKonten";
            this.Text = "FormTambahKonten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGantiGambar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.ListBox listBoxDeskripsi;
        private System.Windows.Forms.Label labelDeskripsi;
        private System.Windows.Forms.Label labelGambar;
        private System.Windows.Forms.Label labelFormTambahKonten;
    }
}