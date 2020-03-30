namespace VTYS
{
    partial class KursGuncelle
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxV = new System.Windows.Forms.ComboBox();
            this.checkedListPersoneller = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSuresi = new System.Windows.Forms.TextBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxKursAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKurs = new System.Windows.Forms.ComboBox();
            this.buttonKursSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(176, 432);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 33;
            // 
            // comboBoxV
            // 
            this.comboBoxV.FormattingEnabled = true;
            this.comboBoxV.Location = new System.Drawing.Point(176, 135);
            this.comboBoxV.Name = "comboBoxV";
            this.comboBoxV.Size = new System.Drawing.Size(200, 21);
            this.comboBoxV.TabIndex = 32;
            // 
            // checkedListPersoneller
            // 
            this.checkedListPersoneller.FormattingEnabled = true;
            this.checkedListPersoneller.Location = new System.Drawing.Point(176, 241);
            this.checkedListPersoneller.Name = "checkedListPersoneller";
            this.checkedListPersoneller.Size = new System.Drawing.Size(200, 154);
            this.checkedListPersoneller.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(60, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kurs Süresi";
            // 
            // textBoxSuresi
            // 
            this.textBoxSuresi.Location = new System.Drawing.Point(176, 187);
            this.textBoxSuresi.Name = "textBoxSuresi";
            this.textBoxSuresi.Size = new System.Drawing.Size(200, 20);
            this.textBoxSuresi.TabIndex = 29;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonGuncelle.Location = new System.Drawing.Point(420, 162);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(103, 64);
            this.buttonGuncelle.TabIndex = 28;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // textBoxKursAdi
            // 
            this.textBoxKursAdi.Location = new System.Drawing.Point(176, 86);
            this.textBoxKursAdi.Name = "textBoxKursAdi";
            this.textBoxKursAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxKursAdi.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(60, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Eğitim Veren Personel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kurs Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(60, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Kurs";
            // 
            // comboBoxKurs
            // 
            this.comboBoxKurs.FormattingEnabled = true;
            this.comboBoxKurs.Location = new System.Drawing.Point(176, 42);
            this.comboBoxKurs.Name = "comboBoxKurs";
            this.comboBoxKurs.Size = new System.Drawing.Size(200, 21);
            this.comboBoxKurs.TabIndex = 35;
            this.comboBoxKurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxKurs_SelectedIndexChanged);
            // 
            // buttonKursSil
            // 
            this.buttonKursSil.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonKursSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKursSil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKursSil.Location = new System.Drawing.Point(420, 241);
            this.buttonKursSil.Name = "buttonKursSil";
            this.buttonKursSil.Size = new System.Drawing.Size(103, 64);
            this.buttonKursSil.TabIndex = 36;
            this.buttonKursSil.Text = "Sil";
            this.buttonKursSil.UseVisualStyleBackColor = false;
            // 
            // KursGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 488);
            this.Controls.Add(this.buttonKursSil);
            this.Controls.Add(this.comboBoxKurs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxV);
            this.Controls.Add(this.checkedListPersoneller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSuresi);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.textBoxKursAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KursGuncelle";
            this.Text = "KursGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxV;
        private System.Windows.Forms.CheckedListBox checkedListPersoneller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSuresi;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxKursAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKurs;
        private System.Windows.Forms.Button buttonKursSil;
    }
}