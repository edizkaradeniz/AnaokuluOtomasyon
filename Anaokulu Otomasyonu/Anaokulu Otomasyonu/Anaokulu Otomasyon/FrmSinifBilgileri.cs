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
    public partial class FrmSinifBilgileri : Form
    {
        public FrmSinifBilgileri()
        {
            InitializeComponent();
        }
        //Formdaki textboxları temizleme
        void temizle()
        {
            txtkontenjan.Text = "";
            txtsinifadi.Text = "";
        }
        private void FrmSinifBilgileri_Load(object sender, EventArgs e)
        {   //Form Yüklendiğinde Comboboxlara Öğretmen ADSOYADI çekme
            Baglanti.baglan();
            cmbogretmen.DataSource = Ogretmen.OgretmenAdSoyadGetir();
            cmbogretmen.ValueMember = "OgretmenID";
            cmbogretmen.DisplayMember = "ADSOYAD";
            Baglanti.baglan().Close();
            //Form Yüklendiğinde Siniflari Listele
            Baglanti.baglan();
            dtgsinif.DataSource = Sinif.SinifListele();
            Baglanti.baglan().Close();
            dtgsinif.Columns[0].Visible = false;
            dtgsinif.Columns[1].Width = 120;
            dtgsinif.Columns[2].Width = 120;
            dtgsinif.Columns[3].Width = 167;
        }
        static int id;
        private void dtgsinif_CellClick(object sender, DataGridViewCellEventArgs e)
        {    //Seçili satırın bilgilerini textbox'a aktarma
            int row = int.Parse(e.RowIndex.ToString());
            id = int.Parse(dtgsinif.Rows[row].Cells[0].Value.ToString());
            txtsinifadi.Text = dtgsinif.Rows[row].Cells[1].Value.ToString();
            txtkontenjan.Text = dtgsinif.Rows[row].Cells[2].Value.ToString();
            cmbdonem.Text = dtgsinif.Rows[row].Cells[3].Value.ToString();
            cmbogretmen.Text = dtgsinif.Rows[row].Cells[4].Value.ToString();
        }

        private void btnsinifekle_Click(object sender, EventArgs e)
        {   //Sinif Ekle
            Baglanti.baglan();
            Sinif.Sinifekle(txtsinifadi.Text, int.Parse(txtkontenjan.Text), cmbdonem.GetItemText(cmbdonem.SelectedItem), (int)cmbogretmen.SelectedValue);
            Baglanti.baglan().Close();
            //Eklendikten sonra Datagridview'i yenile
            Baglanti.baglan();
            dtgsinif.DataSource = Sinif.SinifListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnsinifguncelle_Click(object sender, EventArgs e)
        {   //Sinif Bilgilerini Guncelleme
            Baglanti.baglan();
            Sinif.Guncelle(txtsinifadi.Text, int.Parse(txtkontenjan.Text),
            cmbdonem.GetItemText(cmbdonem.SelectedItem), (int)cmbogretmen.SelectedValue, id);
            //Datagridview'i Yenile
            Baglanti.baglan();
            dtgsinif.DataSource = Sinif.SinifListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnsinifsil_Click(object sender, EventArgs e)
        {  //Sinif Sil
            Baglanti.baglan();
            Sinif.SinifSil(id, txtsinifadi.Text);
            Baglanti.baglan().Close();
            //Sildikten sonra kayıtları yenile
            Baglanti.baglan();
            dtgsinif.DataSource = Sinif.SinifListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnara_Click(object sender, EventArgs e)
        {  //Döneme Göre Sinif Arama
            Baglanti.baglan();
            dtgsinif.DataSource = Sinif.SinifAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Datatgridview'i Yenile
            Baglanti.baglan();
            dtgsinif.DataSource = Sinif.SinifListele();
            Baglanti.baglan().Close();
        }

        private void txtsinifadiara_TextChanged(object sender, EventArgs e)
        {   //Sinif Adina Göre Arama 
            Baglanti.baglan();
            dtgsinif.DataSource = Sinif.SinifAra(txtsinifadiara.Text);
            Baglanti.baglan().Close();
        }
    }
}
