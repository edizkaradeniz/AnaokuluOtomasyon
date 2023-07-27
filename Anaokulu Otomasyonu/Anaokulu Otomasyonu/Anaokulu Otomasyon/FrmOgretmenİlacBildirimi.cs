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
    public partial class FrmOgretmenİlacBildirimi : Form
    {
        public FrmOgretmenİlacBildirimi()
        {
            InitializeComponent();
        }
        void temizle()
        {
            cmbadsoyad.Text = "";
            cmbilacictimi.Text = "";
        }
        private void FrmOgretmenİlacBildirimi_Load(object sender, EventArgs e)
        {   //Combobox'a adsoyadları çek
            Baglanti.baglan();
            cmbadsoyad.DataSource = Ogrenci.OgrenciAdsoyadCEK();    
            cmbadsoyad.DisplayMember = "ADSOYAD";
            cmbadsoyad.ValueMember = "OgrID";
            Baglanti.baglan().Close();
           
        }
        static int id;
        private void dtgridİlacBildirimi_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Seçili Satırın Bilgilerini Aktarma
            int row = e.RowIndex;
            id = int.Parse(dtgridİlacBildirimi.Rows[row].Cells[0].Value.ToString());
            cmbadsoyad.Text= dtgridİlacBildirimi.Rows[row].Cells[1].Value.ToString();
            dttarih.Text = dtgridİlacBildirimi.Rows[row].Cells[2].Value.ToString();
            cmbilacictimi.Text = dtgridİlacBildirimi.Rows[row].Cells[3].Value.ToString();
        }

        private void btnilacbildirimiekle_Click(object sender, EventArgs e)
        {   //İlaç Bildirimi Ekle
            Baglanti.baglan();
            İlacBildirim.İlacBildirimEkle((int)cmbadsoyad.SelectedValue, dttarih.Value, cmbilacictimi.GetItemText(cmbilacictimi.SelectedItem));
            Baglanti.baglan().Close();
            temizle();
            //Kayıtları Yenile
            Baglanti.baglan();
            dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void btnilacbildirimguncelle_Click(object sender, EventArgs e)
        {  //İlaç Bildirimi Güncelle
            Baglanti.baglan();
            İlacBildirim.İlacBildirimiGuncelle((int)cmbadsoyad.SelectedValue, dttarih.Value, cmbilacictimi.GetItemText(cmbilacictimi.SelectedItem), id);
            Baglanti.baglan().Close();
            temizle();
            //Kayıtları Yenile
            Baglanti.baglan();
            dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            //İlaç Bildirimi Ara Tarihe Göre
            Baglanti.baglan();
            dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
            dtgridİlacBildirimi.Columns[0].Visible = false;
            dtgridİlacBildirimi.Columns[1].Width = 175;
            dtgridİlacBildirimi.Columns[2].Width = 175;
            dtgridİlacBildirimi.Columns[3].Width = 175;
        }

        private void btnİlacbildirimiSil_Click(object sender, EventArgs e)
        {
            //İlaç Bildirimi Sil
            Baglanti.baglan();
            İlacBildirim.İlacBildirimiSil(id,cmbadsoyad.GetItemText(cmbadsoyad.SelectedItem),dttarih.Value);
            Baglanti.baglan().Close();
            temizle();
            //Silindikten Sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Kayıtları Yenile
            Baglanti.baglan();
            dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }
    }
}
