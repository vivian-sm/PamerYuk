namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_CariTeman
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
            this.dataGridViewCariTeman = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonCari = new System.Windows.Forms.Button();
            this.comboBoxOrganisasi = new System.Windows.Forms.ComboBox();
            this.labelNamaOrganisasi = new System.Windows.Forms.Label();
            this.labelCariTeman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCariTeman
            // 
            this.dataGridViewCariTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCariTeman.Location = new System.Drawing.Point(40, 206);
            this.dataGridViewCariTeman.Name = "dataGridViewCariTeman";
            this.dataGridViewCariTeman.RowHeadersWidth = 62;
            this.dataGridViewCariTeman.RowTemplate.Height = 28;
            this.dataGridViewCariTeman.Size = new System.Drawing.Size(1188, 401);
            this.dataGridViewCariTeman.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "Username : ";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUsername.Location = new System.Drawing.Point(39, 138);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(357, 39);
            this.textBoxUsername.TabIndex = 76;
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCari.Location = new System.Drawing.Point(793, 126);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(435, 54);
            this.buttonCari.TabIndex = 75;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            // 
            // comboBoxOrganisasi
            // 
            this.comboBoxOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxOrganisasi.FormattingEnabled = true;
            this.comboBoxOrganisasi.Location = new System.Drawing.Point(444, 137);
            this.comboBoxOrganisasi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxOrganisasi.Name = "comboBoxOrganisasi";
            this.comboBoxOrganisasi.Size = new System.Drawing.Size(313, 40);
            this.comboBoxOrganisasi.TabIndex = 74;
            // 
            // labelNamaOrganisasi
            // 
            this.labelNamaOrganisasi.AutoSize = true;
            this.labelNamaOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaOrganisasi.Location = new System.Drawing.Point(439, 98);
            this.labelNamaOrganisasi.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelNamaOrganisasi.Name = "labelNamaOrganisasi";
            this.labelNamaOrganisasi.Size = new System.Drawing.Size(147, 29);
            this.labelNamaOrganisasi.TabIndex = 73;
            this.labelNamaOrganisasi.Text = "Organisasi : ";
            // 
            // labelCariTeman
            // 
            this.labelCariTeman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelCariTeman.AutoSize = true;
            this.labelCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariTeman.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCariTeman.Location = new System.Drawing.Point(30, 34);
            this.labelCariTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCariTeman.Name = "labelCariTeman";
            this.labelCariTeman.Size = new System.Drawing.Size(876, 55);
            this.labelCariTeman.TabIndex = 72;
            this.labelCariTeman.Text = "Cari Teman dan Ajukkan Pertemanan!";
            this.labelCariTeman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_CariTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dataGridViewCariTeman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.comboBoxOrganisasi);
            this.Controls.Add(this.labelNamaOrganisasi);
            this.Controls.Add(this.labelCariTeman);
            this.Name = "UC_CariTeman";
            this.Size = new System.Drawing.Size(1278, 678);
            this.Load += new System.EventHandler(this.UC_CariTeman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCariTeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCariTeman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.ComboBox comboBoxOrganisasi;
        private System.Windows.Forms.Label labelNamaOrganisasi;
        private System.Windows.Forms.Label labelCariTeman;
    }
}
