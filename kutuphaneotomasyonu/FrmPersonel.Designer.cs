namespace kutuphaneotomasyonu
{
    partial class FrmPersonel
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
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(115, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "KİTAP İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(321, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 84);
            this.button6.TabIndex = 5;
            this.button6.Text = "EMANET VERME İŞLEMLERİ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(377, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "ÇIKIŞ YAP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphaneotomasyonu.Properties.Resources.strahovsk_klter_cek_cumhuriyeti_780x519_a86q1qjlry;
            this.ClientSize = new System.Drawing.Size(545, 431);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
    }
}