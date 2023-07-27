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
    public partial class FrmVeli : Form
    {
        public FrmVeli()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtkulad.Text = "";
            txtsifre.Text = "";
            txtveliadsoyad.Text = "";
            txtyillikfiyat.Text = "";
            msktel.Text = "";
            rchadres.Text = "";
        }
        private void FrmVeli_Load(object sender, EventArgs e)
        {   //Combobox'a Öğrencileri Çekme
            Baglanti.baglan();
            cmbogrenci.DataSource = Ogrenci.OgrenciAdsoyadCEK();   
            cmbogrenci.DisplayMember = "ADSOYAD";
            cmbogrenci.ValueMember = "OgrID";
            Baglanti.baglan().Close();
            //Velileri Listeleme
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliListele();
            Baglanti.baglan().Close();
            dtgridvelilistele.Columns[0].Visible = false;
         //   dtgridvelilistele.Columns[4].Width = 120;
            dtgridvelilistele.Columns[5].Width = 75;
            dtgridvelilistele.Columns[6].Width = 50;
            dtgridvelilistele.Columns[7].Width = 65;
        }
        private void btnveliekle_Click(object sender, EventArgs e)
        {     //Veli Ekleme
            if (txtveliadsoyad.Text == "" || txtyillikfiyat.Text == "" || txtkulad.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Veli Bilgilerini Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Baglanti.baglan();
                Veli.Veliekle(txtveliadsoyad.Text, (int)cmbogrenci.SelectedValue, msktel.Text, rchadres.Text, txtkulad.Text, txtsifre.Text, int.Parse(txtyillikfiyat.Text), cmbdonemi.GetItemText(cmbdonemi.SelectedItem));
                Baglanti.baglan().Close();
                //Eklendikten sonra datagridview yenile
                Baglanti.baglan();
                dtgridvelilistele.DataSource = Veli.VeliListele();
                Baglanti.baglan().Close();
            }
            temizle();
        }
        static int id;
        private void dtgridvelilistele_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Tıklanan satırın bilgilerini textboxlara aktarma
            int row = int.Parse(e.RowIndex.ToString());
             id= int.Parse(dtgridvelilistele.Rows[row].Cells[0].Value.ToString());
            txtveliadsoyad.Text = dtgridvelilistele.Rows[row].Cells[1].Value.ToString();
            cmbogrenci.Text = dtgridvelilistele.Rows[row].Cells[2].Value.ToString();
            msktel.Text = dtgridvelilistele.Rows[row].Cells[3].Value.ToString();
            rchadres.Text = dtgridvelilistele.Rows[row].Cells[4].Value.ToString();
            txtkulad.Text = dtgridvelilistele.Rows[row].Cells[5].Value.ToString();
            txtsifre.Text = dtgridvelilistele.Rows[row].Cells[6].Value.ToString();
            txtyillikfiyat.Text = dtgridvelilistele.Rows[row].Cells[7].Value.ToString();
            cmbdonemi.Text = dtgridvelilistele.Rows[row].Cells[8].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {   //Veli Güncelleme
            Baglanti.baglan();
            Veli.VeliGuncelle(txtveliadsoyad.Text, (int)cmbogrenci.SelectedValue, msktel.Text, rchadres.Text, txtkulad.Text, txtsifre.Text, int.Parse(txtyillikfiyat.Text), cmbdonemi.GetItemText(cmbdonemi.SelectedItem), id);
            Baglanti.baglan().Close();
            //Güncellenen veriyi listeme
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            //Datagridview'i Yenileme
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliListele();
            Baglanti.baglan().Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {     //Döneme Göre Veli Arama
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliAra(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void btnveliSil_Click(object sender, EventArgs e)
        {    //Veli Silme
            Baglanti.baglan();
            Veli.VeliSil(id,txtveliadsoyad.Text);
            Baglanti.baglan().Close();
            //Datagridview'i Refresh etme
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void txtveliara_TextChanged(object sender, EventArgs e)
        {   //Ada göre veli ara
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliAraAD(txtveliara.Text);
            Baglanti.baglan().Close();
        }
    }
}
