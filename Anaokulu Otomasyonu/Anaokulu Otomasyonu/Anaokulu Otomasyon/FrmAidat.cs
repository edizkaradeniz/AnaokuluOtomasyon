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
    public partial class FrmAidat : Form
    {
        public FrmAidat()
        {
            InitializeComponent();
        }
        void temizle()
        {
            cmbdonem.Text = "";
            cmbdonemara.Text = "";
            cmbodemeturu.Text = "";
            txttutar.Text = "";
            txtveliara.Text = "";
        }
        private void FrmAidat_Load(object sender, EventArgs e)
        {   //Aidatları Listele
            Baglanti.baglan();
            dtgridaidat.DataSource = Aidat.AidatListele();
            Baglanti.baglan().Close();
            //Velileri Comboboxlara çekme
            Baglanti.baglan();
            cmbveli.DataSource = Veli.ComboboxVeliADSOYADcek();
            cmbveli.DisplayMember = "ADSOYAD";
            cmbveli.ValueMember = "VeliID";
           Baglanti.baglan().Close();
            cmbgelir.Text = "Gelir";
            cmbgelirturu.Text = "Veli Ödemesi";
            dtgridaidat.Columns[0].Visible = false;
            dtgridaidat.Columns[1].Width = 134;
            dtgridaidat.Columns[2].Width = 134;
            dtgridaidat.Columns[3].Width = 134;
            dtgridaidat.Columns[4].Width = 134;
        }

        private void btnaidatekle_Click(object sender, EventArgs e)
        {   //Aidat Ekleme
            Baglanti.baglan();
            Aidat.AidatEkle((int)cmbveli.SelectedValue, dttarih.Value, int.Parse(txttutar.Text), cmbodemeturu.GetItemText(cmbodemeturu.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem));
            Baglanti.baglan().Close();
            //Eklenen Aidatı Gelir-Gider Tablosuna Ekleme
            Baglanti.baglan();
            GelirGider.GelirGiderEkle(cmbgelir.GetItemText(cmbgelir.SelectedItem), dttarih.Value, int.Parse(txttutar.Text), cmbgelirturu.GetItemText(cmbgelirturu.SelectedItem), cmbodemeturu.GetItemText(cmbodemeturu.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem));
            MessageBox.Show("Gelir Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Baglanti.baglan().Close();
            //Eklendikten sonra Kayıtları yenile
            Baglanti.baglan();
            dtgridaidat.DataSource = Aidat.AidatListele();
            Baglanti.baglan().Close();
            temizle();
        }
        static int id;
        private void dtgridaidat_CellClick(object sender, DataGridViewCellEventArgs e)
        {    //Satırın bilgilerini textbox combobox aktarma
            int row = e.RowIndex;
            id = int.Parse(dtgridaidat.Rows[row].Cells[0].Value.ToString());
            cmbveli.Text = dtgridaidat.Rows[row].Cells[1].Value.ToString();
            dttarih.Text= dtgridaidat.Rows[row].Cells[2].Value.ToString();
            txttutar.Text= dtgridaidat.Rows[row].Cells[3].Value.ToString();
            cmbodemeturu.Text= dtgridaidat.Rows[row].Cells[4].Value.ToString();
            cmbdonem.Text = dtgridaidat.Rows[row].Cells[5].Value.ToString();

        }

        private void btnaidatguncelle_Click(object sender, EventArgs e)
        {   //Aidat Güncelle
            Baglanti.baglan();
            Aidat.AidatGuncelle((int)cmbveli.SelectedValue, dttarih.Value, int.Parse(txttutar.Text), cmbodemeturu.GetItemText(cmbodemeturu.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem),id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra Kayıtları yenile
            Baglanti.baglan();
            dtgridaidat.DataSource = Aidat.AidatListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnaidatsil_Click(object sender, EventArgs e)
        {   //Aidat Sil
            Baglanti.baglan();
            Aidat.AidatSil(id,cmbveli.GetItemText(cmbveli.SelectedItem),dttarih.Value);
            Baglanti.baglan().Close();
            //Silindikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridaidat.DataSource = Aidat.AidatListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btndonemara_Click(object sender, EventArgs e)
        {   //Döneme Göre Aidat Arama
            Baglanti.baglan();
            dtgridaidat.DataSource = Aidat.AidatAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void btntarihara_Click(object sender, EventArgs e)
        {   //Tarihe Göre Aidat Arama
            Baglanti.baglan();
            dtgridaidat.DataSource = Aidat.AidatAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void txtveliara_TextChanged(object sender, EventArgs e)
        {   //Aidat Ara veli ADSOYAD
            Baglanti.baglan();
            dtgridaidat.DataSource = Aidat.AidatAraVeli(txtveliara.Text);
            Baglanti.baglan().Close();
        }

        
    }
}
