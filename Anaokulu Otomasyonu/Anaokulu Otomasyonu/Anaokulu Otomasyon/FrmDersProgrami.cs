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
using System.Data.SqlClient;
namespace Anaokulu_Otomasyon
{
    public partial class FrmDersProgrami : Form
    {
        public FrmDersProgrami()
        {
            InitializeComponent();
        }

        void temizle()
        {
            cmbders1.Text = "";
            cmbders2.Text = "";
            cmbders3.Text = "";
            cmbders4.Text = "";
            cmbders5.Text = "";
            cmbders6.Text = "";
            cmbdonem.Text = "";
            cmbdonemara.Text = "";
        }

        private void FrmDersProgrami_Load(object sender, EventArgs e)
        {   //Ders Programi Listele
            Baglanti.baglan();
            dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele();
            Baglanti.baglan().Close();
            //Comboboxlara'a Ders Adlarini Cek
            string sqlcumle = "Select DersAdi from Ders where Durumu='1' ";
            SqlCommand cmd = new SqlCommand(sqlcumle, Baglanti.baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbders1.Items.Add(dr["DersAdi"]);
                cmbders2.Items.Add(dr["DersAdi"]);
                cmbders3.Items.Add(dr["DersAdi"]);
                cmbders4.Items.Add(dr["DersAdi"]);
                cmbders5.Items.Add(dr["DersAdi"]);
                cmbders6.Items.Add(dr["DersAdi"]);
            }
            dtgridDersprogrami.Columns[0].Visible = false;
        }
        static int id;
        private void dtgridDersprogrami_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Tıklanan Satırın Bilgilerini textbox,comboboxlara aktarma
            int row = e.RowIndex;
            id = int.Parse(dtgridDersprogrami.Rows[row].Cells[0].Value.ToString());
            cmbders1.Text = dtgridDersprogrami.Rows[row].Cells[1].Value.ToString();
            cmbders2.Text = dtgridDersprogrami.Rows[row].Cells[2].Value.ToString();
            cmbders3.Text = dtgridDersprogrami.Rows[row].Cells[3].Value.ToString();
            cmbders4.Text = dtgridDersprogrami.Rows[row].Cells[4].Value.ToString();
            cmbders5.Text = dtgridDersprogrami.Rows[row].Cells[5].Value.ToString();
            cmbders6.Text = dtgridDersprogrami.Rows[row].Cells[6].Value.ToString();
            cmbdonem.Text = dtgridDersprogrami.Rows[row].Cells[7].Value.ToString();
            dttarih.Text = dtgridDersprogrami.Rows[row].Cells[8].Value.ToString();
        }

        private void btnDersprogramiEkle_Click(object sender, EventArgs e)
        {   //Ders Programi Ekle
            Baglanti.baglan();
            DersProgrami.DersprogramiEkle(cmbders1.GetItemText(cmbders1.SelectedItem), cmbders2.GetItemText(cmbders2.SelectedItem), cmbders3.GetItemText(cmbders3.SelectedItem), cmbders4.GetItemText(cmbders4.SelectedItem), cmbders5.GetItemText(cmbders5.SelectedItem), cmbders6.GetItemText(cmbders6.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem), dttarih.Value);
            Baglanti.baglan().Close();
            //Ders Programi Eklendikten sonra kayıtları yenile
            Baglanti.baglan();
            dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnDersProgramiGuncelle_Click(object sender, EventArgs e)
        {   //Ders programi Guncelle
            Baglanti.baglan();
            DersProgrami.DersprogramiGuncelle(cmbders1.GetItemText(cmbders1.SelectedItem), cmbders2.GetItemText(cmbders2.SelectedItem), cmbders3.GetItemText(cmbders3.SelectedItem), cmbders4.GetItemText(cmbders4.SelectedItem), cmbders5.GetItemText(cmbders5.SelectedItem), cmbders6.GetItemText(cmbders6.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem), dttarih.Value, id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra Kayıtları yenile
            Baglanti.baglan();
            dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btndersprogramiSil_Click(object sender, EventArgs e)
        {   //Dersprogrami Sil

            Baglanti.baglan();
            DersProgrami.DersProgramiSil(id, dttarih.Value);
            Baglanti.baglan().Close();
            //Silindikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btntarihara_Click(object sender, EventArgs e)
        {   //Tarihe Göre Ders Programi Ara
            Baglanti.baglan();
            dtgridDersprogrami.DataSource = DersProgrami.DersprogramiAraTarih(Convert.ToDateTime(dtTarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void btndonemara_Click(object sender, EventArgs e)
        {   //Döneme Göre Ders Programi ARA
            Baglanti.baglan();
            dtgridDersprogrami.DataSource = DersProgrami.DersProgramiAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            //DataGridview Yenile
            Baglanti.baglan();
            dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele();
            Baglanti.baglan().Close();
        }
    }
}
