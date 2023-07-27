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
    public partial class FrmOgretmenYemekBildirimi : Form
    {
        public FrmOgretmenYemekBildirimi()
        {
            InitializeComponent();
        }
        void temizle()
        {
            cmbyemekyedimi.Text = "";
            cmbadsoyad.Text = "";
        }
        private void btnyemekbildirimiekle_Click(object sender, EventArgs e)
        {   //Yemek Bildirimi Ekle
            Baglanti.baglan();
            YemekBildirimi.YemekBildirimEkle((int)cmbadsoyad.SelectedValue, dttarih.Value, cmbyemekyedimi.GetItemText(cmbyemekyedimi.SelectedItem));
            Baglanti.baglan().Close();
            temizle();

        }

        private void FrmOgretmenYemekBildirimi_Load(object sender, EventArgs e)
        {   //Comboboxlara Öğrencileri Çek
            Baglanti.baglan();
            cmbadsoyad.DataSource = Ogrenci.OgrenciAdsoyadCEK();
            cmbadsoyad.DisplayMember = "ADSOYAD";
            cmbadsoyad.ValueMember = "OgrID";
            Baglanti.baglan().Close();
            
        }

        private void btnara_Click(object sender, EventArgs e)
        {   //Tarihe Göre Arama
            Baglanti.baglan();
            dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
            dtgridyemekbildirim.Columns[0].Visible = false;
            dtgridyemekbildirim.Columns[1].Width = 181;
            dtgridyemekbildirim.Columns[2].Width = 181;
            dtgridyemekbildirim.Columns[3].Width = 182;
        }
        static int id;
        private void dtgridyemekbildirim_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Seçili Satırın Bilgisini aktarma
            int row = e.RowIndex;
            id = int.Parse(dtgridyemekbildirim.Rows[row].Cells[0].Value.ToString());
            cmbadsoyad.Text = dtgridyemekbildirim.Rows[row].Cells[1].Value.ToString();
            dttarih.Text = dtgridyemekbildirim.Rows[row].Cells[2].Value.ToString();
            cmbyemekyedimi.Text = dtgridyemekbildirim.Rows[row].Cells[3].Value.ToString();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Kayıtları Yenile
            Baglanti.baglan();
            dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void btnyemekbildirimsil_Click(object sender, EventArgs e)
        {   //YemekBildirimiSil
            Baglanti.baglan();
            YemekBildirimi.YemekBildirimSil(id,cmbadsoyad.GetItemText(cmbadsoyad.SelectedItem),dttarih.Value);
            Baglanti.baglan().Close();
            temizle();
            //Silindikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void btnyemekbildirimguncelle_Click(object sender, EventArgs e)
        {  //Yemek Bildirimi Güncelle
            Baglanti.baglan();
            YemekBildirimi.YemekBildirimGuncelle((int)cmbadsoyad.SelectedValue, dttarih.Value, cmbyemekyedimi.GetItemText(cmbyemekyedimi.SelectedItem), id);
            Baglanti.baglan();
            temizle();
            //Güncellendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();

        }
    }
}
