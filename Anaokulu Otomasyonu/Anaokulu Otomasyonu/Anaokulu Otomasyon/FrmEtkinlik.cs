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
    public partial class FrmEtkinlik : Form
    {
        public FrmEtkinlik()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtbaslik.Text = "";
            cmbdonem.Text = "";
            rchbilgi.Text = "";
            cmbdonemara.Text = "";
        }
        private void FrmEtkinlik_Load(object sender, EventArgs e)
        {    //Etkinlikleri Listele
            Baglanti.baglan();
            dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele();
            Baglanti.baglan().Close();
            dtgridetkinliklistele.Columns[0].Visible = false;
            dtgridetkinliklistele.Columns[2].Width = 125;
            dtgridetkinliklistele.Columns[3].Width = 189;
        }
        static int id;
        private void dtgridetkinliklistele_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Seçili satırın bilgisini textboxlara aktarma
            int row = e.RowIndex;
           id = int.Parse(dtgridetkinliklistele.Rows[row].Cells[0].Value.ToString());
            dttarih.Text = dtgridetkinliklistele.Rows[row].Cells[1].Value.ToString();
            txtbaslik.Text = dtgridetkinliklistele.Rows[row].Cells[2].Value.ToString();
            rchbilgi.Text = dtgridetkinliklistele.Rows[row].Cells[3].Value.ToString();
            cmbdonem.Text = dtgridetkinliklistele.Rows[row].Cells[4].Value.ToString();
        }
        private void btnetkinlikekle_Click(object sender, EventArgs e)
        {  //Etkinlik Ekle
            Baglanti.baglan();
            Etkinlik.EtkinlikEkle(dttarih.Value, txtbaslik.Text, rchbilgi.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem));
            Baglanti.baglan().Close();
            //Eklendikten sonra kayıtları yenile
            Baglanti.baglan();
            dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnetkinlikguncelle_Click(object sender, EventArgs e)
        {   //Etkinlik Güncelle
            Baglanti.baglan();
            Etkinlik.EtkinlikGuncelle(dttarih.Value, txtbaslik.Text, rchbilgi.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem),id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnEtkinlikSil_Click(object sender, EventArgs e)
        {   //Etkinlik Sil
            Baglanti.baglan();
            Etkinlik.EtkinlikSil(id,dttarih.Value);
            Baglanti.baglan().Close();
            //Silindikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btntarihara_Click(object sender, EventArgs e)
        {   //Tarihe göre etkinlik arama
            Baglanti.baglan();
            dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void btndonemara_Click(object sender, EventArgs e)
        {    //Döneme göre etkinlik arama
            Baglanti.baglan();
            dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

       
    }
}
