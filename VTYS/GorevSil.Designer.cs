namespace VTYS
{
    partial class GorevSil
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
            this.buttonSil = new System.Windows.Forms.Button();
            this.textBoxGorevAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGorev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonSil.Location = new System.Drawing.Point(311, 238);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(103, 64);
            this.buttonSil.TabIndex = 22;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textBoxGorevAdi
            // 
            this.textBoxGorevAdi.Location = new System.Drawing.Point(214, 172);
            this.textBoxGorevAdi.Name = "textBoxGorevAdi";
            this.textBoxGorevAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxGorevAdi.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(119, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Görev Adı";
            // 
            // comboBoxGorev
            // 
            this.comboBoxGorev.FormattingEnabled = true;
            this.comboBoxGorev.Location = new System.Drawing.Point(214, 111);
            this.comboBoxGorev.Name = "comboBoxGorev";
            this.comboBoxGorev.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGorev.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(119, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Görev";
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGüncelle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonGüncelle.Location = new System.Drawing.Point(186, 238);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(103, 64);
            this.buttonGüncelle.TabIndex = 25;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = false;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // GorevSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(579, 488);
            this.Controls.Add(this.buttonGüncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGorev);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.textBoxGorevAdi);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GorevSil";
            this.Text = "GorevSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.TextBox textBoxGorevAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGorev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGüncelle;
    }
}