namespace PamerYukFormsApp.Prototype
{
    partial class FormDaftar
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelFormDaftar = new System.Windows.Forms.Label();
            this.textBoxKonfirmasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNoKTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.labelKota = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelFoto = new System.Windows.Forms.Panel();
            this.labelTangalLahir = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPassword.Location = new System.Drawing.Point(786, 220);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(800, 60);
            this.textBoxPassword.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(263, 223);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(267, 54);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password : ";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUsername.Location = new System.Drawing.Point(263, 153);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(277, 54);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username : ";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUsername.Location = new System.Drawing.Point(786, 150);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(800, 60);
            this.textBoxUsername.TabIndex = 9;
            // 
            // labelFormDaftar
            // 
            this.labelFormDaftar.AutoSize = true;
            this.labelFormDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormDaftar.Location = new System.Drawing.Point(786, 18);
            this.labelFormDaftar.Name = "labelFormDaftar";
            this.labelFormDaftar.Size = new System.Drawing.Size(349, 120);
            this.labelFormDaftar.TabIndex = 13;
            this.labelFormDaftar.Text = "Daftar";
            this.labelFormDaftar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxKonfirmasi
            // 
            this.textBoxKonfirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxKonfirmasi.Location = new System.Drawing.Point(786, 290);
            this.textBoxKonfirmasi.Name = "textBoxKonfirmasi";
            this.textBoxKonfirmasi.PasswordChar = '*';
            this.textBoxKonfirmasi.Size = new System.Drawing.Size(800, 60);
            this.textBoxKonfirmasi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(263, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 54);
            this.label1.TabIndex = 14;
            this.label1.Text = "Konfirmasi Password : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(263, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 54);
            this.label2.TabIndex = 16;
            this.label2.Text = "No KTP : ";
            // 
            // textBoxNoKTP
            // 
            this.textBoxNoKTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNoKTP.Location = new System.Drawing.Point(786, 360);
            this.textBoxNoKTP.Name = "textBoxNoKTP";
            this.textBoxNoKTP.PasswordChar = '*';
            this.textBoxNoKTP.Size = new System.Drawing.Size(800, 60);
            this.textBoxNoKTP.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(263, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 54);
            this.label3.TabIndex = 18;
            this.label3.Text = "Foto :";
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDaftar.Location = new System.Drawing.Point(1384, 898);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(202, 60);
            this.buttonDaftar.TabIndex = 19;
            this.buttonDaftar.Text = "Daftar";
            this.buttonDaftar.UseVisualStyleBackColor = true;
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelKota.Location = new System.Drawing.Point(263, 433);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(156, 54);
            this.labelKota.TabIndex = 20;
            this.labelKota.Text = "Kota : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(786, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(800, 60);
            this.textBox1.TabIndex = 21;
            // 
            // panelFoto
            // 
            this.panelFoto.Location = new System.Drawing.Point(786, 570);
            this.panelFoto.Name = "panelFoto";
            this.panelFoto.Size = new System.Drawing.Size(300, 300);
            this.panelFoto.TabIndex = 22;
            // 
            // labelTangalLahir
            // 
            this.labelTangalLahir.AutoSize = true;
            this.labelTangalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTangalLahir.Location = new System.Drawing.Point(263, 505);
            this.labelTangalLahir.Name = "labelTangalLahir";
            this.labelTangalLahir.Size = new System.Drawing.Size(345, 54);
            this.labelTangalLahir.TabIndex = 23;
            this.labelTangalLahir.Text = "Tanggal Lahir : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker1.Location = new System.Drawing.Point(786, 500);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(800, 60);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // FormDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTangalLahir);
            this.Controls.Add(this.panelFoto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.buttonDaftar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNoKTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKonfirmasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFormDaftar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "FormDaftar";
            this.Text = "Daftar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelFormDaftar;
        private System.Windows.Forms.TextBox textBoxKonfirmasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNoKTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelFoto;
        private System.Windows.Forms.Label labelTangalLahir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}