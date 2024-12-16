namespace PamerYukFormsApp.Prototype
{
    partial class FormDaftarTeman
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDaftarTeman
            // 
            this.dataGridViewDaftarTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarTeman.Location = new System.Drawing.Point(52, 211);
            this.dataGridViewDaftarTeman.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDaftarTeman.Name = "dataGridViewDaftarTeman";
            this.dataGridViewDaftarTeman.RowHeadersWidth = 82;
            this.dataGridViewDaftarTeman.RowTemplate.Height = 33;
            this.dataGridViewDaftarTeman.Size = new System.Drawing.Size(1794, 731);
            this.dataGridViewDaftarTeman.TabIndex = 70;
            this.dataGridViewDaftarTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarTeman_CellContentClick);
            // 
            // labelFormCariTeman
            // 
            this.labelFormCariTeman.AutoSize = true;
            this.labelFormCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormCariTeman.Location = new System.Drawing.Point(594, 50);
            this.labelFormCariTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormCariTeman.Name = "labelFormCariTeman";
            this.labelFormCariTeman.Size = new System.Drawing.Size(717, 120);
            this.labelFormCariTeman.TabIndex = 66;
            this.labelFormCariTeman.Text = "Daftar Teman";
            this.labelFormCariTeman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDaftarTeman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.dataGridViewDaftarTeman);
            this.Controls.Add(this.labelFormCariTeman);
            this.Name = "FormDaftarTeman";
            this.Text = "FormDaftarTeman";
            this.Load += new System.EventHandler(this.FormDaftarTeman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDaftarTeman;
        private System.Windows.Forms.Label labelFormCariTeman;
    }
}