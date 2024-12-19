namespace PamerYukFormsApp.Prototype
{
    partial class FormDaftarKonten
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
            this.dataGridViewDaftarKonten = new System.Windows.Forms.DataGridView();
            this.labelUsername = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglUpload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKonten)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDaftarKonten
            // 
            this.dataGridViewDaftarKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarKonten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Caption,
            this.tglUpload});
            this.dataGridViewDaftarKonten.Location = new System.Drawing.Point(53, 151);
            this.dataGridViewDaftarKonten.Name = "dataGridViewDaftarKonten";
            this.dataGridViewDaftarKonten.RowHeadersWidth = 102;
            this.dataGridViewDaftarKonten.RowTemplate.Height = 40;
            this.dataGridViewDaftarKonten.Size = new System.Drawing.Size(1792, 777);
            this.dataGridViewDaftarKonten.TabIndex = 0;
            this.dataGridViewDaftarKonten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarKonten_CellContentClick);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(53, 58);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(338, 54);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "labelUsername";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.Width = 250;
            // 
            // Caption
            // 
            this.Caption.HeaderText = "Caption";
            this.Caption.MinimumWidth = 12;
            this.Caption.Name = "Caption";
            this.Caption.Width = 250;
            // 
            // tglUpload
            // 
            this.tglUpload.HeaderText = "Tanggal Upload";
            this.tglUpload.MinimumWidth = 12;
            this.tglUpload.Name = "tglUpload";
            this.tglUpload.Width = 250;
            // 
            // FormDaftarKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dataGridViewDaftarKonten);
            this.Name = "FormDaftarKonten";
            this.Text = "FormDaftarKonten";
            this.Load += new System.EventHandler(this.FormDaftarKonten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarKonten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaftarKonten;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglUpload;
    }
}