using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anaokulu_Otomasyon.Siniflar;
using System.Data.SqlClient;
using System.Data.Sql;
namespace Anaokulu_Otomasyon
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtfiyat.Text = "";
            cmbdonem.Text = "";
            cmbdonemara.Text = "";
            cmbgider.Text = "";
            cmbgiderturu.Text = "";
            cmbOdemeTuru.Text = "";
        }

        void donemgrafikaktar() //Dönemin Gelir Bilgisi
        {
            Baglanti.baglan();
            SqlCommand cmd = new SqlCommand("SELECT Sum(Tutar) AS 'GELİR' FROM GelirGider WHERE GelirGider='Gelir' AND Donem=@p2 AND Durumu='1' GROUP BY Gelirgider", Baglanti.cnn);
            cmd.Parameters.AddWithValue("@p2", cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.chart1.Series["Gelir"].Points.AddXY("Gelir-Gider", (dr["GELİR"]).ToString());
            }
        }
        void donemgrafikaktar2()//Dönemin Gider Bilgisi
        {
            Baglanti.baglan();
            SqlCommand cmd = new SqlCommand("SELECT Sum(Tutar) AS 'Gider' FROM GelirGider WHERE GelirGider='Gider' AND Donem=@p1 AND Durumu='1' GROUP BY Gelirgider", Baglanti.cnn);
            cmd.Parameters.AddWithValue("@p1", cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.chart1.Series["Gider"].Points.AddXY("Gelir-Gider", (dr["Gider"]).ToString());
            }
            Baglanti.baglan().Close();
        }
        void TarihGrafikaktar() //2 Tarih Arasındaki Gelir Bilgisi
        {
            Baglanti.baglan();
            SqlCommand cmd = new SqlCommand("SELECT Sum(Tutar) AS 'Gelir' FROM GelirGider WHERE GelirGider='Gelir' AND Tarih between @p1 AND @p2 AND Durumu='1' GROUP BY Gelirgider", Baglanti.cnn);
            cmd.Parameters.AddWithValue("@p1", Convert.ToDateTime(dtgiristarih.Value.ToShortDateString()));
            cmd.Parameters.AddWithValue("@p2", Convert.ToDateTime(dtcikistarih.Value.ToShortDateString()));
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.chart1.Series["Gelir"].Points.AddXY("Gelir-Gider", (dr["Gelir"]).ToString());
            }
            Baglanti.baglan().Close();
        }
        void TarihGrafikaktar2()//2 tarih Arasındaki Gider Bilgisi
        {
            Baglanti.baglan();
            SqlCommand cmd = new SqlCommand("SELECT Sum(Tutar) AS 'Gider' FROM GelirGider WHERE GelirGider='Gider' AND Tarih between @p3 AND @p4 AND Durumu='1' GROUP BY Gelirgider", Baglanti.cnn);
            cmd.Parameters.AddWithValue("@p3", Convert.ToDateTime(dtgiristarih.Value.ToShortDateString()));
            cmd.Parameters.AddWithValue("@p4", Convert.ToDateTime(dtcikistarih.Value.ToShortDateString()));
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.chart1.Series["Gider"].Points.AddXY("Gelir-Gider", (dr["Gider"]).ToString());
            }
            Baglanti.baglan().Close();
        }
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //Gelir Giderleri Listele
            Baglanti.baglan();
            dtgridgelirgider.DataSource = GelirGider.GelirGiderListele();
            Baglanti.baglan().Close();
            dtgridgelirgider.Columns[0].Visible = false;
            dtgridgelirgider.Columns[1].Width = 80;
            dtgridgelirgider.Columns[3].Width = 80;
            dtgridgelirgider.Columns[2].Width = 80;
            dtgridgelirgider.Columns[6].Width = 80;
            dtgridgelirgider.Columns[4].Width = 114;
        }

        private void btngiderekle_Click(object sender, EventArgs e)
        {   //Gider Ekle
            Baglanti.baglan();
            GelirGider.GelirGiderEkle(cmbgider.GetItemText(cmbgider.SelectedItem), dttarih.Value, int.Parse(txtfiyat.Text), cmbgiderturu.GetItemText(cmbgiderturu.SelectedItem), cmbOdemeTuru.GetItemText(cmbOdemeTuru.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem));
            Baglanti.baglan().Close();
            MessageBox.Show("Gider Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Eklendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridgelirgider.DataSource = GelirGider.GelirGiderListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Kayıtları Yenile
            Baglanti.baglan();
            dtgridgelirgider.DataSource = GelirGider.GelirGiderListele();
            Baglanti.baglan().Close();
        }
        static int id;
        private void dtgridgelirgider_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Seçili Satırın bilgisini textbox,combobox aktarma
            int row = e.RowIndex;
            id = int.Parse(dtgridgelirgider.Rows[row].Cells[0].Value.ToString());
           cmbgider.Text = dtgridgelirgider.Rows[row].Cells[1].Value.ToString();
            dttarih.Text = dtgridgelirgider.Rows[row].Cells[2].Value.ToString();
            txtfiyat.Text = dtgridgelirgider.Rows[row].Cells[3].Value.ToString();
            cmbgiderturu.Text = dtgridgelirgider.Rows[row].Cells[4].Value.ToString();
            cmbOdemeTuru.Text = dtgridgelirgider.Rows[row].Cells[5].Value.ToString();
            cmbdonem.Text = dtgridgelirgider.Rows[row].Cells[6].Value.ToString();
        }

        private void btngiderguncelle_Click(object sender, EventArgs e)
        {   //Gider Güncelle
            Baglanti.baglan();
            GelirGider.GelirGiderGuncelle(cmbgider.GetItemText(cmbgider.SelectedItem), dttarih.Value, int.Parse(txtfiyat.Text), cmbgiderturu.GetItemText(cmbgiderturu.SelectedItem), cmbOdemeTuru.GetItemText(cmbOdemeTuru.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem), id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra kayıtları yenile
            Baglanti.baglan();
            dtgridgelirgider.DataSource = GelirGider.GelirGiderListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btngelirgidersil_Click(object sender, EventArgs e)
        {   //Gider Silme
            Baglanti.baglan();
            GelirGider.GelirGiderSil(id,dttarih.Value);
            Baglanti.baglan().Close();
            //Silindikten sonra kayıtları yenile
            Baglanti.baglan();
            dtgridgelirgider.DataSource = GelirGider.GelirGiderListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btntarihara_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            //2 Tarih Arası Gelir Gider Arama
            Baglanti.baglan();
            dtgridgelirgider.DataSource = GelirGider.GelirGiderAraTarih(Convert.ToDateTime(dtgiristarih.Value.ToShortDateString()), Convert.ToDateTime(dtcikistarih.Value.ToShortDateString()));
            Baglanti.baglan().Close();
            //Grafikleri aktarma
            TarihGrafikaktar();
            TarihGrafikaktar2();
        }

        private void btndonemara_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            //Gelir-Gider Döneme Göre arama
            Baglanti.baglan();
            dtgridgelirgider.DataSource = GelirGider.GelirGiderAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();

            //Grafiğe Gelir Gider Atama
            donemgrafikaktar();
            donemgrafikaktar2();


        }


    }
}
