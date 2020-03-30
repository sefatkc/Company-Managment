namespace VTYS
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing || (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGorevSil = new System.Windows.Forms.Button();
            this.buttonGorevEkle = new System.Windows.Forms.Button();
            this.buttonKursEkle = new System.Windows.Forms.Button();
            this.buttonKursGuncelle = new System.Windows.Forms.Button();
            this.buttonPersonelGuncelle = new System.Windows.Forms.Button();
            this.buttonProjeEkle = new System.Windows.Forms.Button();
            this.buttonProjeGuncelle = new System.Windows.Forms.Button();
            this.buttonPersonelEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSec = new System.Windows.Forms.ComboBox();
            this.comboBoxKurs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBoxProje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.ppdDiyalog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonGorevSil);
            this.groupBox1.Controls.Add(this.buttonGorevEkle);
            this.groupBox1.Controls.Add(this.buttonKursEkle);
            this.groupBox1.Controls.Add(this.buttonKursGuncelle);
            this.groupBox1.Controls.Add(this.buttonPersonelGuncelle);
            this.groupBox1.Controls.Add(this.buttonProjeEkle);
            this.groupBox1.Controls.Add(this.buttonProjeGuncelle);
            this.groupBox1.Controls.Add(this.buttonPersonelEkle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 672);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Image = global::VTYS.Properties.Resources.icons8_print_filled_60;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 63);
            this.button1.TabIndex = 21;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGorevSil
            // 
            this.buttonGorevSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.buttonGorevSil.FlatAppearance.BorderSize = 0;
            this.buttonGorevSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGorevSil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonGorevSil.Image = global::VTYS.Properties.Resources.icons8_submit_resume_60;
            this.buttonGorevSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGorevSil.Location = new System.Drawing.Point(0, 528);
            this.buttonGorevSil.Name = "buttonGorevSil";
            this.buttonGorevSil.Size = new System.Drawing.Size(228, 64);
            this.buttonGorevSil.TabIndex = 21;
            this.buttonGorevSil.Text = "     Görev Güncelle/Sil";
            this.buttonGorevSil.UseVisualStyleBackColor = false;
            this.buttonGorevSil.Click += new System.EventHandler(this.buttonGorevSil_Click);
            // 
            // buttonGorevEkle
            // 
            this.buttonGorevEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.buttonGorevEkle.FlatAppearance.BorderSize = 0;
            this.buttonGorevEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGorevEkle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonGorevEkle.Image = global::VTYS.Properties.Resources.icons8_resume_601;
            this.buttonGorevEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGorevEkle.Location = new System.Drawing.Point(0, 458);
            this.buttonGorevEkle.Name = "buttonGorevEkle";
            this.buttonGorevEkle.Size = new System.Drawing.Size(228, 64);
            this.buttonGorevEkle.TabIndex = 20;
            this.buttonGorevEkle.Text = "Görev Ekle";
            this.buttonGorevEkle.UseVisualStyleBackColor = false;
            this.buttonGorevEkle.Click += new System.EventHandler(this.buttonGorevEkle_Click_1);
            // 
            // buttonKursEkle
            // 
            this.buttonKursEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.buttonKursEkle.FlatAppearance.BorderSize = 0;
            this.buttonKursEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKursEkle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKursEkle.Image = global::VTYS.Properties.Resources.icons8_student_registration_filled_50;
            this.buttonKursEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKursEkle.Location = new System.Drawing.Point(0, 318);
            this.buttonKursEkle.Name = "buttonKursEkle";
            this.buttonKursEkle.Size = new System.Drawing.Size(228, 64);
            this.buttonKursEkle.TabIndex = 17;
            this.buttonKursEkle.Text = "Kurs Ekle";
            this.buttonKursEkle.UseVisualStyleBackColor = false;
            this.buttonKursEkle.Click += new System.EventHandler(this.buttonKursEkle_Click_1);
            // 
            // buttonKursGuncelle
            // 
            this.buttonKursGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.buttonKursGuncelle.FlatAppearance.BorderSize = 0;
            this.buttonKursGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKursGuncelle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonKursGuncelle.Image = global::VTYS.Properties.Resources.icons8_update_filled_50;
            this.buttonKursGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKursGuncelle.Location = new System.Drawing.Point(0, 388);
            this.buttonKursGuncelle.Name = "buttonKursGuncelle";
            this.buttonKursGuncelle.Size = new System.Drawing.Size(228, 64);
            this.buttonKursGuncelle.TabIndex = 16;
            this.buttonKursGuncelle.Text = "Kurs Güncelle/Sil";
            this.buttonKursGuncelle.UseVisualStyleBackColor = false;
            this.buttonKursGuncelle.Click += new System.EventHandler(this.buttonKursGuncelle_Click);
            // 
            // buttonPersonelGuncelle
            // 
            this.buttonPersonelGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.buttonPersonelGuncelle.FlatAppearance.BorderSize = 0;
            this.buttonPersonelGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonelGuncelle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonPersonelGuncelle.Image = global::VTYS.Properties.Resources.icons8_change_user_filled_50;
            this.buttonPersonelGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonelGuncelle.Location = new System.Drawing.Point(0, 108);
            this.buttonPersonelGuncelle.Name = "buttonPersonelGuncelle";
            this.buttonPersonelGuncelle.Size = new System.Drawing.Size(228, 64);
            this.buttonPersonelGuncelle.TabIndex = 15;
            this.buttonPersonelGuncelle.Text = "Personel Güncelle/Sil";
            this.buttonPersonelGuncelle.UseVisualStyleBackColor = false;
            this.buttonPersonelGuncelle.Click += new System.EventHandler(this.buttonPersonelGuncelle_Click_1);
            // 
            // buttonProjeEkle
            // 
            this.buttonProjeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.buttonProjeEkle.FlatAppearance.BorderSize = 0;
            this.buttonProjeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjeEkle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonProjeEkle.Image = global::VTYS.Properties.Resources.icons8_project_filled_50;
            this.buttonProjeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjeEkle.Location = new System.Drawing.Point(0, 178);
            this.buttonProjeEkle.Name = "buttonProjeEkle";
            this.buttonProjeEkle.Size = new System.Drawing.Size(228, 64);
            this.buttonProjeEkle.TabIndex = 14;
            this.buttonProjeEkle.Text = "Proje Ekle";
            this.buttonProjeEkle.UseVisualStyleBackColor = false;
            this.buttonProjeEkle.Click += new System.EventHandler(this.buttonProjeEkle_Click_1);
            // 
            // buttonProjeGuncelle
            // 
            this.buttonProjeGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.buttonProjeGuncelle.FlatAppearance.BorderSize = 0;
            this.buttonProjeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjeGuncelle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonProjeGuncelle.Image = global::VTYS.Properties.Resources.icons8_synchronize_60;
            this.buttonProjeGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjeGuncelle.Location = new System.Drawing.Point(0, 248);
            this.buttonProjeGuncelle.Name = "buttonProjeGuncelle";
            this.buttonProjeGuncelle.Size = new System.Drawing.Size(228, 64);
            this.buttonProjeGuncelle.TabIndex = 13;
            this.buttonProjeGuncelle.Text = "Proje Güncelle/Sil";
            this.buttonProjeGuncelle.UseVisualStyleBackColor = false;
            this.buttonProjeGuncelle.Click += new System.EventHandler(this.buttonProjeGuncelle_Click);
            // 
            // buttonPersonelEkle
            // 
            this.buttonPersonelEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(149)))), ((int)(((byte)(49)))));
            this.buttonPersonelEkle.FlatAppearance.BorderSize = 0;
            this.buttonPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonelEkle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonPersonelEkle.Image = global::VTYS.Properties.Resources.icons8_add_user_male_filled_60;
            this.buttonPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonelEkle.Location = new System.Drawing.Point(0, 38);
            this.buttonPersonelEkle.Name = "buttonPersonelEkle";
            this.buttonPersonelEkle.Size = new System.Drawing.Size(228, 64);
            this.buttonPersonelEkle.TabIndex = 12;
            this.buttonPersonelEkle.Text = "Personel Ekle";
            this.buttonPersonelEkle.UseVisualStyleBackColor = false;
            this.buttonPersonelEkle.Click += new System.EventHandler(this.buttonPersonelEkle_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxSec);
            this.groupBox2.Controls.Add(this.comboBoxKurs);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.comboBoxProje);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox2.Location = new System.Drawing.Point(827, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 672);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Seçilen:";
            // 
            // comboBoxSec
            // 
            this.comboBoxSec.FormattingEnabled = true;
            this.comboBoxSec.Items.AddRange(new object[] {
            "Personeller",
            "Projeler",
            "Kurslar"});
            this.comboBoxSec.Location = new System.Drawing.Point(79, 81);
            this.comboBoxSec.Name = "comboBoxSec";
            this.comboBoxSec.Size = new System.Drawing.Size(180, 21);
            this.comboBoxSec.TabIndex = 19;
            this.comboBoxSec.SelectedIndexChanged += new System.EventHandler(this.comboBoxSec_SelectedIndexChanged);
            // 
            // comboBoxKurs
            // 
            this.comboBoxKurs.FormattingEnabled = true;
            this.comboBoxKurs.Location = new System.Drawing.Point(79, 108);
            this.comboBoxKurs.Name = "comboBoxKurs";
            this.comboBoxKurs.Size = new System.Drawing.Size(180, 21);
            this.comboBoxKurs.TabIndex = 18;
            this.comboBoxKurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxKurs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kurs Adı:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Location = new System.Drawing.Point(9, 175);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 497);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBoxProje
            // 
            this.comboBoxProje.FormattingEnabled = true;
            this.comboBoxProje.Location = new System.Drawing.Point(79, 135);
            this.comboBoxProje.Name = "comboBoxProje";
            this.comboBoxProje.Size = new System.Drawing.Size(180, 21);
            this.comboBoxProje.TabIndex = 15;
            this.comboBoxProje.SelectedIndexChanged += new System.EventHandler(this.comboBoxProje_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Proje Adı:";
            // 
            // pdYazici
            // 
            this.pdYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdYazici_PrintPage);
            // 
            // ppdDiyalog
            // 
            this.ppdDiyalog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdDiyalog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdDiyalog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdDiyalog.Document = this.pdYazici;
            this.ppdDiyalog.Enabled = true;
            this.ppdDiyalog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdDiyalog.Icon")));
            this.ppdDiyalog.Name = "ppdDiyalog";
            this.ppdDiyalog.Text = "Baskı önizleme";
            this.ppdDiyalog.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 32);
            this.panel1.TabIndex = 16;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VTYS.Properties.Resources._24914509;
            this.pictureBox5.Location = new System.Drawing.Point(3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(38, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tars Şirket Yönetim Sistemi";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VTYS.Properties.Resources.icons8_minimize_window_filled_50;
            this.pictureBox3.Location = new System.Drawing.Point(1259, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VTYS.Properties.Resources.icons8_delete_filled_50;
            this.pictureBox2.Location = new System.Drawing.Point(1294, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(244, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 488);
            this.panel3.TabIndex = 25;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VTYS.Properties.Resources._24914509;
            this.pictureBox1.Location = new System.Drawing.Point(244, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1327, 672);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGorevSil;
        private System.Windows.Forms.Button buttonGorevEkle;
        private System.Windows.Forms.Button buttonKursEkle;
        private System.Windows.Forms.Button buttonKursGuncelle;
        private System.Windows.Forms.Button buttonPersonelGuncelle;
        private System.Windows.Forms.Button buttonProjeEkle;
        private System.Windows.Forms.Button buttonProjeGuncelle;
        private System.Windows.Forms.Button buttonPersonelEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBoxProje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private System.Windows.Forms.PrintPreviewDialog ppdDiyalog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSec;
    }
}

