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
    public partial class FrmOduncVerme : Form
    {
        public FrmOduncVerme()
        {
            InitializeComponent();
        }
        //public int personelId;
        //private void label9_Click(object sender, EventArgs e)
        //{

        //}
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\kutuphaneveritabanı.mdb");
        private void FrmOduncVerme_Load(object sender, EventArgs e)
        {

            //komut.Connection = baglanti;
            //komut.CommandText = "SELECT Adi FROM TblKullanici where Id=" + personelId;
            //var kullaniciadi = komut.ExecuteScalar();
            //if (kullaniciadi != null)
            //    TxtPKullaniciAdi.Text = kullaniciadi.ToString();

            //baglanti.Close();
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }
        private void BtnOduncVer_Click(object sender, EventArgs e)
        {
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();


                komut = new OleDbCommand("INSERT INTO TblEmanet(EmanetNumarası,UyeKAdi,OduncVerenKAdi,KitapBarkodNo,EmanetVermeTarihi,EmanetBitimTarihi,EmanetİslemTarihi,EmanetNot)values(@EmanetNumarası,@UyeKAdi,@OduncVerenKAdi,@KitapBarkodNo,@EmanetVermeTarihi,@EmanetBitimTarihi,@EmanetİslemTarihi,@EmanetNot)", baglanti);
                komut.Parameters.AddWithValue("@EmanetNumarası", TxtEmanetNo.Text.ToString());
                komut.Parameters.AddWithValue("@UyeKAdi", TxtPKullaniciAdi.Text.ToString());
                komut.Parameters.AddWithValue("@OduncVerenKAdi", TxtOVKullaniciAdi.Text.ToString());
                komut.Parameters.AddWithValue("@KitapBarkodNo", TxtBarkodNo.Text.ToString());
                komut.Parameters.AddWithValue("@EmanetVermeTarihi", TxtEmanetBaslangicTarih.Text.ToString());
                komut.Parameters.AddWithValue("@EmanetBitimTarihi", TxtEmanetBitimTarih.Text.ToString());
                komut.Parameters.AddWithValue("@EmanetİslemTarihi", TxtEmanetIslemTarih.Text.ToString());
                komut.Parameters.AddWithValue("@EmanetNot", TxtEmanetNot.Text.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Emanet Veritabanına Eklendi");
                Listele();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();



            }
        }


        private void Listele()
        {
            SetFontAndColors();
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\kutuphaneveritabanı.mdb");

            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *From TblEmanet", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string oduncverilenbarkod = "";
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                oduncverilenbarkod = item.Cells[1].Value.ToString();
            }
            var result = MessageBox.Show(oduncverilenbarkod + " Ödünç verilen veriyi silmek istediğinizden emin misiniz?", "Silme İşlemi Onay", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                baglanti.Open();

                komut = new OleDbCommand("DELETE FROM TblEmanet where EmanetNumarası='" + oduncverilenbarkod + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Listele();
            }
            else
                MessageBox.Show("Silme işleminiz iptal edilmiştir.");
        }
    }
}
