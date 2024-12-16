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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDaftarTeman
            // 
            this.dataGridViewDaftarTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarTeman.Location = new System.Drawing.Point(52, 318);
            this.dataGridViewDaftarTeman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDaftarTeman.Name = "dataGridViewDaftarTeman";
            this.dataGridViewDaftarTeman.RowHeadersWidth = 82;
            this.dataGridViewDaftarTeman.RowTemplate.Height = 33;
            this.dataGridViewDaftarTeman.Size = new System.Drawing.Size(1794, 624);
            this.dataGridViewDaftarTeman.TabIndex = 63;
            this.dataGridViewDaftarTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarTeman_CellContentClick);
            // 
            // buttonCari
            // 
            this.buttonCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCari.Location = new System.Drawing.Point(1416, 234);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(202, 64);
            this.buttonCari.TabIndex = 62;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // comboBoxOrganisasi
            // 
            this.comboBoxOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxOrganisasi.FormattingEnabled = true;
            this.comboBoxOrganisasi.Location = new System.Drawing.Point(780, 232);
            this.comboBoxOrganisasi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOrganisasi.Name = "comboBoxOrganisasi";
            this.comboBoxOrganisasi.Size = new System.Drawing.Size(554, 62);
            this.comboBoxOrganisasi.TabIndex = 61;
            this.comboBoxOrganisasi.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrganisasi_SelectedIndexChanged);
            // 
            // labelNamaOrganisasi
            // 
            this.labelNamaOrganisasi.AutoSize = true;
            this.labelNamaOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNamaOrganisasi.Location = new System.Drawing.Point(770, 172);
            this.labelNamaOrganisasi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaOrganisasi.Name = "labelNamaOrganisasi";
            this.labelNamaOrganisasi.Size = new System.Drawing.Size(285, 54);
            this.labelNamaOrganisasi.TabIndex = 60;
            this.labelNamaOrganisasi.Text = "Organisasi : ";
            // 
            // labelFormCariTeman
            // 
            this.labelFormCariTeman.AutoSize = true;
            this.labelFormCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormCariTeman.Location = new System.Drawing.Point(594, 50);
            this.labelFormCariTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormCariTeman.Name = "labelFormCariTeman";
            this.labelFormCariTeman.Size = new System.Drawing.Size(619, 120);
            this.labelFormCariTeman.TabIndex = 59;
            this.labelFormCariTeman.Text = "Cari Teman";
            this.labelFormCariTeman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUsername.Location = new System.Drawing.Point(52, 232);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(632, 60);
            this.textBoxUsername.TabIndex = 64;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(42, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 54);
            this.label1.TabIndex = 65;
            this.label1.Text = "Username : ";
            // 
            // FormTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.dataGridViewDaftarTeman);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.comboBoxOrganisasi);
            this.Controls.Add(this.labelNamaOrganisasi);
            this.Controls.Add(this.labelFormCariTeman);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTeman";
            this.Text = "FormTeman";
            this.Load += new System.EventHandler(this.FormTeman_Load);
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
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
    }
}