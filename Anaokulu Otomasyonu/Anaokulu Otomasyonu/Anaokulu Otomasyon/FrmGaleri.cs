using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anaokulu_Otomasyon.Siniflar;
using System.Windows.Forms;

namespace Anaokulu_Otomasyon
{
    public partial class FrmGaleri : Form
    {
        public FrmGaleri()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtResimAdi.Text = "";
            txtresimyolu.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            // pctresim.ImageLocation = openFileDialog1.FileName;
            txtresimyolu.Text = openFileDialog1.FileName;
        }

        private void FrmGaleri_Load(object sender, EventArgs e)
        {  //Resimleri Listele
            Baglanti.baglan();
            dtgridresim.DataSource = Galeri.ResimListele();
            Baglanti.baglan().Close();
            dtgridresim.Columns[0].Visible = false;
            dtgridresim.Columns[1].Width = 165;
            dtgridresim.Columns[2].Width = 165;
            dtgridresim.Columns[3].Width = 150;
           
        }



        private void btnresimekle_Click(object sender, EventArgs e)
        {  //Resim Ekle
            Baglanti.baglan();
            Galeri.Resimekle(txtResimAdi.Text, dttarih.Value, txtresimyolu.Text);
            Baglanti.baglan().Close();
            //Resim Eklendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridresim.DataSource = Galeri.ResimListele();
            Baglanti.baglan().Close();
            temizle();
        }
        static int id;
        private void dtgridresim_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Satırın bilgisini textboxlara aktarma
            int row = e.RowIndex;
            id = int.Parse(dtgridresim.Rows[row].Cells[0].Value.ToString());
            txtResimAdi.Text = dtgridresim.Rows[row].Cells[1].Value.ToString();
            dttarih.Text = dtgridresim.Rows[row].Cells[2].Value.ToString();
            txtresimyolu.Text = dtgridresim.Rows[row].Cells[3].Value.ToString();
        }

        private void btnresimguncelle_Click(object sender, EventArgs e)
        {   //Resim Güncelle
            Baglanti.baglan();
            Galeri.ResimGuncelle(txtResimAdi.Text, dttarih.Value, txtresimyolu.Text,id);
            Baglanti.baglan().Close();
            //Resim Güncellendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridresim.DataSource = Galeri.ResimListele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnResimSil_Click(object sender, EventArgs e)
        {   //Resim Sil
            Baglanti.baglan();
            Galeri.ResimSil(id,dttarih.Value);
            Baglanti.baglan().Close();
            //Silindikten sonra kayıtları yenile
            Baglanti.baglan();
            dtgridresim.DataSource = Galeri.ResimListele();
            Baglanti.baglan().Close();
            temizle();

        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Kayıtları Yenile
            Baglanti.baglan();
            dtgridresim.DataSource = Galeri.ResimListele();
            Baglanti.baglan().Close();
        }
        int i = 0;
        List<string> Listem = new List<string>(Galeri.ResimYollarınıcek());
        private void btnileri_Click(object sender, EventArgs e)
        {

            pctresim.ImageLocation = Listem[i].ToString();
            i++;
            if (Listem.Count == i)
            {
                MessageBox.Show("Resim Gösterisi Bitti");
                btnileri.Enabled = false;
                btngeri.Enabled = true;
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            i--;
            pctresim.ImageLocation = Listem[i].ToString();
            if (i == 0)
            {
                MessageBox.Show("İlk Resim");
                btngeri.Enabled = false;
                btnileri.Enabled = true;
            }
        }


    }
}
