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

using Anaokulu_Otomasyon.Siniflar;
namespace Anaokulu_Otomasyon
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtOgrAd.Text = "";
            txtograra.Text = "";
            txtOgrTC.Text = "";
            cmbcins.Text = "";
            cmbdonem.Text = "";
        }
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            //Combobox'a Veritabanındaki Sınıfları Çekme
            Baglanti.baglan();
            cmbsinif.DataSource = Sinif.comboboxsiniflarigetir();
            cmbsinif.DisplayMember = "Adi";
            cmbsinif.ValueMember = "SınıfID";
            Baglanti.baglan().Close();
            //Form-Load Oldugunda Tüm Öğrencileri Listeleme
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Listele();
            Baglanti.baglan().Close();
            dtgridogrlistele.Columns[0].Visible = false;
            dtgridogrlistele.Columns[2].Width = 92;
            dtgridogrlistele.Columns[3].Width = 75;
            dtgridogrlistele.Columns[4].Width = 75;
            dtgridogrlistele.Columns[5].Width = 75;
            dtgridogrlistele.Columns[6].Width = 75;
        }

        private void btnogrekle_Click(object sender, EventArgs e)
        {   //Öğrenci Ekleme
            if (txtOgrAd.Text == "" || txtOgrTC.Text == "" || cmbdonem.GetItemText(cmbdonem.SelectedItem) == "" || cmbcins.GetItemText(cmbcins.SelectedItem) == "")
            {
                MessageBox.Show("Öğrenci Bilgilerini Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                Baglanti.baglan();
                Ogrenci.OgrenciEkle(txtOgrAd.Text, txtOgrTC.Text, dtOgr.Value, cmbcins.SelectedItem.ToString(), int.Parse(cmbsinif.SelectedValue.ToString()), dtkayit.Value, cmbdonem.SelectedItem.ToString());
                Baglanti.baglan().Close();
            }
            //Ekleme Yapıldıktan sonra Kayıtları Yenileme
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Listele();
            Baglanti.baglan().Close();
            temizle();
        }
        static int id = 0;
        private void dtgridogrlistele_CellClick(object sender, DataGridViewCellEventArgs e)
        { //Seçili satırın bilgilerini textbox,combobox,datetimepickerlara aktarma
            int rowindex = int.Parse(e.RowIndex.ToString());
            id = int.Parse(dtgridogrlistele.Rows[rowindex].Cells[0].Value.ToString());
            txtOgrAd.Text = dtgridogrlistele.Rows[rowindex].Cells[1].Value.ToString();
            txtOgrTC.Text = dtgridogrlistele.Rows[rowindex].Cells[2].Value.ToString();
            dtOgr.Text = dtgridogrlistele.Rows[rowindex].Cells[3].Value.ToString();
            cmbcins.Text = dtgridogrlistele.Rows[rowindex].Cells[4].Value.ToString();
            cmbsinif.Text = dtgridogrlistele.Rows[rowindex].Cells[5].Value.ToString();
            dtkayit.Text = dtgridogrlistele.Rows[rowindex].Cells[6].Value.ToString();
            cmbdonem.Text = dtgridogrlistele.Rows[rowindex].Cells[7].Value.ToString();
        }

        private void btnogrguncelle_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerini Güncelle
            Baglanti.baglan();
            Ogrenci.OgrenciGuncelle(txtOgrAd.Text, txtOgrTC.Text, dtOgr.Value, cmbcins.GetItemText(cmbcins.SelectedItem), (int)cmbsinif.SelectedValue, dtkayit.Value, cmbdonem.GetItemText(cmbdonem.SelectedItem), id);
            Baglanti.baglan().Close();
            //Güncellenen Öğrenci bilgilerini Datagridviewde Gösterme(Yenileme)
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Listele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnara_Click(object sender, EventArgs e)
        {   //Öğrenci Arana Döneme Göre
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Arama(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void txtograra_TextChanged(object sender, EventArgs e)
        {   //Öğrenci Arama Textboxtan
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Textboxara(txtograra.Text);
            Baglanti.baglan().Close();
        }

        private void btnogrencisil_Click(object sender, EventArgs e)
        {   //Sistemden Öğrenci Silme(Update sorgusuyla)
            Baglanti.baglan();
            Ogrenci.OgrenciSil(id, txtOgrAd.Text);
            Baglanti.baglan().Close();
            //Sildikten sonra Kayıtları yenileme
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Listele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Kayitlari Refresh
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Listele();
            Baglanti.baglan().Close();
        }
    }
}
