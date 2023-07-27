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
    public partial class FrmOgretmenOgrenciİslem : Form
    {
        public FrmOgretmenOgrenciİslem()
        {
            InitializeComponent();
        }

        private void FrmOgretmenOgrenciİslem_Load(object sender, EventArgs e)
        {   //Comboboxa veritabanından siniflari çek
            Baglanti.baglan();
            cmbsinifara.DataSource = Sinif.comboboxsiniflarigetir();
            cmbsinifara.DisplayMember = "Adi";
            cmbsinifara.ValueMember = "SınıfID";
            Baglanti.baglan().Close();
            //Öğrencileri Listele
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Listele();
            Baglanti.baglan().Close();
            dtgridogrlistele.Columns[0].Visible = false;
            dtgridogrlistele.Columns[1].Width = 139;
            dtgridogrlistele.Columns[2].Width = 138;
        }

        private void btnsinifara_Click(object sender, EventArgs e)
        {   //Sinifa Göre Arama
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.OgrenciAraSinif((int)cmbsinifara.SelectedValue);
            Baglanti.baglan().Close();
        }

        private void btndonemiara_Click(object sender, EventArgs e)
        {
            //Döneme Göre Arama
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Arama(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {   //Tüm öğrenciler Listele
            Baglanti.baglan();
            dtgridogrlistele.DataSource = Ogrenci.Listele();
            Baglanti.baglan().Close();
        }
    }
}
