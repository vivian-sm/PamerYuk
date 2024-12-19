namespace PamerYukFormsApp.Prototype
{
    partial class FormRequestPertemanan
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
            this.labelFormCariTeman = new System.Windows.Forms.Label();
            this.groupBoxJenis = new System.Windows.Forms.GroupBox();
            this.radioButtonKirim = new System.Windows.Forms.RadioButton();
            this.radioButtonTerima = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).BeginInit();
            this.groupBoxJenis.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDaftarTeman
            // 
            this.dataGridViewDaftarTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarTeman.Location = new System.Drawing.Point(52, 318);
            this.dataGridViewDaftarTeman.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDaftarTeman.Name = "dataGridViewDaftarTeman";
            this.dataGridViewDaftarTeman.RowHeadersWidth = 82;
            this.dataGridViewDaftarTeman.RowTemplate.Height = 33;
            this.dataGridViewDaftarTeman.Size = new System.Drawing.Size(1794, 624);
            this.dataGridViewDaftarTeman.TabIndex = 70;
            this.dataGridViewDaftarTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarTeman_CellContentClick);
            // 
            // labelFormCariTeman
            // 
            this.labelFormCariTeman.AutoSize = true;
            this.labelFormCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormCariTeman.Location = new System.Drawing.Point(386, 48);
            this.labelFormCariTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormCariTeman.Name = "labelFormCariTeman";
            this.labelFormCariTeman.Size = new System.Drawing.Size(1083, 120);
            this.labelFormCariTeman.TabIndex = 66;
            this.labelFormCariTeman.Text = "Request Pertemanan";
            this.labelFormCariTeman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxJenis
            // 
            this.groupBoxJenis.Controls.Add(this.radioButtonTerima);
            this.groupBoxJenis.Controls.Add(this.radioButtonKirim);
            this.groupBoxJenis.Location = new System.Drawing.Point(52, 187);
            this.groupBoxJenis.Name = "groupBoxJenis";
            this.groupBoxJenis.Size = new System.Drawing.Size(1794, 109);
            this.groupBoxJenis.TabIndex = 71;
            this.groupBoxJenis.TabStop = false;
            this.groupBoxJenis.Text = "Jenis Request";
            // 
            // radioButtonKirim
            // 
            this.radioButtonKirim.AutoSize = true;
            this.radioButtonKirim.Location = new System.Drawing.Point(26, 48);
            this.radioButtonKirim.Name = "radioButtonKirim";
            this.radioButtonKirim.Size = new System.Drawing.Size(153, 36);
            this.radioButtonKirim.TabIndex = 0;
            this.radioButtonKirim.TabStop = true;
            this.radioButtonKirim.Text = "Terkirim";
            this.radioButtonKirim.UseVisualStyleBackColor = true;
            this.radioButtonKirim.CheckedChanged += new System.EventHandler(this.radioButtonKirim_CheckedChanged);
            // 
            // radioButtonTerima
            // 
            this.radioButtonTerima.AutoSize = true;
            this.radioButtonTerima.Location = new System.Drawing.Point(385, 48);
            this.radioButtonTerima.Name = "radioButtonTerima";
            this.radioButtonTerima.Size = new System.Drawing.Size(134, 36);
            this.radioButtonTerima.TabIndex = 1;
            this.radioButtonTerima.TabStop = true;
            this.radioButtonTerima.Text = "Masuk";
            this.radioButtonTerima.UseVisualStyleBackColor = true;
            this.radioButtonTerima.CheckedChanged += new System.EventHandler(this.radioButtonTerima_CheckedChanged);
            // 
            // FormRequestPertemanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.groupBoxJenis);
            this.Controls.Add(this.dataGridViewDaftarTeman);
            this.Controls.Add(this.labelFormCariTeman);
            this.Name = "FormRequestPertemanan";
            this.Text = "FormRequestPertemanan";
            this.Load += new System.EventHandler(this.FormRequestPertemanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).EndInit();
            this.groupBoxJenis.ResumeLayout(false);
            this.groupBoxJenis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaftarTeman;
        private System.Windows.Forms.Label labelFormCariTeman;
        private System.Windows.Forms.GroupBox groupBoxJenis;
        private System.Windows.Forms.RadioButton radioButtonTerima;
        private System.Windows.Forms.RadioButton radioButtonKirim;
    }
}