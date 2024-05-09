using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Telecommunication
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form3()
        {
            InitializeComponent();
        }


        void CagriGetir()
        {
            baglanti = new SqlConnection("server=.;Initial Catalog = telecominication ; Integrated Security = SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM tblCagri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            CagriGetir();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Server=.;Initial Catalog = telecominication ; Integrated Security = true");
            string sorgu = "INSERT INTO tblCagri(musteriID,ad,soyad) VALUES (@müsteriID,@ad,@soyad)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteriID", textID.Text);
            komut.Parameters.AddWithValue("@ad", textAd.Text);
            komut.Parameters.AddWithValue("@soyad", textSoyad.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            CagriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tblCagri WHERE musteriId=@müsteriID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteriID", Convert.ToInt32(textID.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            CagriGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE tblCagri SET ad=@ad, soyad = @soyad WHERE musteriID=@musteriID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musteriID",Convert.ToInt32(textID.Text));
            komut.Parameters.AddWithValue("@ad", textAd.Text);
            komut.Parameters.AddWithValue("@ad", textSoyad.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            CagriGetir();
        }
    }
}
