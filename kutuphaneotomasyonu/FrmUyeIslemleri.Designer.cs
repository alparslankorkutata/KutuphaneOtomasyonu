namespace kutuphaneotomasyonu
{
    partial class FrmUyeIslemleri
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
            this.CmbYetki = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.DtUyelikTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtPosta = new System.Windows.Forms.TextBox();
            this.MTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtDogumYeri = new System.Windows.Forms.TextBox();
            this.DTDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtAdı = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtParola = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKitapGuncelle = new System.Windows.Forms.Button();
            this.BtnKitapSil = new System.Windows.Forms.Button();
            this.BtnKitapEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.MTxtTc = new System.Windows.Forms.TextBox();
            this.GeriDon = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.KullaniciAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbYetki
            // 
            this.CmbYetki.FormattingEnabled = true;
            this.CmbYetki.Items.AddRange(new object[] {
            "Üye",
            "Personel"});
            this.CmbYetki.Location = new System.Drawing.Point(171, 554);
            this.CmbYetki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbYetki.Name = "CmbYetki";
            this.CmbYetki.Size = new System.Drawing.Size(173, 24);
            this.CmbYetki.TabIndex = 52;
            this.CmbYetki.SelectedIndexChanged += new System.EventHandler(this.CmbYetki_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 51;
            this.label12.Text = "Yetki  :";
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCıkıs.Location = new System.Drawing.Point(848, 508);
            this.BtnCıkıs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(94, 43);
            this.BtnCıkıs.TabIndex = 50;
            this.BtnCıkıs.Text = "ÇIKIŞ";
            this.BtnCıkıs.UseVisualStyleBackColor = false;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(171, 510);
            this.TxtAdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(172, 22);
            this.TxtAdres.TabIndex = 48;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Belirsiz"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(170, 464);
            this.CmbCinsiyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(173, 24);
            this.CmbCinsiyet.TabIndex = 47;
            // 
            // DtUyelikTarihi
            // 
            this.DtUyelikTarihi.Location = new System.Drawing.Point(171, 426);
            this.DtUyelikTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtUyelikTarihi.Name = "DtUyelikTarihi";
            this.DtUyelikTarihi.Size = new System.Drawing.Size(172, 22);
            this.DtUyelikTarihi.TabIndex = 46;
            // 
            // TxtPosta
            // 
            this.TxtPosta.Location = new System.Drawing.Point(171, 389);
            this.TxtPosta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPosta.Name = "TxtPosta";
            this.TxtPosta.Size = new System.Drawing.Size(172, 22);
            this.TxtPosta.TabIndex = 45;
            // 
            // MTxtTel
            // 
            this.MTxtTel.Location = new System.Drawing.Point(171, 350);
            this.MTxtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MTxtTel.Name = "MTxtTel";
            this.MTxtTel.Size = new System.Drawing.Size(172, 22);
            this.MTxtTel.TabIndex = 44;
            // 
            // TxtDogumYeri
            // 
            this.TxtDogumYeri.Location = new System.Drawing.Point(171, 311);
            this.TxtDogumYeri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDogumYeri.Name = "TxtDogumYeri";
            this.TxtDogumYeri.Size = new System.Drawing.Size(172, 22);
            this.TxtDogumYeri.TabIndex = 43;
            // 
            // DTDogumTarihi
            // 
            this.DTDogumTarihi.Location = new System.Drawing.Point(171, 274);
            this.DTDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTDogumTarihi.Name = "DTDogumTarihi";
            this.DTDogumTarihi.Size = new System.Drawing.Size(172, 22);
            this.DTDogumTarihi.TabIndex = 42;
            // 
            // TxtAdı
            // 
            this.TxtAdı.Location = new System.Drawing.Point(171, 139);
            this.TxtAdı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAdı.Name = "TxtAdı";
            this.TxtAdı.Size = new System.Drawing.Size(172, 22);
            this.TxtAdı.TabIndex = 41;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(171, 178);
            this.TxtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(172, 22);
            this.TxtSoyad.TabIndex = 40;
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(171, 212);
            this.TxtParola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Size = new System.Drawing.Size(172, 22);
            this.TxtParola.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(112, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Parola :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Adres :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cinsiyet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Üyelik Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "E Posta :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(107, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(85, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Doğum Yeri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(76, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(112, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(131, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(99, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tc Kimlik :";
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListele.Location = new System.Drawing.Point(351, 332);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(106, 66);
            this.BtnListele.TabIndex = 56;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKitapGuncelle
            // 
            this.BtnKitapGuncelle.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnKitapGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapGuncelle.Location = new System.Drawing.Point(352, 254);
            this.BtnKitapGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnKitapGuncelle.Name = "BtnKitapGuncelle";
            this.BtnKitapGuncelle.Size = new System.Drawing.Size(105, 66);
            this.BtnKitapGuncelle.TabIndex = 55;
            this.BtnKitapGuncelle.Text = "GÜNCELLE";
            this.BtnKitapGuncelle.UseVisualStyleBackColor = false;
            this.BtnKitapGuncelle.Click += new System.EventHandler(this.BtnKitapGuncelle_Click);
            // 
            // BtnKitapSil
            // 
            this.BtnKitapSil.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnKitapSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapSil.Location = new System.Drawing.Point(351, 171);
            this.BtnKitapSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnKitapSil.Name = "BtnKitapSil";
            this.BtnKitapSil.Size = new System.Drawing.Size(106, 60);
            this.BtnKitapSil.TabIndex = 54;
            this.BtnKitapSil.Text = "SİL";
            this.BtnKitapSil.UseVisualStyleBackColor = false;
            this.BtnKitapSil.Click += new System.EventHandler(this.BtnKitapSil_Click);
            // 
            // BtnKitapEkle
            // 
            this.BtnKitapEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtnKitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapEkle.Location = new System.Drawing.Point(351, 96);
            this.BtnKitapEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnKitapEkle.Name = "BtnKitapEkle";
            this.BtnKitapEkle.Size = new System.Drawing.Size(106, 60);
            this.BtnKitapEkle.TabIndex = 53;
            this.BtnKitapEkle.Text = "ÜYE EKLE";
            this.BtnKitapEkle.UseVisualStyleBackColor = false;
            this.BtnKitapEkle.Click += new System.EventHandler(this.BtnKitapEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 428);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Location = new System.Drawing.Point(352, 406);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(106, 66);
            this.btnAra.TabIndex = 58;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(63, 50);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(201, 20);
            this.radioButton1.TabIndex = 59;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TC Kimlik Numarasına Göre Ara ";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(321, 50);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 20);
            this.radioButton2.TabIndex = 60;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Diğer İşlemler";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MTxtTc
            // 
            this.MTxtTc.Location = new System.Drawing.Point(171, 103);
            this.MTxtTc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MTxtTc.Name = "MTxtTc";
            this.MTxtTc.Size = new System.Drawing.Size(172, 22);
            this.MTxtTc.TabIndex = 61;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.SystemColors.ControlText;
            this.GeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriDon.Location = new System.Drawing.Point(724, 508);
            this.GeriDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(104, 43);
            this.GeriDon.TabIndex = 62;
            this.GeriDon.Text = "Geri Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(82, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 63;
            this.label13.Text = "Kullanıcı Adı :";
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Location = new System.Drawing.Point(171, 242);
            this.KullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(173, 22);
            this.KullaniciAdi.TabIndex = 64;
            // 
            // FrmUyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.libr;
            this.ClientSize = new System.Drawing.Size(1071, 636);
            this.Controls.Add(this.KullaniciAdi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GeriDon);
            this.Controls.Add(this.MTxtTc);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnKitapGuncelle);
            this.Controls.Add(this.BtnKitapSil);
            this.Controls.Add(this.BtnKitapEkle);
            this.Controls.Add(this.CmbYetki);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.DtUyelikTarihi);
            this.Controls.Add(this.TxtPosta);
            this.Controls.Add(this.MTxtTel);
            this.Controls.Add(this.TxtDogumYeri);
            this.Controls.Add(this.DTDogumTarihi);
            this.Controls.Add(this.TxtAdı);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmUyeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUyeIslemleri";
            this.Load += new System.EventHandler(this.FrmUyeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbYetki;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.DateTimePicker DtUyelikTarihi;
        private System.Windows.Forms.TextBox TxtPosta;
        private System.Windows.Forms.MaskedTextBox MTxtTel;
        private System.Windows.Forms.TextBox TxtDogumYeri;
        private System.Windows.Forms.DateTimePicker DTDogumTarihi;
        private System.Windows.Forms.TextBox TxtAdı;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtParola;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKitapGuncelle;
        private System.Windows.Forms.Button BtnKitapSil;
        private System.Windows.Forms.Button BtnKitapEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox MTxtTc;
        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox KullaniciAdi;
    }
}