namespace VTYS
{
    partial class Kurs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKursAdi = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxSuresi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.comboBoxV = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(80, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kurs Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(80, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eğitim Veren Personel";
            // 
            // textBoxKursAdi
            // 
            this.textBoxKursAdi.Location = new System.Drawing.Point(196, 68);
            this.textBoxKursAdi.Name = "textBoxKursAdi";
            this.textBoxKursAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxKursAdi.TabIndex = 6;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonEkle.Location = new System.Drawing.Point(425, 172);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(103, 64);
            this.buttonEkle.TabIndex = 19;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxSuresi
            // 
            this.textBoxSuresi.Location = new System.Drawing.Point(196, 169);
            this.textBoxSuresi.Name = "textBoxSuresi";
            this.textBoxSuresi.Size = new System.Drawing.Size(200, 20);
            this.textBoxSuresi.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(80, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kurs Süresi";
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(196, 223);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(200, 154);
            this.checkedListBox.TabIndex = 22;
            // 
            // comboBoxV
            // 
            this.comboBoxV.FormattingEnabled = true;
            this.comboBoxV.Location = new System.Drawing.Point(196, 117);
            this.comboBoxV.Name = "comboBoxV";
            this.comboBoxV.Size = new System.Drawing.Size(200, 21);
            this.comboBoxV.TabIndex = 23;
            this.comboBoxV.SelectedIndexChanged += new System.EventHandler(this.comboBoxV_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(196, 414);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 24;
            // 
            // Kurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 488);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxV);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSuresi);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxKursAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kurs";
            this.Text = "Kurs Ekle";
            this.Load += new System.EventHandler(this.Kurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKursAdi;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxSuresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ComboBox comboBoxV;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}