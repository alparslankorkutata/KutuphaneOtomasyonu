namespace kutuphaneotomasyonu
{
    partial class FrmPersonelGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtParola = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola :";
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(150, 112);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Size = new System.Drawing.Size(100, 20);
            this.TxtParola.TabIndex = 3;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(150, 71);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtKullaniciAdi.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(134, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Beni Hatırla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.check_icon__1_;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(175, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(61, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personel Girişi";
            // 
            // FrmPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(331, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FrmPersonelGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtParola;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}