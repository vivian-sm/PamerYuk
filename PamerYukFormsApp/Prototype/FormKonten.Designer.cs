﻿namespace PamerYukFormsApp.Prototype
{
    partial class FormKonten
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
            this.listBoxKomentar = new System.Windows.Forms.ListBox();
            this.labelKomentar = new System.Windows.Forms.Label();
            this.listBoxDeskripsi = new System.Windows.Forms.ListBox();
            this.labelDeskripsi = new System.Windows.Forms.Label();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.textBoxKomen = new System.Windows.Forms.TextBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.labelLike = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxKomentar
            // 
            this.listBoxKomentar.FormattingEnabled = true;
            this.listBoxKomentar.ItemHeight = 20;
            this.listBoxKomentar.Location = new System.Drawing.Point(447, 74);
            this.listBoxKomentar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxKomentar.Name = "listBoxKomentar";
            this.listBoxKomentar.Size = new System.Drawing.Size(591, 404);
            this.listBoxKomentar.TabIndex = 74;
            // 
            // labelKomentar
            // 
            this.labelKomentar.AutoSize = true;
            this.labelKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelKomentar.Location = new System.Drawing.Point(442, 19);
            this.labelKomentar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKomentar.Name = "labelKomentar";
            this.labelKomentar.Size = new System.Drawing.Size(159, 32);
            this.labelKomentar.TabIndex = 73;
            this.labelKomentar.Text = "Komentar : ";
            // 
            // listBoxDeskripsi
            // 
            this.listBoxDeskripsi.FormattingEnabled = true;
            this.listBoxDeskripsi.ItemHeight = 20;
            this.listBoxDeskripsi.Location = new System.Drawing.Point(32, 425);
            this.listBoxDeskripsi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxDeskripsi.Name = "listBoxDeskripsi";
            this.listBoxDeskripsi.Size = new System.Drawing.Size(377, 184);
            this.listBoxDeskripsi.TabIndex = 72;
            // 
            // labelDeskripsi
            // 
            this.labelDeskripsi.AutoSize = true;
            this.labelDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDeskripsi.Location = new System.Drawing.Point(25, 370);
            this.labelDeskripsi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeskripsi.Name = "labelDeskripsi";
            this.labelDeskripsi.Size = new System.Drawing.Size(153, 32);
            this.labelDeskripsi.TabIndex = 71;
            this.labelDeskripsi.Text = "Deskripsi : ";
            // 
            // panelKonten
            // 
            this.panelKonten.Location = new System.Drawing.Point(32, 19);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(376, 330);
            this.panelKonten.TabIndex = 70;
            this.panelKonten.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKonten_Paint);
            // 
            // textBoxKomen
            // 
            this.textBoxKomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxKomen.Location = new System.Drawing.Point(447, 568);
            this.textBoxKomen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKomen.Name = "textBoxKomen";
            this.textBoxKomen.Size = new System.Drawing.Size(464, 39);
            this.textBoxKomen.TabIndex = 75;
            // 
            // buttonKirim
            // 
            this.buttonKirim.Location = new System.Drawing.Point(925, 568);
            this.buttonKirim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(111, 39);
            this.buttonKirim.TabIndex = 76;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = true;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // labelLike
            // 
            this.labelLike.AutoSize = true;
            this.labelLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelLike.Location = new System.Drawing.Point(533, 503);
            this.labelLike.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLike.Name = "labelLike";
            this.labelLike.Size = new System.Drawing.Size(74, 32);
            this.labelLike.TabIndex = 77;
            this.labelLike.Text = "Like ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(442, 503);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 78;
            this.label1.Text = "Like :";
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(925, 503);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(111, 39);
            this.buttonLike.TabIndex = 79;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // FormKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 640);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLike);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.textBoxKomen);
            this.Controls.Add(this.listBoxKomentar);
            this.Controls.Add(this.labelKomentar);
            this.Controls.Add(this.listBoxDeskripsi);
            this.Controls.Add(this.labelDeskripsi);
            this.Controls.Add(this.panelKonten);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormKonten";
            this.Text = "FormKonten";
            this.Load += new System.EventHandler(this.FormKonten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKomentar;
        private System.Windows.Forms.Label labelKomentar;
        private System.Windows.Forms.ListBox listBoxDeskripsi;
        private System.Windows.Forms.Label labelDeskripsi;
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.TextBox textBoxKomen;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.Label labelLike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLike;
    }
}