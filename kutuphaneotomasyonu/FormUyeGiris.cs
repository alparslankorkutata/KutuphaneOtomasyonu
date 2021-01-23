using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kutuphaneotomasyonu
{
    public partial class FormUyeGiris : Form
    {
        public FormUyeGiris()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnMGiris_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            OleDbCommand komut1 = new OleDbCommand();
            OleDbDataReader adtr;
            string ad = TxtMKullaniAdi.Text;
            string sifre = TxtMParola.Text;
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");

            baglanti.Open();
            komut.Connection = baglanti;


            komut.CommandText = "SELECT * FROM TblKullanici where KullaniciAdi='" + TxtMKullaniAdi.Text + "' AND Parola='" + TxtMParola.Text + "'";
            adtr = komut.ExecuteReader();
            if (adtr.Read())
            {
                FrmUye frmuye = new FrmUye();
                frmuye.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                TxtMParola.Clear();
                TxtMKullaniAdi.Focus();
            }


            baglanti.Close();
            Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtMParola.PasswordChar = '\0';

            }
            else
                TxtMParola.PasswordChar = '*';
        }
    }
}
