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
    public partial class FrmKitapIslemleri : Form
    {
        public FrmKitapIslemleri()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void FrmKitapIslemleri_Load(object sender, EventArgs e)
        {

        }
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();


                komut = new OleDbCommand("INSERT INTO TblKitap(BarkodNumarasi,KitapAdi,KitapYazari,KitapBaskıYılı,KitapSayfaSayisi,Dil,KitapYayınevi,KitapAciklama)values(@BarkodNumarasi,@KitapAdi,@KitapYazari,@KitapBaskıYılı,@KitapSayfaSayisi,@Dil,@KitapYayınevi,@KitapAciklama)", baglanti);

                komut.Parameters.AddWithValue("@BarkodNumarasi", TxtBarkodNo.Text.ToString());
                komut.Parameters.AddWithValue("@KitapAdi", TxtKitapAdı.Text.ToString());
                komut.Parameters.AddWithValue("@KitapYazari", TxtYazarı.Text.ToString());
                komut.Parameters.AddWithValue("@KitapBaskıYılı", DTBaskıYılı.Text.ToString());
                komut.Parameters.AddWithValue("@KitapSayfaSayisi", TxtSayfaSayisi.Text.ToString());
                komut.Parameters.AddWithValue("@Dil", CmbDil.Text.ToString());
                komut.Parameters.AddWithValue("@KitapYayınevi", TxtYayınEvi.Text.ToString());
                komut.Parameters.AddWithValue("@KitapAciklama", TxtAcıklama.Text.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Veritabanına Eklendi");
                Listele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();


            }

        }
        private void Temizle()
        {
            TxtYazarı.Clear();
            TxtAcıklama.Clear();
            TxtBarkodNo.Clear();
            TxtKitapAdı.Clear();
            TxtSayfaSayisi.Clear();
            TxtYayınEvi.Clear();
            CmbDil.SelectedValue = 0;
            
        }
        private void Listele(string barkodno = null, string kitapadi = null, string yazari = null, string yayinevi = null)
        {
            SetFontAndColors();
            DataTable tablo = new DataTable();
            dataGridView1.DataSource = tablo;
            baglanti.Open();

            var query = "Select * From TblKitap";


            if (barkodno != null)
            {
                query = query + " Where BarkodNumarasi = @BarkodNumarasi";

            }
           else  if (kitapadi != null)
            {
                query = query + " Where KitapAdi=@KitapAdi";

            }

            else if (yazari != null)
            {
                query = query + " Where KitapYazari=@KitapYazari";
            }

             else if (yayinevi != null)
            {
                query = query + " Where KitapYayınevi=@KitapYayınevi";
                komut.Parameters.AddWithValue("@KitapYayınevi", yayinevi);
            }
            komut = new OleDbCommand(query, baglanti);
            if (barkodno != null)
                komut.Parameters.AddWithValue("@BarkodNumarasi", barkodno);
            else if (kitapadi != null)
                komut.Parameters.AddWithValue("@KitapAdi", kitapadi);
            else if (yazari != null)
                komut.Parameters.AddWithValue("@KitapYazari", yazari);

            adtr = new OleDbDataAdapter(komut);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void BtnKitapSil_Click(object sender, EventArgs e)
        {
            string secilibarkod = "";
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                secilibarkod = item.Cells[1].Value.ToString();
            }
            var result = MessageBox.Show(secilibarkod + " barkod numaralı kitabı silmek istediğinizden emin misiniz?", "Silme İşlemi Onay", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                baglanti.Open();


                komut = new OleDbCommand("DELETE FROM TblKitap where BarkodNumarasi='" + secilibarkod + "'", baglanti);
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

        
        private void BtnKitapAra_Click(object sender, EventArgs e)
        {
            try
            {

                
                if (TxtBarkodNo.Text == "" && TxtKitapAdı.Text == "" && TxtYazarı.Text == "" && TxtYayınEvi.Text == "")
                    MessageBox.Show("Arama işlemi için barkod numarası, kitap adı, kitap yazarı veya kitap yayın evi alanlarından en az birine veri girmek zorundasınız.");
                else
                {
                   
                    string barkod = null, kitapadi = null, yazari = null, yayinevi = null;
                    if (TxtBarkodNo.Text != "")
                        barkod = TxtBarkodNo.Text.ToString();
                    else if (TxtKitapAdı.Text != "")
                        kitapadi = TxtKitapAdı.Text.ToString();
                    else if (TxtYazarı.Text != "")
                        yazari = TxtYazarı.Text.ToString();
                    else if (TxtYayınEvi.Text != "")
                        yayinevi = TxtYayınEvi.Text.ToString();
                    Listele(barkod, kitapadi,yazari, yayinevi);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();


            }
        }

        private void RDBarkod_CheckedChanged(object sender, EventArgs e)
        {
            if (RDBarkod.Checked == true)
            {
                DTBaskıYılı.Enabled = false;
                CmbDil.Enabled = false;
                TxtKitapAdı.Enabled = false;
                TxtSayfaSayisi.Enabled = false;
                TxtYayınEvi.Enabled = false;
                TxtYazarı.Enabled = false;
                TxtAcıklama.Enabled = false;
                BtnKitapAra.Enabled = true;
                Temizle();

            }
            else
            {
                DTBaskıYılı.Enabled = true;
                CmbDil.Enabled = true;
                TxtKitapAdı.Enabled = true;
                TxtSayfaSayisi.Enabled = true;
                TxtYayınEvi.Enabled = true;
                TxtYazarı.Enabled = true;
                TxtAcıklama.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void RDKitapAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (RDKitapAdi.Checked == true)
            {
                DTBaskıYılı.Enabled = false;
                CmbDil.Enabled = false;
                TxtBarkodNo.Enabled = false;
                TxtSayfaSayisi.Enabled = false;
                TxtYayınEvi.Enabled = false;
                TxtYazarı.Enabled = false;
                TxtAcıklama.Enabled = false;
                BtnKitapAra.Enabled = true;
                Temizle();
            }
            else
            {
                DTBaskıYılı.Enabled = true;
                CmbDil.Enabled = true;
                TxtBarkodNo.Enabled = true;
                TxtSayfaSayisi.Enabled = true;
                TxtYayınEvi.Enabled = true;
                TxtYazarı.Enabled = true;
                TxtAcıklama.Enabled = true;
            }
        }

        private void RDYayinEvi_CheckedChanged(object sender, EventArgs e)
        {
            if (RDYayinEvi.Checked == true)
            {
                DTBaskıYılı.Enabled = false;
                CmbDil.Enabled = false;
                TxtKitapAdı.Enabled = false;
                TxtSayfaSayisi.Enabled = false;
                TxtBarkodNo.Enabled = false;
                TxtYazarı.Enabled = false;
                TxtAcıklama.Enabled = false;
                BtnKitapAra.Enabled = true;
                Temizle();
            }
            else
            {
                DTBaskıYılı.Enabled = true;
                CmbDil.Enabled = true;
                TxtKitapAdı.Enabled = true;
                TxtSayfaSayisi.Enabled = true;
                TxtBarkodNo.Enabled = true;
                TxtYazarı.Enabled = true;
                TxtAcıklama.Enabled = true;
            }
        }

        private void RDYazarı_CheckedChanged(object sender, EventArgs e)
        {
            if (RDYazarı.Checked == true)
            {
                DTBaskıYılı.Enabled = false;
                CmbDil.Enabled = false;
                TxtKitapAdı.Enabled = false;
                TxtSayfaSayisi.Enabled = false;
                TxtYayınEvi.Enabled = false;
                TxtBarkodNo.Enabled = false;
                TxtAcıklama.Enabled = false;
                BtnKitapAra.Enabled = true;
                Temizle();
            }
            else
            {
                DTBaskıYılı.Enabled = true;
                CmbDil.Enabled = true;
                TxtKitapAdı.Enabled = true;
                TxtSayfaSayisi.Enabled = true;
                TxtYayınEvi.Enabled = true;
                TxtBarkodNo.Enabled = true;
                TxtAcıklama.Enabled = true;

            }
        }

        private void RDHicbiri_CheckedChanged(object sender, EventArgs e)
        {
            if (RDHicbiri.Checked == true)
            {
                DTBaskıYılı.Enabled = true;
                CmbDil.Enabled = true;
                TxtKitapAdı.Enabled = true;
                TxtSayfaSayisi.Enabled = true;
                TxtYazarı.Enabled = true;
                TxtYayınEvi.Enabled = true;
                TxtBarkodNo.Enabled = true;
                TxtAcıklama.Enabled = true;
                BtnKitapAra.Enabled = false;
                Temizle();
            }
        }
       
        

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");

            string barkodno = "";
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                TxtBarkodNo.Text = item.Cells[1].Value.ToString();
                TxtKitapAdı.Text = item.Cells[2].Value.ToString();
                TxtYazarı.Text = item.Cells[3].Value.ToString();
                DTBaskıYılı.Text = item.Cells[4].Value.ToString();
                TxtSayfaSayisi.Text = item.Cells[5].Value.ToString();
                CmbDil.Text = item.Cells[6].Value.ToString();
                TxtYayınEvi.Text = item.Cells[7].Value.ToString();
                TxtAcıklama.Text = item.Cells[8].Value.ToString();
                
            }
            TxtBarkodNo.Enabled = false;



            OleDbCommand kontrol = new OleDbCommand("Select * from TblKitap where BarkodNumarasi=@BarkodNumarasi", baglanti);
            kontrol.Parameters.AddWithValue("@BarkodNumarasi", barkodno);


        }
        private void BtnKitapGuncelle_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                OleDbCommand kontrol = new OleDbCommand("Select * from TblKitap where BarkodNumarasi=@BarkodNumarasi", baglanti);
                kontrol.Parameters.AddWithValue("@BarkodNumarasi", TxtBarkodNo.Text.ToString());

                var sonuc = Convert.ToInt32(kontrol.ExecuteScalar());
                if (sonuc > 0)
                {
                    OleDbCommand komut = new OleDbCommand("Update TblKitap set BarkodNumarasi=@BarkodNumarasi, KitapAdi=@KitapAdi, KitapYazari=@KitapYazari,KitapBaskıYılı=@KitapBaskıYılı, KitapSayfaSayisi=@KitapSayfaSayisi,Dil=@Dil,KitapYayınevi=@KitapYayınevi,KitapAciklama=@KitapAciklama  where BarkodNumarasi=@BarkodNumarasi", baglanti);

                    komut.Parameters.AddWithValue("@BarkodNumarasi", TxtBarkodNo.Text.ToString());
                    komut.Parameters.AddWithValue("@KitapAdi", TxtKitapAdı.Text.ToString());
                    komut.Parameters.AddWithValue("@KitapYazari", TxtYazarı.Text.ToString());
                    komut.Parameters.AddWithValue("@KitapBaskıYılı", DTBaskıYılı.Text.ToString());
                    komut.Parameters.AddWithValue("@KitapSayfaSayisi", TxtSayfaSayisi.Text.ToString());
                    komut.Parameters.AddWithValue("@Dil", CmbDil.Text.ToString());
                    komut.Parameters.AddWithValue("@KitapYayınevi", TxtYayınEvi.Text.ToString());
                    komut.Parameters.AddWithValue("@KitapAciklama", TxtAcıklama.Text.ToString());

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Güncellendi.");
                    Temizle();
                    Listele();
                }
                else
                    MessageBox.Show("Bu Barkod Numarası Veritabanında Kayıtlı Değildir. !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();


            }
        }

        private void TxtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbDil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

       
    }




