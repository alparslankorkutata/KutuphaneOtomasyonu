namespace kutuphaneotomasyonu
{
    partial class FrmOduncVerme
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
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnOduncVer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtOVKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtPKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtBarkodNo = new System.Windows.Forms.TextBox();
            this.TxtEmanetBitimTarih = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtEmanetNot = new System.Windows.Forms.TextBox();
            this.TxtEmanetBaslangicTarih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEmanetIslemTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmanetNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSil.Location = new System.Drawing.Point(301, 211);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 44);
            this.BtnSil.TabIndex = 32;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnOduncVer
            // 
            this.BtnOduncVer.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnOduncVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOduncVer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnOduncVer.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOduncVer.Location = new System.Drawing.Point(301, 112);
            this.BtnOduncVer.Name = "BtnOduncVer";
            this.BtnOduncVer.Size = new System.Drawing.Size(75, 53);
            this.BtnOduncVer.TabIndex = 30;
            this.BtnOduncVer.Text = "ÖDÜNÇ VER";
            this.BtnOduncVer.UseVisualStyleBackColor = false;
            this.BtnOduncVer.Click += new System.EventHandler(this.BtnOduncVer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 251);
            this.dataGridView1.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(633, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 53);
            this.button2.TabIndex = 38;
            this.button2.Text = "ÇIKIŞ YAP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(32, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ödünç Verilen Kullanıcı Adı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(80, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Üye Kullanıcı Adı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(51, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kitap Barkod Numarası :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(69, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Emanet Bitim Tarihi :";
            // 
            // TxtOVKullaniciAdi
            // 
            this.TxtOVKullaniciAdi.Location = new System.Drawing.Point(178, 101);
            this.TxtOVKullaniciAdi.Name = "TxtOVKullaniciAdi";
            this.TxtOVKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtOVKullaniciAdi.TabIndex = 24;
            // 
            // TxtPKullaniciAdi
            // 
            this.TxtPKullaniciAdi.Location = new System.Drawing.Point(178, 72);
            this.TxtPKullaniciAdi.Name = "TxtPKullaniciAdi";
            this.TxtPKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtPKullaniciAdi.TabIndex = 25;
            // 
            // TxtBarkodNo
            // 
            this.TxtBarkodNo.Location = new System.Drawing.Point(178, 129);
            this.TxtBarkodNo.Name = "TxtBarkodNo";
            this.TxtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.TxtBarkodNo.TabIndex = 26;
            // 
            // TxtEmanetBitimTarih
            // 
            this.TxtEmanetBitimTarih.Location = new System.Drawing.Point(178, 185);
            this.TxtEmanetBitimTarih.Name = "TxtEmanetBitimTarih";
            this.TxtEmanetBitimTarih.Size = new System.Drawing.Size(100, 20);
            this.TxtEmanetBitimTarih.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(103, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = "Emanet Not :";
            // 
            // TxtEmanetNot
            // 
            this.TxtEmanetNot.Location = new System.Drawing.Point(178, 241);
            this.TxtEmanetNot.Name = "TxtEmanetNot";
            this.TxtEmanetNot.Size = new System.Drawing.Size(100, 20);
            this.TxtEmanetNot.TabIndex = 35;
            // 
            // TxtEmanetBaslangicTarih
            // 
            this.TxtEmanetBaslangicTarih.Location = new System.Drawing.Point(178, 158);
            this.TxtEmanetBaslangicTarih.Name = "TxtEmanetBaslangicTarih";
            this.TxtEmanetBaslangicTarih.Size = new System.Drawing.Size(100, 20);
            this.TxtEmanetBaslangicTarih.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Emanet Başlama Tarihi :";
            // 
            // TxtEmanetIslemTarih
            // 
            this.TxtEmanetIslemTarih.Location = new System.Drawing.Point(178, 213);
            this.TxtEmanetIslemTarih.Name = "TxtEmanetIslemTarih";
            this.TxtEmanetIslemTarih.Size = new System.Drawing.Size(100, 20);
            this.TxtEmanetIslemTarih.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(67, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Emanet İşlem Tarihi :";
            // 
            // TxtEmanetNo
            // 
            this.TxtEmanetNo.Location = new System.Drawing.Point(178, 46);
            this.TxtEmanetNo.Name = "TxtEmanetNo";
            this.TxtEmanetNo.Size = new System.Drawing.Size(100, 20);
            this.TxtEmanetNo.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(106, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Emanet No :";
            // 
            // FrmOduncVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.erkanildiz1007;
            this.ClientSize = new System.Drawing.Size(757, 420);
            this.Controls.Add(this.TxtEmanetNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEmanetIslemTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtEmanetBaslangicTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtEmanetNot);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnOduncVer);
            this.Controls.Add(this.TxtEmanetBitimTarih);
            this.Controls.Add(this.TxtBarkodNo);
            this.Controls.Add(this.TxtPKullaniciAdi);
            this.Controls.Add(this.TxtOVKullaniciAdi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FrmOduncVerme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOduncVerme";
            this.Load += new System.EventHandler(this.FrmOduncVerme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnOduncVer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtOVKullaniciAdi;
        private System.Windows.Forms.TextBox TxtPKullaniciAdi;
        private System.Windows.Forms.TextBox TxtBarkodNo;
        private System.Windows.Forms.TextBox TxtEmanetBitimTarih;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtEmanetNot;
        private System.Windows.Forms.TextBox TxtEmanetBaslangicTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmanetIslemTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmanetNo;
        private System.Windows.Forms.Label label3;
    }
}