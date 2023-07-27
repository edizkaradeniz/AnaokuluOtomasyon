using Anaokulu_Otomasyon.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaokulu_Otomasyon
{
    public partial class FrmYemekListesi : Form
    {
        public FrmYemekListesi()
        {
            InitializeComponent();
        }
        void temizle()
        { 
            rchikindi.Text = "";
            rchogle.Text = "";
            rchsabah.Text = "";
            cmbdonem.Text = "";
            cmbdonemara.Text = "";
            
        }
        private void btnyenile_Click(object sender, EventArgs e)
        {    //Datagridview'i  Yenile
            Baglanti.baglan();
            dtgridyemeklistesi.DataSource = YemekListesi.YemekListele();
            Baglanti.baglan().Close();
        }
        static int id;
        private void dtgridyemeklistesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
           id = int.Parse(dtgridyemeklistesi.Rows[row].Cells[0].Value.ToString());
            dttarih.Text = dtgridyemeklistesi.Rows[row].Cells[1].Value.ToString();
            rchsabah.Text = dtgridyemeklistesi.Rows[row].Cells[2].Value.ToString();
            rchogle.Text = dtgridyemeklistesi.Rows[row].Cells[3].Value.ToString();
            rchikindi.Text = dtgridyemeklistesi.Rows[row].Cells[4].Value.ToString();
            cmbdonem.Text = dtgridyemeklistesi.Rows[row].Cells[5].Value.ToString();
        }


        private void btnYemekListesiEkle_Click(object sender, EventArgs e)
        {    //Yemek Listesi Ekle
            Baglanti.baglan();
            YemekListesi.YemekListesiEkle(dttarih.Value, rchsabah.Text, rchogle.Text, rchikindi.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem));
            Baglanti.baglan().Close();
            //Eklendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridyemeklistesi.DataSource = YemekListesi.YemekListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnYemekListesiGuncelle_Click(object sender, EventArgs e)
        {  //Yemek Listesi Güncelle
            Baglanti.baglan();
            YemekListesi.YemekListesiGuncelle(dttarih.Value, rchsabah.Text, rchogle.Text, rchikindi.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem),id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridyemeklistesi.DataSource = YemekListesi.YemekListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnyemeklistesisil_Click(object sender, EventArgs e)
        {
            //Yemek Listesi Sil
            Baglanti.baglan();
            YemekListesi.YemekListesiSil(id,dttarih.Value);
            Baglanti.baglan().Close();
            //Silindikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridyemeklistesi.DataSource = YemekListesi.YemekListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btndonemara_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridyemeklistesi.DataSource = YemekListesi.YemekListesiAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void btntarihara_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridyemeklistesi.DataSource = YemekListesi.YemekListesiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void FrmYemekListesi_Load(object sender, EventArgs e)
        {    //Yemek Listesi Listele
            Baglanti.baglan();
            dtgridyemeklistesi.DataSource = YemekListesi.YemekListele();
            Baglanti.baglan().Close();
            dtgridyemeklistesi.Columns[0].Visible = false;
            dtgridyemeklistesi.Columns[2].Width = 120;
            dtgridyemeklistesi.Columns[3].Width = 121;
            dtgridyemeklistesi.Columns[4].Width = 121;
        }

      
        
    }
}
