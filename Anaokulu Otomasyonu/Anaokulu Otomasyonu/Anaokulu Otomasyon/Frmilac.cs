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
    public partial class Frmilac : Form
    {
        public Frmilac()
        {
            InitializeComponent();
        }

        private void Frmilac_Load(object sender, EventArgs e)
        {   //İlaçları Listele
            Baglanti.baglan();
            dtgridilac.DataSource = İlac.İlacListele();
            Baglanti.baglan().Close();
            //Combobox'a Sınıfları Çekme
            Baglanti.baglan();
            cmbsinif.DataSource = Sinif.comboboxsiniflarigetir();
            cmbsinif.DisplayMember = "Adi";
            cmbsinif.ValueMember = "SınıfID";
            Baglanti.baglan().Close();
            dtgridilac.Columns[0].Visible = false;
            dtgridilac.Columns[1].Width = 133;
            dtgridilac.Columns[2].Width = 120;
            dtgridilac.Columns[3].Width = 250;
        }

        private void btnara_Click(object sender, EventArgs e)
        {   //Sinifa Göre Arama
            Baglanti.baglan();
            dtgridilac.DataSource = İlac.İlacAraSinif(cmbsinif.GetItemText(cmbsinif.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void txtOgrenci_TextChanged(object sender, EventArgs e) 
        {
            //İlaç Arama AdSoyada göre
            Baglanti.baglan();
            dtgridilac.DataSource = İlac.İlacAraADSOYAD(txtOgrenci.Text);
            Baglanti.baglan().Close();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        { //Kayıtları Yenileme
            Baglanti.baglan();
            dtgridilac.DataSource = İlac.İlacListele();
            Baglanti.baglan().Close();
        }
    }
}
