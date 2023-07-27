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
    public partial class FrmOgretmenVeliislem : Form
    {
        public FrmOgretmenVeliislem()
        {
            InitializeComponent();
        }

        private void FrmOgretmenVeliislem_Load(object sender, EventArgs e)
        {   //Velileri Listele
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliListele();
            Baglanti.baglan().Close();
            dtgridvelilistele.Columns[0].Visible = false;
            dtgridvelilistele.Columns[6].Width = 78;
            dtgridvelilistele.Columns[7].Width = 79;
            dtgridvelilistele.Columns[8].Width = 79;
        }

        private void btnara_Click(object sender, EventArgs e)
        {   //Döneme Göre Veli Ara
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliAra(cmbdonemara.GetItemText(cmbdonemara.SelectedItem));
            Baglanti.baglan().Close();
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {  //Kayıtları Yenile
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliListele();
            Baglanti.baglan().Close();
        }

        private void txtveliadara_TextChanged(object sender, EventArgs e)
        {   //ADSOYAD' a göre Veli Arama
            Baglanti.baglan();
            dtgridvelilistele.DataSource = Veli.VeliAraAD(txtveliadara.Text);
            Baglanti.baglan().Close();
        }
    }
}
