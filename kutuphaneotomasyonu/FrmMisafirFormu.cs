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
    public partial class FrmMisafirFormu : Form
    {
        public FrmMisafirFormu()
        {
            InitializeComponent();
        }
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtKitapAdi.Text == "" &&  TxtYazari.Text == "")
                    MessageBox.Show("Arama işlemi için kitap adı, kitap yazarı veya kitap yayın evi alanlarından en az birine veri girmek zorundasınız.");
                else
                {

                    string kitapadi = null, yazari = null;
                    if (TxtKitapAdi.Text != "")
                        kitapadi = TxtKitapAdi.Text.ToString();
                    else if (TxtYazari.Text != "")
                        yazari = TxtYazari.Text.ToString();
                    
                    Listele(kitapadi, yazari);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();


            }

        }
        private void Listele(string kitapadi = null, string yazari = null, string yayinevi = null)
        {
            SetFontAndColors();
            DataTable tablo = new DataTable();
            dataGridView1.DataSource = tablo;
            baglanti.Open();

            var query = "Select * From TblKitap";



            if (kitapadi != null)
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

            if (kitapadi != null)
                komut.Parameters.AddWithValue("@KitapAdi", kitapadi);
            else if (yazari != null)
                komut.Parameters.AddWithValue("@KitapYazari", yazari);
            

            adtr = new OleDbDataAdapter(komut);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();  
        }

        

        private void RDKitapAdı_CheckedChanged(object sender, EventArgs e)
        {
            if (RDKitapAdı.Checked == true)
            {
                
                TxtYazari.Enabled = false;


            }
            else
            {
               
                TxtYazari.Enabled = true;
                
            }
        }

        private void RDYazar_CheckedChanged(object sender, EventArgs e)
        {
            if (RDYazar.Checked == true)
            {
                
                TxtKitapAdi.Enabled = false;


            }
            else
            {
                
                TxtYazari.Enabled = true;
               
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                FrmMisafirKayıt frmkayıt = new FrmMisafirKayıt();
                frmkayıt.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGirisİslemleri frmgirisislemleri = new FrmGirisİslemleri();
            frmgirisislemleri.Show();
            this.Hide();
        }

        private void FrmMisafirFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
