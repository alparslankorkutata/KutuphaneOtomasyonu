namespace kutuphaneotomasyonu
{
    partial class FrmAdmin
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.delete_icon;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(568, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 64);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.home;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(502, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 64);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(289, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 96);
            this.button6.TabIndex = 9;
            this.button6.Text = "EMANET VERME İŞLEMLERİ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(65, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 96);
            this.button1.TabIndex = 8;
            this.button1.Text = "KiTAP İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(502, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 96);
            this.button4.TabIndex = 12;
            this.button4.Text = "ÜYE İŞLEMLERİ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources._500_avm_de_kutuphane_olacak_h15282_98cbf;
            this.ClientSize = new System.Drawing.Size(672, 417);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}