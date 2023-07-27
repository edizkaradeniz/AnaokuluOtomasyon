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
namespace Anaokulu_Otomasyon
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtOgretmenAd.Text = "";
            txtogretmenkulad.Text = "";
            txtogretmenmaas.Text = "";    
            txtogretmensifre.Text = "";
            txtogretmenTc.Text = "";
            mskogretmentel.Text = "";
            rchogretmenadres.Text = "";
        }

        private void btnogretmenekle_Click(object sender, EventArgs e)
        {
            if (txtogretmenkulad.Text == "" || txtogretmenmaas.Text == "" || txtOgretmenAd.Text == "" || txtogretmensifre.Text == "" || txtogretmenTc.Text=="")
            {
                MessageBox.Show("Öğretmen Bilgilerini Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {   //Öğretmen Ekle
                Baglanti.baglan();
                Ogretmen.OgretmenEkle(txtOgretmenAd.Text, txtogretmenTc.Text, dtOgretmen.Value, rchogretmenadres.Text, int.Parse(txtogretmenmaas.Text), mskogretmentel.Text, txtogretmenkulad.Text, txtogretmensifre.Text);
                Baglanti.baglan().Close();
                //Eklendikten sonra listele
                Baglanti.baglan();
               dtgridogretmenlistele.DataSource=Ogretmen.OgretmenListele();
                Baglanti.baglan().Close();

            }
            Temizle();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        { 
            //Form Yüklendiğinde Öğretmenleri listele
            Baglanti.baglan();
          dtgridogretmenlistele.DataSource=Ogretmen.OgretmenListele();
            Baglanti.baglan().Close();
            dtgridogretmenlistele.Columns[0].Visible = false;
            dtgridogretmenlistele.Columns[2].Width = 75;
            dtgridogretmenlistele.Columns[3].Width = 78;
            dtgridogretmenlistele.Columns[5].Width = 60;
            dtgridogretmenlistele.Columns[6].Width = 75;
            dtgridogretmenlistele.Columns[7].Width = 75;
            dtgridogretmenlistele.Columns[8].Width = 68;
        }
        static int id;
        private void dtgridogretmenlistele_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Tıklanan satır bilgisini textboxlara aktarma
            int row = int.Parse(e.RowIndex.ToString());
            id = int.Parse(dtgridogretmenlistele.Rows[row].Cells[0].Value.ToString());
            txtOgretmenAd.Text= dtgridogretmenlistele.Rows[row].Cells[1].Value.ToString();
            txtogretmenTc.Text= dtgridogretmenlistele.Rows[row].Cells[2].Value.ToString();
            dtOgretmen.Text= dtgridogretmenlistele.Rows[row].Cells[3].Value.ToString();
            rchogretmenadres.Text= dtgridogretmenlistele.Rows[row].Cells[4].Value.ToString();
            txtogretmenmaas.Text= dtgridogretmenlistele.Rows[row].Cells[5].Value.ToString();
            mskogretmentel.Text= dtgridogretmenlistele.Rows[row].Cells[6].Value.ToString();
            txtogretmenkulad.Text= dtgridogretmenlistele.Rows[row].Cells[7].Value.ToString();
            txtogretmensifre.Text= dtgridogretmenlistele.Rows[row].Cells[8].Value.ToString();
        }

        private void btnogretmenguncelle_Click(object sender, EventArgs e)
        {   //Öğretmen Güncelle
            Baglanti.baglan();
            Ogretmen.OgretmenGuncelle(txtOgretmenAd.Text, txtogretmenTc.Text, dtOgretmen.Value, rchogretmenadres.Text, int.Parse(txtogretmenmaas.Text), mskogretmentel.Text, txtogretmenkulad.Text, txtogretmensifre.Text,id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra datagridview'i yenile
            Baglanti.baglan();
            dtgridogretmenlistele.DataSource = Ogretmen.OgretmenListele();
            Baglanti.baglan().Close();
            Temizle();
        }

        private void btnogretmensil_Click(object sender, EventArgs e)
        {   //Öğretmen Sil
            Baglanti.baglan();
            Ogretmen.OgretmenSil(id,txtOgretmenAd.Text);
            Baglanti.baglan().Close();
            //Öğretmen Silindikten sonra Kayıtları yenileme
            Baglanti.baglan();
            dtgridogretmenlistele.DataSource = Ogretmen.OgretmenListele();
            Baglanti.baglan().Close();
            Temizle();
        }

 

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Datagridview'i Yenile
            Baglanti.baglan();
            dtgridogretmenlistele.DataSource = Ogretmen.OgretmenListele();
            Baglanti.baglan().Close();
        }

        private void txtogretmenara_TextChanged(object sender, EventArgs e)
        {   //Ada göre öğretmen ara
            Baglanti.baglan();
            dtgridogretmenlistele.DataSource = Ogretmen.OgretmenAra(txtogretmenara.Text);
            Baglanti.baglan().Close();
        }
    }
}
