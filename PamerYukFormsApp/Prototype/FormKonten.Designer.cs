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
            this.labelFormKonten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxKomentar
            // 
            this.listBoxKomentar.FormattingEnabled = true;
            this.listBoxKomentar.ItemHeight = 25;
            this.listBoxKomentar.Location = new System.Drawing.Point(596, 216);
            this.listBoxKomentar.Name = "listBoxKomentar";
            this.listBoxKomentar.Size = new System.Drawing.Size(786, 554);
            this.listBoxKomentar.TabIndex = 74;
            // 
            // labelKomentar
            // 
            this.labelKomentar.AutoSize = true;
            this.labelKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelKomentar.Location = new System.Drawing.Point(588, 144);
            this.labelKomentar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKomentar.Name = "labelKomentar";
            this.labelKomentar.Size = new System.Drawing.Size(216, 44);
            this.labelKomentar.TabIndex = 73;
            this.labelKomentar.Text = "Komentar : ";
            // 
            // listBoxDeskripsi
            // 
            this.listBoxDeskripsi.FormattingEnabled = true;
            this.listBoxDeskripsi.ItemHeight = 25;
            this.listBoxDeskripsi.Location = new System.Drawing.Point(42, 531);
            this.listBoxDeskripsi.Name = "listBoxDeskripsi";
            this.listBoxDeskripsi.Size = new System.Drawing.Size(501, 229);
            this.listBoxDeskripsi.TabIndex = 72;
            // 
            // labelDeskripsi
            // 
            this.labelDeskripsi.AutoSize = true;
            this.labelDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDeskripsi.Location = new System.Drawing.Point(34, 463);
            this.labelDeskripsi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeskripsi.Name = "labelDeskripsi";
            this.labelDeskripsi.Size = new System.Drawing.Size(207, 44);
            this.labelDeskripsi.TabIndex = 71;
            this.labelDeskripsi.Text = "Deskripsi : ";
            // 
            // panelKonten
            // 
            this.panelKonten.Location = new System.Drawing.Point(42, 144);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(2);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(501, 292);
            this.panelKonten.TabIndex = 70;
            // 
            // labelFormKonten
            // 
            this.labelFormKonten.AutoSize = true;
            this.labelFormKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormKonten.Location = new System.Drawing.Point(411, 30);
            this.labelFormKonten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormKonten.Name = "labelFormKonten";
            this.labelFormKonten.Size = new System.Drawing.Size(545, 97);
            this.labelFormKonten.TabIndex = 69;
            this.labelFormKonten.Text = "Konten Saya";
            this.labelFormKonten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 800);
            this.Controls.Add(this.listBoxKomentar);
            this.Controls.Add(this.labelKomentar);
            this.Controls.Add(this.listBoxDeskripsi);
            this.Controls.Add(this.labelDeskripsi);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.labelFormKonten);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKonten";
            this.Text = "FormKonten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKomentar;
        private System.Windows.Forms.Label labelKomentar;
        private System.Windows.Forms.ListBox listBoxDeskripsi;
        private System.Windows.Forms.Label labelDeskripsi;
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Label labelFormKonten;
    }
}