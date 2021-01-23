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
using Microsoft.VisualBasic;

namespace kutuphaneotomasyonu
{
    public partial class FrmMisafirKayıt : Form
    {
        public FrmMisafirKayıt()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
            try
            {
                
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
              

                OleDbCommand komut = new OleDbCommand("INSERT INTO TblKullanici(KullaniciAdi,TcKNo,Adi,Soyadi,Parola,DogumTarihi,DogumYeri,Telefon,Eposta,Cinsiyet,Adres,Yetki)values(@KullaniciAdi,@TcKNo,@Adi,@Soyadi,@Parola,@DogumTarihi,@DogumYeri,@Telefon,@Eposta,@Cinsiyet,@Adres,@Yetki)", baglanti);

                komut.Parameters.AddWithValue("@KullaniciAdi", TxtKullaniciAdi.Text.ToString());
                komut.Parameters.AddWithValue("@TcKNo", MTxtTc.Text.ToString());
                komut.Parameters.AddWithValue("@Adi", TxtAdı.Text.ToString());
                komut.Parameters.AddWithValue("@Soyadi", TxtSoyad.Text.ToString());
                komut.Parameters.AddWithValue("@Parola", TxtParola.Text.ToString());
                komut.Parameters.AddWithValue("@DogumTarihi", DTDogumTarihi.Text.ToString());
                komut.Parameters.AddWithValue("@DogumYeri", TxtDogumYeri.Text.ToString());
                komut.Parameters.AddWithValue("@Telefon", MTxtTel.Text.ToString());
                komut.Parameters.AddWithValue("@Eposta", TxtPosta.Text.ToString());
                komut.Parameters.AddWithValue("@Cinsiyet", CmbCinsiyet.Text.ToString());
                komut.Parameters.AddWithValue("@Adres", TxtAdres.Text.ToString());
                komut.Parameters.AddWithValue("@Yetki", CmbYetki.Text.ToString());


                komut.ExecuteNonQuery();  
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();


            }
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOncekiMenu_Click(object sender, EventArgs e)
        {
            FrmGirisİslemleri frmmisafir = new FrmGirisİslemleri();
            frmmisafir.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAdı_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
