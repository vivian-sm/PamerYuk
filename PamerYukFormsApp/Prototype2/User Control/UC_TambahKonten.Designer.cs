namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_TambahKonten
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
            this.buttonTambahKonten = new System.Windows.Forms.Button();
            this.dataGridViewTeman = new System.Windows.Forms.DataGridView();
            this.labelTag = new System.Windows.Forms.Label();
            this.buttonUploadImage = new System.Windows.Forms.Label();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.pictureBoxKonten = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTambahKonten.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTambahKonten.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonTambahKonten.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTambahKonten.Location = new System.Drawing.Point(603, 515);
            this.buttonTambahKonten.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(583, 74);
            this.buttonTambahKonten.TabIndex = 87;
            this.buttonTambahKonten.Text = "Tambah Konten";
            this.buttonTambahKonten.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTeman
            // 
            this.dataGridViewTeman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeman.Location = new System.Drawing.Point(603, 312);
            this.dataGridViewTeman.Name = "dataGridViewTeman";
            this.dataGridViewTeman.RowHeadersWidth = 62;
            this.dataGridViewTeman.RowTemplate.Height = 28;
            this.dataGridViewTeman.Size = new System.Drawing.Size(583, 184);
            this.dataGridViewTeman.TabIndex = 86;
            // 
            // labelTag
            // 
            this.labelTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(598, 267);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(56, 29);
            this.labelTag.TabIndex = 85;
            this.labelTag.Text = "Tag";
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUploadImage.AutoSize = true;
            this.buttonUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadImage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonUploadImage.Location = new System.Drawing.Point(183, 539);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(232, 29);
            this.buttonUploadImage.TabIndex = 84;
            this.buttonUploadImage.Text = "UPLOAD KONTEN";
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCaption.Location = new System.Drawing.Point(603, 89);
            this.textBoxCaption.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCaption.Multiline = true;
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(583, 165);
            this.textBoxCaption.TabIndex = 83;
            this.textBoxCaption.Text = "Caption";
            this.textBoxCaption.TextChanged += new System.EventHandler(this.textBoxCaption_Click);
            // 
            // pictureBoxKonten
            // 
            this.pictureBoxKonten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxKonten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKonten.Image = global::PamerYukFormsApp.Properties.Resources.Tambahkonten_false;
            this.pictureBoxKonten.Location = new System.Drawing.Point(93, 89);
            this.pictureBoxKonten.Name = "pictureBoxKonten";
            this.pictureBoxKonten.Size = new System.Drawing.Size(407, 407);
            this.pictureBoxKonten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxKonten.TabIndex = 82;
            this.pictureBoxKonten.TabStop = false;
            // 
            // UC_TambahKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.buttonTambahKonten);
            this.Controls.Add(this.dataGridViewTeman);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.textBoxCaption);
            this.Controls.Add(this.pictureBoxKonten);
            this.Name = "UC_TambahKonten";
            this.Size = new System.Drawing.Size(1278, 678);
            this.Load += new System.EventHandler(this.UC_TambahKonten_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTambahKonten;
        private System.Windows.Forms.DataGridView dataGridViewTeman;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label buttonUploadImage;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.PictureBox pictureBoxKonten;
    }
}
