namespace VTYS
{
    partial class ProjeGuncelle
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
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.dateTimePickerKursBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProjeAdi = new System.Windows.Forms.TextBox();
            this.dateTimePickerKursBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.comboBoxProje = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGüncelle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonGüncelle.Location = new System.Drawing.Point(210, 290);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(103, 64);
            this.buttonGüncelle.TabIndex = 26;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // dateTimePickerKursBitis
            // 
            this.dateTimePickerKursBitis.Location = new System.Drawing.Point(227, 246);
            this.dateTimePickerKursBitis.Name = "dateTimePickerKursBitis";
            this.dateTimePickerKursBitis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKursBitis.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(121, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // textBoxProjeAdi
            // 
            this.textBoxProjeAdi.Location = new System.Drawing.Point(227, 140);
            this.textBoxProjeAdi.Name = "textBoxProjeAdi";
            this.textBoxProjeAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxProjeAdi.TabIndex = 23;
            // 
            // dateTimePickerKursBaslangic
            // 
            this.dateTimePickerKursBaslangic.Location = new System.Drawing.Point(227, 196);
            this.dateTimePickerKursBaslangic.Name = "dateTimePickerKursBaslangic";
            this.dateTimePickerKursBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKursBaslangic.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(121, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(121, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Proje Adı";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonSil.Location = new System.Drawing.Point(337, 290);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(103, 64);
            this.buttonSil.TabIndex = 27;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // comboBoxProje
            // 
            this.comboBoxProje.FormattingEnabled = true;
            this.comboBoxProje.Location = new System.Drawing.Point(227, 90);
            this.comboBoxProje.Name = "comboBoxProje";
            this.comboBoxProje.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProje.TabIndex = 40;
            this.comboBoxProje.SelectedIndexChanged += new System.EventHandler(this.comboBoxProje_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(121, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Proje ";
            // 
            // ProjeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProje);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.dateTimePickerKursBitis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProjeAdi);
            this.Controls.Add(this.dateTimePickerKursBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjeGuncelle";
            this.Text = "Proje Guncelle";
            this.Load += new System.EventHandler(this.ProjeGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.DateTimePicker dateTimePickerKursBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProjeAdi;
        private System.Windows.Forms.DateTimePicker dateTimePickerKursBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.ComboBox comboBoxProje;
        private System.Windows.Forms.Label label4;
    }
}