namespace VTYS
{
    partial class ProjeEkle
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
            this.dateTimePickerKursBaslangic = new System.Windows.Forms.DateTimePicker();
            this.textBoxProjeAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerKursBitis = new System.Windows.Forms.DateTimePicker();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.checkedListBoxPersoneller = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPrjSrm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proje Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(103, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // dateTimePickerKursBaslangic
            // 
            this.dateTimePickerKursBaslangic.Location = new System.Drawing.Point(209, 293);
            this.dateTimePickerKursBaslangic.Name = "dateTimePickerKursBaslangic";
            this.dateTimePickerKursBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKursBaslangic.TabIndex = 4;
            // 
            // textBoxProjeAdi
            // 
            this.textBoxProjeAdi.Location = new System.Drawing.Point(209, 38);
            this.textBoxProjeAdi.Name = "textBoxProjeAdi";
            this.textBoxProjeAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxProjeAdi.TabIndex = 5;
            this.textBoxProjeAdi.TextChanged += new System.EventHandler(this.textBoxProjeAdi_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(103, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // dateTimePickerKursBitis
            // 
            this.dateTimePickerKursBitis.Location = new System.Drawing.Point(209, 341);
            this.dateTimePickerKursBitis.Name = "dateTimePickerKursBitis";
            this.dateTimePickerKursBitis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKursBitis.TabIndex = 7;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonEkle.Location = new System.Drawing.Point(252, 382);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(103, 64);
            this.buttonEkle.TabIndex = 19;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // checkedListBoxPersoneller
            // 
            this.checkedListBoxPersoneller.FormattingEnabled = true;
            this.checkedListBoxPersoneller.Location = new System.Drawing.Point(209, 131);
            this.checkedListBoxPersoneller.Name = "checkedListBoxPersoneller";
            this.checkedListBoxPersoneller.Size = new System.Drawing.Size(200, 139);
            this.checkedListBoxPersoneller.TabIndex = 20;
            this.checkedListBoxPersoneller.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPersoneller_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(103, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Personeller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(103, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Proje Sorumlusu";
            // 
            // comboBoxPrjSrm
            // 
            this.comboBoxPrjSrm.FormattingEnabled = true;
            this.comboBoxPrjSrm.Location = new System.Drawing.Point(209, 81);
            this.comboBoxPrjSrm.Name = "comboBoxPrjSrm";
            this.comboBoxPrjSrm.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPrjSrm.TabIndex = 23;
            this.comboBoxPrjSrm.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrjSrm_SelectedIndexChanged);
            // 
            // ProjeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 488);
            this.Controls.Add(this.comboBoxPrjSrm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBoxPersoneller);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dateTimePickerKursBitis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProjeAdi);
            this.Controls.Add(this.dateTimePickerKursBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(244, 192);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Proje Ekle";
            this.Load += new System.EventHandler(this.ProjeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerKursBaslangic;
        private System.Windows.Forms.TextBox textBoxProjeAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerKursBitis;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.CheckedListBox checkedListBoxPersoneller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPrjSrm;
    }
}