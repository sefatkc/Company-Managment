namespace VTYS
{
    partial class UzmanlıkEkle
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
            this.textBoxUzmanlikAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUzmanlikAdi
            // 
            this.textBoxUzmanlikAdi.Location = new System.Drawing.Point(212, 106);
            this.textBoxUzmanlikAdi.Name = "textBoxUzmanlikAdi";
            this.textBoxUzmanlikAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxUzmanlikAdi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(114, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Uznanlık Adı";
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonEkle.Location = new System.Drawing.Point(212, 160);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(103, 64);
            this.buttonEkle.TabIndex = 19;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // UzmanlıkEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(543, 276);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUzmanlikAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UzmanlıkEkle";
            this.Text = "Uzmanlık Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUzmanlikAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEkle;
    }
}