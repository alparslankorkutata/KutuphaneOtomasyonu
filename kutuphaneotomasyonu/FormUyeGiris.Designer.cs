
namespace kutuphaneotomasyonu
{
    partial class FormUyeGiris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMGiris = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMParola = new System.Windows.Forms.TextBox();
            this.TxtMKullaniAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.BtnMGiris);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtMParola);
            this.groupBox1.Controls.Add(this.TxtMKullaniAdi);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(250, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 210);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Girişi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnMGiris
            // 
            this.BtnMGiris.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.check_icon__1_;
            this.BtnMGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMGiris.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.BtnMGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMGiris.Location = new System.Drawing.Point(156, 133);
            this.BtnMGiris.Name = "BtnMGiris";
            this.BtnMGiris.Size = new System.Drawing.Size(66, 58);
            this.BtnMGiris.TabIndex = 11;
            this.BtnMGiris.UseVisualStyleBackColor = true;
            this.BtnMGiris.Click += new System.EventHandler(this.BtnMGiris_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(111, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Parola :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // TxtMParola
            // 
            this.TxtMParola.Location = new System.Drawing.Point(112, 64);
            this.TxtMParola.Name = "TxtMParola";
            this.TxtMParola.PasswordChar = '*';
            this.TxtMParola.Size = new System.Drawing.Size(110, 24);
            this.TxtMParola.TabIndex = 7;
            // 
            // TxtMKullaniAdi
            // 
            this.TxtMKullaniAdi.Location = new System.Drawing.Point(112, 28);
            this.TxtMKullaniAdi.Name = "TxtMKullaniAdi";
            this.TxtMKullaniAdi.Size = new System.Drawing.Size(110, 24);
            this.TxtMKullaniAdi.TabIndex = 6;
            // 
            // FormUyeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.kutuphane;
            this.ClientSize = new System.Drawing.Size(668, 368);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUyeGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUyeGiris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnMGiris;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMParola;
        private System.Windows.Forms.TextBox TxtMKullaniAdi;
    }
}