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
    public partial class FrmUyeIslemleri : Form
    {
        public FrmUyeIslemleri()
        {
            InitializeComponent();
        }

        private void FrmUyeIslemleri_Load(object sender, EventArgs e)
        {
            MTxtTc.MaxLength = 11;
            btnAra.Enabled = false;
        }
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                OleDbCommand kontrol = new OleDbCommand("Select * from TblKullanici where TcKNo=@TCK", baglanti);
                kontrol.Parameters.AddWithValue("@TCK", MTxtTc.Text.ToString());

                var sonuc = Convert.ToInt32(kontrol.ExecuteScalar());
                if (sonuc <= 0)
                {
                    OleDbCommand komut = new OleDbCommand("INSERT INTO TblKullanici(TcKNo,Adi,Soyadi,Parola,KullaniciAdi,DogumTarihi,DogumYeri,Telefon,Eposta,Cinsiyet,Adres,Yetki)values(@TcKNo,@Adi,@Soyadi,@Parola,@KullaniciAdi,@DogumTarihi,@DogumYeri,@Telefon,@Eposta,@Cinsiyet,@Adres,@Yetki)", baglanti);

                    komut.Parameters.AddWithValue("@TcKNo", MTxtTc.Text.ToString());
                    komut.Parameters.AddWithValue("@Adi", TxtAdı.Text.ToString());
                    komut.Parameters.AddWithValue("@Soyadi", TxtSoyad.Text.ToString());
                    komut.Parameters.AddWithValue("@Parola", TxtParola.Text.ToString());
                    komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi.Text.ToString());
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
                    Temizle();
                    Listele();
                }
                else
                    MessageBox.Show("Bu TC Kimlik Numaralı Kişi Veritabanında Kayıtlı Tekrar Kayıt Yapamazsınız !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();


            }
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void Temizle()
        {
            MTxtTc.Clear();
            TxtAdı.Clear();
            TxtSoyad.Clear();
            TxtParola.Clear();
            TxtDogumYeri.Clear();
            MTxtTel.Clear();
            TxtPosta.Clear();
            CmbCinsiyet.SelectedItem = null;
            TxtAdres.Clear();
            CmbYetki.SelectedItem = null;


        }
        private void Listele()
        {
            SetFontAndColors();
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");

            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *From TblKullanici", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        private void BtnKitapSil_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
            string secilibarkod = "";
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                secilibarkod = item.Cells[1].Value.ToString();
            }
            var result = MessageBox.Show(secilibarkod + " barkod numaralı kitabı silmek istediğinizden emin misiniz?", "Silme İşlemi Onay", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                baglanti.Open();


                komut = new OleDbCommand("DELETE FROM TblKullanici where TcKNo='" + secilibarkod + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Listele();
            }
            else
                MessageBox.Show("Silme işleminiz iptal edilmiştir.");

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void butongoruntule()
        {
            MTxtTc.Enabled = true;
            MTxtTel.Enabled = true;
            TxtAdres.Enabled = true;
            TxtAdı.Enabled = true;
            TxtDogumYeri.Enabled = true;
            TxtParola.Enabled = true;
            TxtPosta.Enabled = true;
            TxtSoyad.Enabled = true;
            CmbCinsiyet.Enabled = true;
            CmbYetki.Enabled = true;
            radioButton1.Enabled = true;
            radioButton1.Checked = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
            adtr = new OleDbDataAdapter("SElect *from TblKullanici where TcKNo like '" + MTxtTc.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            adtr.Fill(ds, "tablo");
            dataGridView1.DataSource = ds.Tables["tablo"];
            baglanti.Close();
            Temizle();
            butongoruntule();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                btnAra.Enabled = true;
                MTxtTel.Enabled = false;
                TxtAdres.Enabled = false;
                TxtAdı.Enabled = false;
                TxtDogumYeri.Enabled = false;
                TxtParola.Enabled = false;
                TxtPosta.Enabled = false;
                TxtSoyad.Enabled = false;
                CmbCinsiyet.Enabled = false;
                CmbYetki.Enabled = false;
                Temizle();

            }
            else
            {
                btnAra.Enabled = false;
                MTxtTel.Enabled = true;
                TxtAdres.Enabled = true;
                TxtAdı.Enabled = true;
                TxtDogumYeri.Enabled = true;
                TxtParola.Enabled = true;
                TxtPosta.Enabled = true;
                TxtSoyad.Enabled = true;
                CmbCinsiyet.Enabled = true;
                CmbYetki.Enabled = true;
                butongoruntule();

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            butongoruntule();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");

            string tc = "";
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    MTxtTc.Text = item.Cells[1].Value.ToString();
                    TxtAdı.Text = item.Cells[2].Value.ToString();
                    TxtSoyad.Text = item.Cells[3].Value.ToString();
                    TxtParola.Text = item.Cells[4].Value.ToString();
                    DTDogumTarihi.Text = item.Cells[5].Value.ToString();
                    TxtDogumYeri.Text = item.Cells[6].Value.ToString();
                    MTxtTel.Text = item.Cells[7].Value.ToString();
                    TxtPosta.Text = item.Cells[8].Value.ToString();
                    CmbCinsiyet.Text= item.Cells[9].Value.ToString();
                    TxtAdres.Text = item.Cells[10].Value.ToString();
                    CmbYetki.Text= item.Cells[11].Value.ToString();



                }
                    MTxtTc.Enabled = false;



            OleDbCommand kontrol = new OleDbCommand("Select * from TblKullanici where TcKNo=@TCK", baglanti);
            kontrol.Parameters.AddWithValue("@TCK", tc);


        }

        private void BtnKitapGuncelle_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                OleDbCommand kontrol = new OleDbCommand("Select * from TblKullanici where TcKNo=@TCK", baglanti);
                kontrol.Parameters.AddWithValue("@TCK", MTxtTc.Text.ToString());

                var sonuc = Convert.ToInt32(kontrol.ExecuteScalar());
                if (sonuc > 0)
                {
                    OleDbCommand komut = new OleDbCommand("Update TblKullanici set TcKNo=@TcKNo, Adi=@Adi, Soyadi=@Soyadi,Parola=@Parola,KullaniciAdi=@KullaniciAdi, DogumTarihi=@DogumTarihi,DogumYeri=@DogumYeri,Telefon=@Telefon,Eposta=@Eposta,Cinsiyet=@Cinsiyet,Adres=@Adres,Yetki=@Yetki where TcKNo=@TcKNo", baglanti);
                    
                    
                    komut.Parameters.AddWithValue("@TcKNo", MTxtTc.Text.ToString());
                    komut.Parameters.AddWithValue("@Adi", TxtAdı.Text.ToString());
                    komut.Parameters.AddWithValue("@Soyadi", TxtSoyad.Text.ToString());
                    komut.Parameters.AddWithValue("@Parola", TxtParola.Text.ToString());
                    komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@DogumTarihi", DTDogumTarihi.Text.ToString());
                    komut.Parameters.AddWithValue("@DogumYeri", TxtDogumYeri.Text.ToString());
                    komut.Parameters.AddWithValue("@Telefon", MTxtTel.Text.ToString());
                    komut.Parameters.AddWithValue("@Eposta", TxtPosta.Text.ToString());
                    komut.Parameters.AddWithValue("@Cinsiyet", CmbCinsiyet.Text.ToString());
                    komut.Parameters.AddWithValue("@Adres", TxtAdres.Text.ToString());
                    komut.Parameters.AddWithValue("@Yetki", CmbYetki.Text.ToString());


                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Güncellendi.");
                    Temizle();
                    Listele();
                }
                else
                    MessageBox.Show("Bu TC Kimlik Numaralı Kişi Veritabanında Kayıtlı Değildir. !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();


            }
        }

        private void CmbYetki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            FrmAdmin Frmadmin = new FrmAdmin();
            Frmadmin.Show();
            Dispose();
        }
    }
}
