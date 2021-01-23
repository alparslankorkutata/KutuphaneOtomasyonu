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
    public partial class FrmPersonel : Form
    {
        
        public FrmPersonel()
        {
            InitializeComponent();
          
        }
        public int personelId;
        private void button1_Click(object sender, EventArgs e)
        {
            FrmKitapIslemleri frmkitapislemleri = new FrmKitapIslemleri();
            frmkitapislemleri.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmOduncVerme frmOduncVerme = new FrmOduncVerme();
            frmOduncVerme.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
