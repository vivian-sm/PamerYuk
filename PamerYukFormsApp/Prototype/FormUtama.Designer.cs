namespace PamerYukFormsApp
{
    partial class FormUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cariTemanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percakapanSayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontenSayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariTemanToolStripMenuItem,
            this.percakapanSayaToolStripMenuItem,
            this.kontenSayaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1416, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cariTemanToolStripMenuItem
            // 
            this.cariTemanToolStripMenuItem.Name = "cariTemanToolStripMenuItem";
            this.cariTemanToolStripMenuItem.Size = new System.Drawing.Size(153, 38);
            this.cariTemanToolStripMenuItem.Text = "Cari Teman";
            // 
            // percakapanSayaToolStripMenuItem
            // 
            this.percakapanSayaToolStripMenuItem.Name = "percakapanSayaToolStripMenuItem";
            this.percakapanSayaToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.percakapanSayaToolStripMenuItem.Text = "Percakapan Saya";
            // 
            // kontenSayaToolStripMenuItem
            // 
            this.kontenSayaToolStripMenuItem.Name = "kontenSayaToolStripMenuItem";
            this.kontenSayaToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.kontenSayaToolStripMenuItem.Text = "Konten Saya";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 800);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUtama";
            this.Text = "FormUtama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cariTemanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percakapanSayaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontenSayaToolStripMenuItem;
    }
}

