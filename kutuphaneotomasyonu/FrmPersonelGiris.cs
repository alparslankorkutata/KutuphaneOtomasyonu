using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyonu
{
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = TxtKullaniciAdi.Text.ToString();
            string parola = TxtParola.Text.ToString();
            OleDbCommand komut = new OleDbCommand();
            OleDbCommand komut1 = new OleDbCommand();
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT Yetki FROM TblKullanici where KullaniciAdi='" + kullaniciadi + "' AND Parola='" + parola + "'";
            komut1.Connection = baglanti;
           
            var yetki = komut.ExecuteScalar();
          
            if (yetki != null)
            {
                if (yetki.ToString() == "Personel")
                {
                    FrmPersonel FrmPersonel = new FrmPersonel();
                    komut1.CommandText = "SELECT Id FROM TblKullanici where KullaniciAdi='" + kullaniciadi + "' AND Parola='" + parola + "'";
                    var personelId = komut1.ExecuteScalar();
                    if(personelId!=null)
                        FrmPersonel.personelId = Convert.ToInt32(personelId);
                    FrmPersonel.Show();

                }
                else if (yetki.ToString() == "Üye")
                {
                    FrmUye FrmUye = new FrmUye();
                    FrmUye.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                TxtKullaniciAdi.Clear();
                TxtParola.Clear();
                TxtKullaniciAdi.Focus();
            }



            baglanti.Close();
        }
    }
}
