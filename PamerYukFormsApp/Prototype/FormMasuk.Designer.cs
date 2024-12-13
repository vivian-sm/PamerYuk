namespace PamerYukFormsApp.Prototype
{
    partial class FormMasuk
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonMasuk = new System.Windows.Forms.Button();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFormMasuk = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUsername.Location = new System.Drawing.Point(560, 400);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(800, 60);
            this.textBoxUsername.TabIndex = 0;
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMasuk.Location = new System.Drawing.Point(1543, 859);
            this.buttonMasuk.Name = "buttonMasuk";
            this.buttonMasuk.Size = new System.Drawing.Size(268, 78);
            this.buttonMasuk.TabIndex = 2;
            this.buttonMasuk.Text = "Log In";
            this.buttonMasuk.UseVisualStyleBackColor = true;
            this.buttonMasuk.Click += new System.EventHandler(this.buttonMasuk_Click);
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDaftar.Location = new System.Drawing.Point(62, 859);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(268, 78);
            this.buttonDaftar.TabIndex = 3;
            this.buttonDaftar.Text = "Daftar";
            this.buttonDaftar.UseVisualStyleBackColor = true;
            this.buttonDaftar.Click += new System.EventHandler(this.buttonDaftar_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(551, 343);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(277, 54);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username : ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(551, 503);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(267, 54);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(56, 812);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Belum memiliki akun?";
            // 
            // labelFormMasuk
            // 
            this.labelFormMasuk.AutoSize = true;
            this.labelFormMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormMasuk.Location = new System.Drawing.Point(783, 100);
            this.labelFormMasuk.Name = "labelFormMasuk";
            this.labelFormMasuk.Size = new System.Drawing.Size(354, 120);
            this.labelFormMasuk.TabIndex = 7;
            this.labelFormMasuk.Text = "Log In";
            this.labelFormMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPassword.Location = new System.Drawing.Point(560, 560);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(800, 60);
            this.textBoxPassword.TabIndex = 8;
            // 
            // FormMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelFormMasuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonDaftar);
            this.Controls.Add(this.buttonMasuk);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "FormMasuk";
            this.Text = "Log In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMasuk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonMasuk;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFormMasuk;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}