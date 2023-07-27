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
    public partial class FrmOgretmenYoklama : Form
    {
        public FrmOgretmenYoklama()
        {
            InitializeComponent();
        }
        void temizle()
        {
            cmbadsoyad.Text = "";
            cmbokul.Text = "";
        }
        static int id;
        private void dtgridyoklama_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Tıklanan Satırın Bilgisini Aktarma
            int row = e.RowIndex;
            id = int.Parse(dtgridyoklama.Rows[row].Cells[0].Value.ToString());
            cmbadsoyad.Text= dtgridyoklama.Rows[row].Cells[1].Value.ToString();
            dttarih.Text= dtgridyoklama.Rows[row].Cells[2].Value.ToString();
            cmbokul.Text= dtgridyoklama.Rows[row].Cells[3].Value.ToString();
        }

        private void FrmOgretmenYoklama_Load(object sender, EventArgs e)
        {  //Combobox'a Öğrencileri Çekme
            Baglanti.baglan();
            cmbadsoyad.DataSource = Ogrenci.OgrenciAdsoyadCEK();
            cmbadsoyad.DisplayMember = "ADSOYAD";
            cmbadsoyad.ValueMember = "OgrID";
            Baglanti.baglan().Close();
        }

        private void btnyoklamaekle_Click(object sender, EventArgs e)
        {   //Yoklama Ekle
            Baglanti.baglan();
            Yoklama.YoklamaEkle((int)cmbadsoyad.SelectedValue, dttarih.Value, cmbokul.GetItemText(cmbokul.SelectedItem));
            Baglanti.baglan().Close();
            //Eklendikten sonra yenile
            Baglanti.baglan();
            dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnyoklamaguncelle_Click(object sender, EventArgs e)
        {  //Yoklama Güncelle
            Baglanti.baglan();
            Yoklama.YoklamaGuncelle((int)cmbadsoyad.SelectedValue, dttarih.Value, cmbokul.GetItemText(cmbokul.SelectedItem),id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra yenile
            Baglanti.baglan();
            dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnyoklamasil_Click(object sender, EventArgs e)
        {  //Yoklama Sil
            Baglanti.baglan();
            Yoklama.YoklamaSil(id,cmbadsoyad.GetItemText(cmbadsoyad.SelectedItem),dttarih.Value);
            Baglanti.baglan().Close();
            //Silindikten sonra yenile 
            Baglanti.baglan();
            dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
            temizle(); 
        }

        private void btnara_Click(object sender, EventArgs e)
        {   //Tarihe Göre Yoklama Ara
            Baglanti.baglan();
            dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
            dtgridyoklama.Columns[0].Visible = false;
            dtgridyoklama.Columns[1].Width = 167;
            dtgridyoklama.Columns[2].Width = 167;
            dtgridyoklama.Columns[3].Width = 167;
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Kayıtları Yenile
            Baglanti.baglan();
            dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }
    }
}
