namespace PamerYukFormsApp.Prototype
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
            this.SuspendLayout();
            // 
            // listBoxKomentar
            // 
            this.listBoxKomentar.FormattingEnabled = true;
            this.listBoxKomentar.ItemHeight = 31;
            this.listBoxKomentar.Location = new System.Drawing.Point(795, 113);
            this.listBoxKomentar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxKomentar.Name = "listBoxKomentar";
            this.listBoxKomentar.Size = new System.Drawing.Size(1047, 717);
            this.listBoxKomentar.TabIndex = 74;
            // 
            // labelKomentar
            // 
            this.labelKomentar.AutoSize = true;
            this.labelKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelKomentar.Location = new System.Drawing.Point(786, 29);
            this.labelKomentar.Name = "labelKomentar";
            this.labelKomentar.Size = new System.Drawing.Size(263, 54);
            this.labelKomentar.TabIndex = 73;
            this.labelKomentar.Text = "Komentar : ";
            // 
            // listBoxDeskripsi
            // 
            this.listBoxDeskripsi.FormattingEnabled = true;
            this.listBoxDeskripsi.ItemHeight = 31;
            this.listBoxDeskripsi.Location = new System.Drawing.Point(56, 658);
            this.listBoxDeskripsi.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDeskripsi.Name = "listBoxDeskripsi";
            this.listBoxDeskripsi.Size = new System.Drawing.Size(667, 283);
            this.listBoxDeskripsi.TabIndex = 72;
            // 
            // labelDeskripsi
            // 
            this.labelDeskripsi.AutoSize = true;
            this.labelDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDeskripsi.Location = new System.Drawing.Point(45, 574);
            this.labelDeskripsi.Name = "labelDeskripsi";
            this.labelDeskripsi.Size = new System.Drawing.Size(254, 54);
            this.labelDeskripsi.TabIndex = 71;
            this.labelDeskripsi.Text = "Deskripsi : ";
            // 
            // panelKonten
            // 
            this.panelKonten.Location = new System.Drawing.Point(56, 29);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(668, 512);
            this.panelKonten.TabIndex = 70;
            // 
            // textBoxKomen
            // 
            this.textBoxKomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxKomen.Location = new System.Drawing.Point(795, 881);
            this.textBoxKomen.Name = "textBoxKomen";
            this.textBoxKomen.Size = new System.Drawing.Size(821, 60);
            this.textBoxKomen.TabIndex = 75;
            // 
            // buttonKirim
            // 
            this.buttonKirim.Location = new System.Drawing.Point(1644, 881);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(198, 60);
            this.buttonKirim.TabIndex = 76;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = true;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // FormKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.textBoxKomen);
            this.Controls.Add(this.listBoxKomentar);
            this.Controls.Add(this.labelKomentar);
            this.Controls.Add(this.listBoxDeskripsi);
            this.Controls.Add(this.labelDeskripsi);
            this.Controls.Add(this.panelKonten);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}