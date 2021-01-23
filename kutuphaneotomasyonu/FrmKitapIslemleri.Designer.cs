namespace kutuphaneotomasyonu
{
    partial class FrmKitapIslemleri
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
            this.TxtBarkodNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnKitapGuncelle = new System.Windows.Forms.Button();
            this.BtnKitapSil = new System.Windows.Forms.Button();
            this.BtnKitapEkle = new System.Windows.Forms.Button();
            this.TxtAcıklama = new System.Windows.Forms.TextBox();
            this.TxtYayınEvi = new System.Windows.Forms.TextBox();
            this.CmbDil = new System.Windows.Forms.ComboBox();
            this.TxtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.DTBaskıYılı = new System.Windows.Forms.DateTimePicker();
            this.TxtKitapAdı = new System.Windows.Forms.TextBox();
            this.TxtYazarı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.RDBarkod = new System.Windows.Forms.RadioButton();
            this.RDKitapAdi = new System.Windows.Forms.RadioButton();
            this.RDYazarı = new System.Windows.Forms.RadioButton();
            this.RDYayinEvi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDHicbiri = new System.Windows.Forms.RadioButton();
            this.BtnKitapAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBarkodNo
            // 
            this.TxtBarkodNo.Location = new System.Drawing.Point(126, 167);
            this.TxtBarkodNo.Name = "TxtBarkodNo";
            this.TxtBarkodNo.Size = new System.Drawing.Size(161, 20);
            this.TxtBarkodNo.TabIndex = 41;
            this.TxtBarkodNo.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Barkod Numarası :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(417, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 248);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnKitapGuncelle
            // 
            this.BtnKitapGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnKitapGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnKitapGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnKitapGuncelle.Location = new System.Drawing.Point(306, 164);
            this.BtnKitapGuncelle.Name = "BtnKitapGuncelle";
            this.BtnKitapGuncelle.Size = new System.Drawing.Size(90, 54);
            this.BtnKitapGuncelle.TabIndex = 38;
            this.BtnKitapGuncelle.Text = "GÜNCELLE";
            this.BtnKitapGuncelle.UseVisualStyleBackColor = false;
            this.BtnKitapGuncelle.Click += new System.EventHandler(this.BtnKitapGuncelle_Click);
            // 
            // BtnKitapSil
            // 
            this.BtnKitapSil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnKitapSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapSil.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnKitapSil.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnKitapSil.Location = new System.Drawing.Point(305, 92);
            this.BtnKitapSil.Name = "BtnKitapSil";
            this.BtnKitapSil.Size = new System.Drawing.Size(91, 54);
            this.BtnKitapSil.TabIndex = 37;
            this.BtnKitapSil.Text = "SİL";
            this.BtnKitapSil.UseVisualStyleBackColor = false;
            this.BtnKitapSil.Click += new System.EventHandler(this.BtnKitapSil_Click);
            // 
            // BtnKitapEkle
            // 
            this.BtnKitapEkle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnKitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapEkle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnKitapEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnKitapEkle.Location = new System.Drawing.Point(305, 297);
            this.BtnKitapEkle.Name = "BtnKitapEkle";
            this.BtnKitapEkle.Size = new System.Drawing.Size(91, 48);
            this.BtnKitapEkle.TabIndex = 35;
            this.BtnKitapEkle.Text = "KİTAP EKLE";
            this.BtnKitapEkle.UseVisualStyleBackColor = false;
            this.BtnKitapEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtAcıklama
            // 
            this.TxtAcıklama.Location = new System.Drawing.Point(126, 395);
            this.TxtAcıklama.Name = "TxtAcıklama";
            this.TxtAcıklama.Size = new System.Drawing.Size(161, 20);
            this.TxtAcıklama.TabIndex = 34;
            // 
            // TxtYayınEvi
            // 
            this.TxtYayınEvi.Location = new System.Drawing.Point(126, 360);
            this.TxtYayınEvi.Name = "TxtYayınEvi";
            this.TxtYayınEvi.Size = new System.Drawing.Size(161, 20);
            this.TxtYayınEvi.TabIndex = 33;
            // 
            // CmbDil
            // 
            this.CmbDil.FormattingEnabled = true;
            this.CmbDil.Location = new System.Drawing.Point(126, 326);
            this.CmbDil.Name = "CmbDil";
            this.CmbDil.Size = new System.Drawing.Size(161, 21);
            this.CmbDil.TabIndex = 32;
            this.CmbDil.SelectedIndexChanged += new System.EventHandler(this.CmbDil_SelectedIndexChanged);
            // 
            // TxtSayfaSayisi
            // 
            this.TxtSayfaSayisi.Location = new System.Drawing.Point(126, 291);
            this.TxtSayfaSayisi.Name = "TxtSayfaSayisi";
            this.TxtSayfaSayisi.Size = new System.Drawing.Size(161, 20);
            this.TxtSayfaSayisi.TabIndex = 31;
            // 
            // DTBaskıYılı
            // 
            this.DTBaskıYılı.Location = new System.Drawing.Point(126, 259);
            this.DTBaskıYılı.Name = "DTBaskıYılı";
            this.DTBaskıYılı.Size = new System.Drawing.Size(161, 20);
            this.DTBaskıYılı.TabIndex = 30;
            // 
            // TxtKitapAdı
            // 
            this.TxtKitapAdı.Location = new System.Drawing.Point(126, 196);
            this.TxtKitapAdı.Name = "TxtKitapAdı";
            this.TxtKitapAdı.Size = new System.Drawing.Size(161, 20);
            this.TxtKitapAdı.TabIndex = 29;
            // 
            // TxtYazarı
            // 
            this.TxtYazarı.Location = new System.Drawing.Point(126, 225);
            this.TxtYazarı.Name = "TxtYazarı";
            this.TxtYazarı.Size = new System.Drawing.Size(161, 20);
            this.TxtYazarı.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(41, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(40, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Yayın Evi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(72, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dil :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(42, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Baskı Yılı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yazarı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kitap Adı :";
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCıkıs.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCıkıs.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCıkıs.Location = new System.Drawing.Point(842, 379);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(83, 36);
            this.BtnCıkıs.TabIndex = 43;
            this.BtnCıkıs.Text = "ÇIKIŞ YAP";
            this.BtnCıkıs.UseVisualStyleBackColor = false;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListele.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnListele.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnListele.Location = new System.Drawing.Point(305, 228);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(91, 54);
            this.BtnListele.TabIndex = 44;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // RDBarkod
            // 
            this.RDBarkod.AutoSize = true;
            this.RDBarkod.BackColor = System.Drawing.Color.White;
            this.RDBarkod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RDBarkod.Location = new System.Drawing.Point(6, 19);
            this.RDBarkod.Name = "RDBarkod";
            this.RDBarkod.Size = new System.Drawing.Size(197, 20);
            this.RDBarkod.TabIndex = 45;
            this.RDBarkod.TabStop = true;
            this.RDBarkod.Text = "Barkod Numarasına Göre Ara";
            this.RDBarkod.UseVisualStyleBackColor = false;
            this.RDBarkod.CheckedChanged += new System.EventHandler(this.RDBarkod_CheckedChanged);
            // 
            // RDKitapAdi
            // 
            this.RDKitapAdi.AutoSize = true;
            this.RDKitapAdi.BackColor = System.Drawing.Color.White;
            this.RDKitapAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RDKitapAdi.Location = new System.Drawing.Point(6, 41);
            this.RDKitapAdi.Name = "RDKitapAdi";
            this.RDKitapAdi.Size = new System.Drawing.Size(151, 20);
            this.RDKitapAdi.TabIndex = 46;
            this.RDKitapAdi.TabStop = true;
            this.RDKitapAdi.Text = "Kitap Adına Göre Ara";
            this.RDKitapAdi.UseVisualStyleBackColor = false;
            this.RDKitapAdi.CheckedChanged += new System.EventHandler(this.RDKitapAdi_CheckedChanged);
            // 
            // RDYazarı
            // 
            this.RDYazarı.AutoSize = true;
            this.RDYazarı.BackColor = System.Drawing.Color.White;
            this.RDYazarı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RDYazarı.Location = new System.Drawing.Point(6, 83);
            this.RDYazarı.Name = "RDYazarı";
            this.RDYazarı.Size = new System.Drawing.Size(126, 20);
            this.RDYazarı.TabIndex = 47;
            this.RDYazarı.TabStop = true;
            this.RDYazarı.Text = "Yazara Göre Ara";
            this.RDYazarı.UseVisualStyleBackColor = false;
            this.RDYazarı.CheckedChanged += new System.EventHandler(this.RDYazarı_CheckedChanged);
            // 
            // RDYayinEvi
            // 
            this.RDYayinEvi.AutoSize = true;
            this.RDYayinEvi.BackColor = System.Drawing.Color.White;
            this.RDYayinEvi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RDYayinEvi.Location = new System.Drawing.Point(6, 64);
            this.RDYayinEvi.Name = "RDYayinEvi";
            this.RDYayinEvi.Size = new System.Drawing.Size(151, 20);
            this.RDYayinEvi.TabIndex = 48;
            this.RDYayinEvi.TabStop = true;
            this.RDYayinEvi.Text = "Yayın Evine Göre Ara";
            this.RDYayinEvi.UseVisualStyleBackColor = false;
            this.RDYayinEvi.CheckedChanged += new System.EventHandler(this.RDYayinEvi_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.RDHicbiri);
            this.groupBox1.Controls.Add(this.RDBarkod);
            this.groupBox1.Controls.Add(this.RDYazarı);
            this.groupBox1.Controls.Add(this.RDYayinEvi);
            this.groupBox1.Controls.Add(this.RDKitapAdi);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 141);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RDHicbiri
            // 
            this.RDHicbiri.AutoSize = true;
            this.RDHicbiri.BackColor = System.Drawing.Color.White;
            this.RDHicbiri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RDHicbiri.Location = new System.Drawing.Point(6, 106);
            this.RDHicbiri.Name = "RDHicbiri";
            this.RDHicbiri.Size = new System.Drawing.Size(63, 20);
            this.RDHicbiri.TabIndex = 49;
            this.RDHicbiri.TabStop = true;
            this.RDHicbiri.Text = "Hiçbiri";
            this.RDHicbiri.UseVisualStyleBackColor = false;
            this.RDHicbiri.CheckedChanged += new System.EventHandler(this.RDHicbiri_CheckedChanged);
            // 
            // BtnKitapAra
            // 
            this.BtnKitapAra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnKitapAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapAra.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnKitapAra.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnKitapAra.Location = new System.Drawing.Point(306, 32);
            this.BtnKitapAra.Name = "BtnKitapAra";
            this.BtnKitapAra.Size = new System.Drawing.Size(90, 54);
            this.BtnKitapAra.TabIndex = 36;
            this.BtnKitapAra.Text = "KİTAP ARA";
            this.BtnKitapAra.UseVisualStyleBackColor = false;
            this.BtnKitapAra.Click += new System.EventHandler(this.BtnKitapAra_Click);
            // 
            // FrmKitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources._444c1_kutuphane_1;
            this.ClientSize = new System.Drawing.Size(959, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.TxtBarkodNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnKitapGuncelle);
            this.Controls.Add(this.BtnKitapSil);
            this.Controls.Add(this.BtnKitapAra);
            this.Controls.Add(this.BtnKitapEkle);
            this.Controls.Add(this.TxtAcıklama);
            this.Controls.Add(this.TxtYayınEvi);
            this.Controls.Add(this.CmbDil);
            this.Controls.Add(this.TxtSayfaSayisi);
            this.Controls.Add(this.DTBaskıYılı);
            this.Controls.Add(this.TxtKitapAdı);
            this.Controls.Add(this.TxtYazarı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FrmKitapIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitapIslemleri";
            this.Load += new System.EventHandler(this.FrmKitapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBarkodNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKitapGuncelle;
        private System.Windows.Forms.Button BtnKitapSil;
        private System.Windows.Forms.Button BtnKitapAra;
        private System.Windows.Forms.Button BtnKitapEkle;
        private System.Windows.Forms.TextBox TxtAcıklama;
        private System.Windows.Forms.TextBox TxtYayınEvi;
        private System.Windows.Forms.ComboBox CmbDil;
        private System.Windows.Forms.TextBox TxtSayfaSayisi;
        private System.Windows.Forms.DateTimePicker DTBaskıYılı;
        private System.Windows.Forms.TextBox TxtKitapAdı;
        private System.Windows.Forms.TextBox TxtYazarı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.RadioButton RDBarkod;
        private System.Windows.Forms.RadioButton RDKitapAdi;
        private System.Windows.Forms.RadioButton RDYazarı;
        private System.Windows.Forms.RadioButton RDYayinEvi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDHicbiri;
    }
}