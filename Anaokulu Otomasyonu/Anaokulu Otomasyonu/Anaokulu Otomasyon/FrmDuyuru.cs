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
    public partial class FrmDuyuru : Form
    {
        public FrmDuyuru()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtbaslik.Text = "";
            rchicerik.Text = "";
            cmbdonem.Text = "";
            cmbdonemara.Text = "";
            
        }

        private void btnduyuruekle_Click(object sender, EventArgs e)
        {   //Duyuru Ekle
            Baglanti.baglan(); 
            Duyuru.DuyuruEkle(dttarih.Value,txtbaslik.Text,rchicerik.Text,cmbdonem.GetItemText(cmbdonem.SelectedItem));
            Baglanti.baglan().Close();
            //Eklendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridduyurulistele.DataSource = Duyuru.DuyuruListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void FrmDuyuru_Load(object sender, EventArgs e)
        {
            //Duyuru Listele
            Baglanti.baglan();
            dtgridduyurulistele.DataSource = Duyuru.DuyuruListele();
            Baglanti.baglan().Close();
            dtgridduyurulistele.Columns[0].Visible = false;
            dtgridduyurulistele.Columns[3].Width = 224;
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Kayitları Yenile
            Baglanti.baglan();
            dtgridduyurulistele.DataSource = Duyuru.DuyuruListele();
            Baglanti.baglan().Close();
        }
        static int id;
        private void dtgridduyurulistele_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Seçili satırın bilgisini textboxlara aktarma
            int row = e.RowIndex;
            id = int.Parse(dtgridduyurulistele.Rows[row].Cells[0].Value.ToString());
            dttarih.Text= dtgridduyurulistele.Rows[row].Cells[1].Value.ToString();
            txtbaslik.Text= dtgridduyurulistele.Rows[row].Cells[2].Value.ToString();
            rchicerik.Text= dtgridduyurulistele.Rows[row].Cells[3].Value.ToString();
            cmbdonem.Text= dtgridduyurulistele.Rows[row].Cells[4].Value.ToString();
        }

        private void btnduyuruguncelle_Click(object sender, EventArgs e)
        {   //Duyuru Güncelle
            Baglanti.baglan();
            Duyuru.DuyuruGuncelle(dttarih.Value, txtbaslik.Text, rchicerik.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem), id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra kayıtları yenileme
            Baglanti.baglan();
            dtgridduyurulistele.DataSource = Duyuru.DuyuruListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnduyurusil_Click(object sender, EventArgs e)
        {   //Duyuru Sil
            Baglanti.baglan();
            Duyuru.DuyuruSil(id,dttarih.Value);
            Baglanti.baglan().Close();
            //Silindikten Sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridduyurulistele.DataSource = Duyuru.DuyuruListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnTarihara_Click(object sender, EventArgs e)
        {   //Tarihe Göre Duyuru Ara
            Baglanti.baglan();
            dtgridduyurulistele.DataSource = Duyuru.DuyuruAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void btndonemara_Click(object sender, EventArgs e)
        {
            //Döneme Göre Duyuru Ara
            Baglanti.baglan();
            dtgridduyurulistele.DataSource = Duyuru.DuyuruAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }
    }
}
