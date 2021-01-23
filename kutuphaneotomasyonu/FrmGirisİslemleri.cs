using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyonu
{
    public partial class FrmGirisİslemleri : Form
    {
        public FrmGirisİslemleri()
        {
            InitializeComponent();
        }

        private void FrmGirisİslemleri_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frmAdmin = new FrmAdminGiris();
            frmAdmin.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FrmGirisİslemleri frmgiris = new FrmGirisİslemleri();
            FrmMisafirKayıt frmmsfr = new FrmMisafirKayıt();
            frmgiris.Hide();
            frmmsfr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris frmpersonelgiris = new FrmPersonelGiris();
            frmpersonelgiris.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUyeGiris frmuyegiris = new FormUyeGiris();
            frmuyegiris.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMisafirFormu frmmisafir = new FrmMisafirFormu();
            frmmisafir.Show();
            this.Hide();
        }
    }
}
