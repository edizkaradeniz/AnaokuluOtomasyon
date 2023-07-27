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
    public partial class FrmDers : Form
    {
        public FrmDers()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtDersad.Text = "";
            rchaciklama.Text = "";
        }
        private void FrmDers_Load(object sender, EventArgs e)
        {  //Ders Listele
            Baglanti.baglan();
            dtgdersgoruntule.DataSource = Ders.Listele();
            Baglanti.baglan().Close();
            dtgdersgoruntule.Columns[0].Visible = false;
            dtgdersgoruntule.Columns[1].Width = 150;
            dtgdersgoruntule.Columns[2].Width = 313;
        }
        static int id;
        private void dtgdersgoruntule_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Seçili Satırı textboxlara aktar
            int rowindex = e.RowIndex;
            id = int.Parse(dtgdersgoruntule.Rows[rowindex].Cells[0].Value.ToString());
            txtDersad.Text = dtgdersgoruntule.Rows[rowindex].Cells[1].Value.ToString();
            rchaciklama.Text = dtgdersgoruntule.Rows[rowindex].Cells[2].Value.ToString();
        }

        private void btndersguncelle_Click(object sender, EventArgs e)
        {   //Ders Güncelle
            Baglanti.baglan();
            Ders.DersGuncelle(txtDersad.Text, rchaciklama.Text,id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra kayıtları yenile 
            Baglanti.baglan();
            dtgdersgoruntule.DataSource = Ders.Listele();
            Baglanti.baglan().Close();
            temizle();

        }

        private void btndersekle_Click(object sender, EventArgs e)
        {
            //Ders Ekle
            Baglanti.baglan();
            Ders.DersEkle(txtDersad.Text, rchaciklama.Text);
            Baglanti.baglan().Close();
            //Eklendikten sonra kayıtları yenile 
            Baglanti.baglan();
            dtgdersgoruntule.DataSource = Ders.Listele();
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Kayıtları Yenile
            Baglanti.baglan();
            dtgdersgoruntule.DataSource = Ders.Listele();
            Baglanti.baglan().Close();
        }

        private void txtdersara_TextChanged(object sender, EventArgs e)
        {   //Ders Arama
            Baglanti.baglan();
            dtgdersgoruntule.DataSource = Ders.DersAra(txtdersara.Text);
            Baglanti.baglan().Close();
        }

        private void btnderssil_Click(object sender, EventArgs e)
        {   //Ders Sil
            Baglanti.baglan();
            Ders.DersSil(id,txtDersad.Text);
            Baglanti.baglan().Close();
            //Silindikten sonra kayıtları yenile
            Baglanti.baglan();
            dtgdersgoruntule.DataSource = Ders.Listele();
            Baglanti.baglan().Close();
            temizle();
        }
    }
}
