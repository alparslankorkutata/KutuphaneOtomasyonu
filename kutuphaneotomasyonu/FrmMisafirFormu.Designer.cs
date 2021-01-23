namespace kutuphaneotomasyonu
{
    partial class FrmMisafirFormu
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDYazar = new System.Windows.Forms.RadioButton();
            this.RDKitapAdı = new System.Windows.Forms.RadioButton();
            this.TxtKitapAdi = new System.Windows.Forms.TextBox();
            this.TxtYazari = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(359, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 262);
            this.dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.home;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(313, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 54);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.delete_icon;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(375, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 54);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(12, 452);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(473, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Kitap Ödünç Almak veya Daha Fazla İşlem Yapmak İçin Üye Olabilirsiniz ... ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.RDYazar);
            this.groupBox1.Controls.Add(this.RDKitapAdı);
            this.groupBox1.Controls.Add(this.TxtKitapAdi);
            this.groupBox1.Controls.Add(this.TxtYazari);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(43, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neye Göre Arama İşlemi Yapmak İstersiniz ?";
            // 
            // RDYazar
            // 
            this.RDYazar.AutoSize = true;
            this.RDYazar.BackColor = System.Drawing.Color.White;
            this.RDYazar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RDYazar.Location = new System.Drawing.Point(27, 71);
            this.RDYazar.Name = "RDYazar";
            this.RDYazar.Size = new System.Drawing.Size(99, 20);
            this.RDYazar.TabIndex = 20;
            this.RDYazar.TabStop = true;
            this.RDYazar.Text = "Yazara Göre";
            this.RDYazar.UseVisualStyleBackColor = false;
            this.RDYazar.CheckedChanged += new System.EventHandler(this.RDYazar_CheckedChanged);
            // 
            // RDKitapAdı
            // 
            this.RDKitapAdı.AutoSize = true;
            this.RDKitapAdı.BackColor = System.Drawing.Color.White;
            this.RDKitapAdı.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RDKitapAdı.Location = new System.Drawing.Point(27, 41);
            this.RDKitapAdı.Name = "RDKitapAdı";
            this.RDKitapAdı.Size = new System.Drawing.Size(124, 20);
            this.RDKitapAdı.TabIndex = 19;
            this.RDKitapAdı.TabStop = true;
            this.RDKitapAdı.Text = "Kitap Adına Göre";
            this.RDKitapAdı.UseVisualStyleBackColor = false;
            this.RDKitapAdı.CheckedChanged += new System.EventHandler(this.RDKitapAdı_CheckedChanged);
            // 
            // TxtKitapAdi
            // 
            this.TxtKitapAdi.Location = new System.Drawing.Point(157, 41);
            this.TxtKitapAdi.Name = "TxtKitapAdi";
            this.TxtKitapAdi.Size = new System.Drawing.Size(100, 24);
            this.TxtKitapAdi.TabIndex = 18;
            this.TxtKitapAdi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtYazari
            // 
            this.TxtYazari.Location = new System.Drawing.Point(157, 70);
            this.TxtYazari.Name = "TxtYazari";
            this.TxtYazari.Size = new System.Drawing.Size(100, 24);
            this.TxtYazari.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(359, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 67);
            this.button4.TabIndex = 17;
            this.button4.Text = "TÜMÜNÜ LİSTELE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmMisafirFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(493, 540);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FrmMisafirFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMisafirFormu";
            this.Load += new System.EventHandler(this.FrmMisafirFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDYazar;
        private System.Windows.Forms.RadioButton RDKitapAdı;
        private System.Windows.Forms.TextBox TxtKitapAdi;
        private System.Windows.Forms.TextBox TxtYazari;
        private System.Windows.Forms.Button button4;
    }
}