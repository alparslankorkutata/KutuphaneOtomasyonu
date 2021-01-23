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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKitapIslemleri frmkitap = new FrmKitapIslemleri();
            frmkitap.Show();
            Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmUyeIslemleri frmuyeislemleri = new FrmUyeIslemleri();
            frmuyeislemleri.ShowDialog();
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmOduncVerme frmoduncverme = new FrmOduncVerme();
            frmoduncverme.ShowDialog();
        }
    }
}
