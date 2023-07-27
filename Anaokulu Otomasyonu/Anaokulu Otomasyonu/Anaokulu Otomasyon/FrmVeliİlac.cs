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
    public partial class FrmVeliİlac : Form
    {
        public FrmVeliİlac()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtilac.Text = "";
            rchaciklama.Text = "";
        }
        private void FrmVeliİlac_Load(object sender, EventArgs e)
        {   //Velinin Öğrencisini Çekme
            Baglanti.baglan();
            cmbadsoyad.DataSource = Ogrenci.OgrenciVeliCek(Veli.ID);
            cmbadsoyad.DisplayMember = "ADSOYAD";
            cmbadsoyad.ValueMember = "OGRID";
            Baglanti.baglan().Close();
            //Öğrencinin İlaçlarını Listele
            Baglanti.baglan();
            dtgridilac.DataSource = İlac.İlacListeleVeli(Veli.OGRID);
            dtgridilac.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgridilac.Columns[1].Width = 150;
            dtgridilac.Columns[2].Width = 150;
            dtgridilac.Columns[3].Width = 188;
        }

        private void btnilacekle_Click(object sender, EventArgs e)
        {  //İlaç Ekle
            Baglanti.baglan();
            İlac.İlacEkle((int)cmbadsoyad.SelectedValue, txtilac.Text, rchaciklama.Text);
            Baglanti.baglan().Close();
            //Eklendikten Sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridilac.DataSource = İlac.İlacListeleVeli(Veli.OGRID);
            Baglanti.baglan().Close();
            temizle();
        }
        static int id;
        private void dtgridilac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            id = int.Parse(dtgridilac.Rows[row].Cells[0].Value.ToString());
            cmbadsoyad.Text = dtgridilac.Rows[row].Cells[1].Value.ToString();
            txtilac.Text = dtgridilac.Rows[row].Cells[2].Value.ToString();
            rchaciklama.Text = dtgridilac.Rows[row].Cells[3].Value.ToString();
        }

        private void btnilacguncelle_Click(object sender, EventArgs e)
        {  //İlaç Güncelle
            Baglanti.baglan();
            İlac.İlacGuncelle(txtilac.Text, rchaciklama.Text, id);
            Baglanti.baglan().Close();
            //Güncellendikten sonra Kayıtları Yenile
            Baglanti.baglan();
            dtgridilac.DataSource = İlac.İlacListeleVeli(Veli.OGRID);
            Baglanti.baglan().Close();
            temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {    //Kayıt Silme
            Baglanti.baglan();
            İlac.İlacSil(id,txtilac.Text);
            Baglanti.baglan().Close();
            //Silindikten sonra kayıtları yenile
            Baglanti.baglan();
            dtgridilac.DataSource = İlac.İlacListeleVeli(Veli.OGRID);
            Baglanti.baglan().Close();
            temizle();
        }
    }
}
