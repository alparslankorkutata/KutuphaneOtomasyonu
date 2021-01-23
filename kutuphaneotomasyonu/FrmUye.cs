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
    public partial class FrmUye : Form
    {
        public FrmUye()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGirisİslemleri frmüye = new FrmGirisİslemleri();
            frmüye.Show();
            this.Hide();
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kutuphaneveritabanı.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                    MessageBox.Show("Arama işlemi için kitap adı, kitap yazarı veya kitap yayın evi alanlarından en az birine veri girmek zorundasınız.");
                else
                {

                    string kitapadi = null, yazari = null, yayinevi = null;
                    if (textBox1.Text != "")
                        kitapadi = textBox1.Text.ToString();
                    else if (textBox2.Text != "")
                        yazari = textBox2.Text.ToString();
                    else if (textBox3.Text != "")
                        yayinevi = textBox3.Text.ToString();
                    Listele(kitapadi, yazari, yayinevi);

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
    }
}
