namespace PamerYukFormsApp.Prototype
{
    partial class FormTeman
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
            this.dataGridViewDaftarTeman = new System.Windows.Forms.DataGridView();
            this.buttonCari = new System.Windows.Forms.Button();
            this.comboBoxOrganisasi = new System.Windows.Forms.ComboBox();
            this.labelNamaOrganisasi = new System.Windows.Forms.Label();
            this.labelFormCariTeman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDaftarTeman
            // 
            this.dataGridViewDaftarTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarTeman.Location = new System.Drawing.Point(39, 257);
            this.dataGridViewDaftarTeman.Name = "dataGridViewDaftarTeman";
            this.dataGridViewDaftarTeman.RowHeadersWidth = 82;
            this.dataGridViewDaftarTeman.RowTemplate.Height = 33;
            this.dataGridViewDaftarTeman.Size = new System.Drawing.Size(1346, 503);
            this.dataGridViewDaftarTeman.TabIndex = 63;
            // 
            // buttonCari
            // 
            this.buttonCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCari.Location = new System.Drawing.Point(727, 158);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(152, 51);
            this.buttonCari.TabIndex = 62;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrganisasi
            // 
            this.comboBoxOrganisasi.FormattingEnabled = true;
            this.comboBoxOrganisasi.Location = new System.Drawing.Point(269, 169);
            this.comboBoxOrganisasi.Name = "comboBoxOrganisasi";
            this.comboBoxOrganisasi.Size = new System.Drawing.Size(400, 33);
            this.comboBoxOrganisasi.TabIndex = 61;
            // 
            // labelNamaOrganisasi
            // 
            this.labelNamaOrganisasi.AutoSize = true;
            this.labelNamaOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNamaOrganisasi.Location = new System.Drawing.Point(31, 158);
            this.labelNamaOrganisasi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaOrganisasi.Name = "labelNamaOrganisasi";
            this.labelNamaOrganisasi.Size = new System.Drawing.Size(233, 44);
            this.labelNamaOrganisasi.TabIndex = 60;
            this.labelNamaOrganisasi.Text = "Organisasi : ";
            // 
            // labelFormCariTeman
            // 
            this.labelFormCariTeman.AutoSize = true;
            this.labelFormCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormCariTeman.Location = new System.Drawing.Point(445, 40);
            this.labelFormCariTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormCariTeman.Name = "labelFormCariTeman";
            this.labelFormCariTeman.Size = new System.Drawing.Size(503, 97);
            this.labelFormCariTeman.TabIndex = 59;
            this.labelFormCariTeman.Text = "Cari Teman";
            this.labelFormCariTeman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 800);
            this.Controls.Add(this.dataGridViewDaftarTeman);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.comboBoxOrganisasi);
            this.Controls.Add(this.labelNamaOrganisasi);
            this.Controls.Add(this.labelFormCariTeman);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTeman";
            this.Text = "FormTeman";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaftarTeman;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.ComboBox comboBoxOrganisasi;
        private System.Windows.Forms.Label labelNamaOrganisasi;
        private System.Windows.Forms.Label labelFormCariTeman;
    }
}