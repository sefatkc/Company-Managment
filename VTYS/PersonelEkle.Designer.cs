namespace VTYS
{
    partial class PersonelEkle
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
            if (disposing || (components != null))
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerBaslama = new System.Windows.Forms.DateTimePicker();
            this.textBoxTCno = new System.Windows.Forms.TextBox();
            this.textBoxPad = new System.Windows.Forms.TextBox();
            this.textBoxPsoyad = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.comboBoxUzmanlik = new System.Windows.Forms.ComboBox();
            this.comboBoxGorev = new System.Windows.Forms.ComboBox();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxUzmanadi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxYetki = new System.Windows.Forms.ComboBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(74, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. Kimlik Numarısı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(74, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(74, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Başlama Tarihi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(74, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maaş";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(74, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Eğitim Seviyesi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(74, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bölüm";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(74, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Görev";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateTimePickerBaslama
            // 
            this.dateTimePickerBaslama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBaslama.Location = new System.Drawing.Point(181, 122);
            this.dateTimePickerBaslama.Name = "dateTimePickerBaslama";
            this.dateTimePickerBaslama.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBaslama.TabIndex = 9;
            this.dateTimePickerBaslama.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxTCno
            // 
            this.textBoxTCno.Location = new System.Drawing.Point(181, 43);
            this.textBoxTCno.MaxLength = 11;
            this.textBoxTCno.Name = "textBoxTCno";
            this.textBoxTCno.Size = new System.Drawing.Size(200, 20);
            this.textBoxTCno.TabIndex = 10;
            this.textBoxTCno.TextChanged += new System.EventHandler(this.textBoxTCno_TextChanged);
            // 
            // textBoxPad
            // 
            this.textBoxPad.Location = new System.Drawing.Point(181, 69);
            this.textBoxPad.Name = "textBoxPad";
            this.textBoxPad.Size = new System.Drawing.Size(200, 20);
            this.textBoxPad.TabIndex = 11;
            this.textBoxPad.TextChanged += new System.EventHandler(this.textBoxPad_TextChanged);
            // 
            // textBoxPsoyad
            // 
            this.textBoxPsoyad.Location = new System.Drawing.Point(181, 93);
            this.textBoxPsoyad.Name = "textBoxPsoyad";
            this.textBoxPsoyad.Size = new System.Drawing.Size(200, 20);
            this.textBoxPsoyad.TabIndex = 12;
            this.textBoxPsoyad.TextChanged += new System.EventHandler(this.textBoxPsoyad_TextChanged);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(181, 153);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(200, 20);
            this.textBoxSalary.TabIndex = 13;
            this.textBoxSalary.TextChanged += new System.EventHandler(this.textBoxSalary_TextChanged);
            // 
            // comboBoxUzmanlik
            // 
            this.comboBoxUzmanlik.FormattingEnabled = true;
            this.comboBoxUzmanlik.Location = new System.Drawing.Point(181, 179);
            this.comboBoxUzmanlik.Name = "comboBoxUzmanlik";
            this.comboBoxUzmanlik.Size = new System.Drawing.Size(200, 21);
            this.comboBoxUzmanlik.TabIndex = 15;
            this.comboBoxUzmanlik.SelectedIndexChanged += new System.EventHandler(this.comboBoxUzmanlik_SelectedIndexChanged);
            // 
            // comboBoxGorev
            // 
            this.comboBoxGorev.FormattingEnabled = true;
            this.comboBoxGorev.Location = new System.Drawing.Point(181, 204);
            this.comboBoxGorev.Name = "comboBoxGorev";
            this.comboBoxGorev.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGorev.TabIndex = 16;
            this.comboBoxGorev.SelectedIndexChanged += new System.EventHandler(this.comboBoxGorev_SelectedIndexChanged);
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Location = new System.Drawing.Point(181, 229);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(200, 21);
            this.comboBoxBolum.TabIndex = 17;
            this.comboBoxBolum.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonEkle.Location = new System.Drawing.Point(429, 156);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(103, 64);
            this.buttonEkle.TabIndex = 18;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxUzmanadi
            // 
            this.textBoxUzmanadi.Location = new System.Drawing.Point(181, 395);
            this.textBoxUzmanadi.MaxLength = 200;
            this.textBoxUzmanadi.Name = "textBoxUzmanadi";
            this.textBoxUzmanadi.Size = new System.Drawing.Size(200, 20);
            this.textBoxUzmanadi.TabIndex = 49;
            this.textBoxUzmanadi.TextChanged += new System.EventHandler(this.textBoxUzmanadi_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(108, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Uzmanlık Adı";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(181, 269);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 109);
            this.checkedListBox1.TabIndex = 47;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(126, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Uzmanlık";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(108, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Şifre";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBoxYetki
            // 
            this.comboBoxYetki.FormattingEnabled = true;
            this.comboBoxYetki.Items.AddRange(new object[] {
            "Müdür",
            "Proje Yöneticisi",
            "Personel"});
            this.comboBoxYetki.Location = new System.Drawing.Point(287, 429);
            this.comboBoxYetki.Name = "comboBoxYetki";
            this.comboBoxYetki.Size = new System.Drawing.Size(94, 21);
            this.comboBoxYetki.TabIndex = 51;
            this.comboBoxYetki.SelectedIndexChanged += new System.EventHandler(this.comboBoxYetki_SelectedIndexChanged);
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(181, 430);
            this.textBoxPwd.MaxLength = 10;
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(100, 20);
            this.textBoxPwd.TabIndex = 52;
            this.textBoxPwd.TextChanged += new System.EventHandler(this.textBoxPwd_TextChanged);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 488);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.comboBoxYetki);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUzmanadi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.comboBoxBolum);
            this.Controls.Add(this.comboBoxGorev);
            this.Controls.Add(this.comboBoxUzmanlik);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxPsoyad);
            this.Controls.Add(this.textBoxPad);
            this.Controls.Add(this.textBoxTCno);
            this.Controls.Add(this.dateTimePickerBaslama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelEkle";
            this.Text = "Personel Ekle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslama;
        private System.Windows.Forms.TextBox textBoxTCno;
        private System.Windows.Forms.TextBox textBoxPad;
        private System.Windows.Forms.TextBox textBoxPsoyad;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ComboBox comboBoxUzmanlik;
        private System.Windows.Forms.ComboBox comboBoxGorev;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxUzmanadi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxYetki;
        private System.Windows.Forms.TextBox textBoxPwd;
    }
}