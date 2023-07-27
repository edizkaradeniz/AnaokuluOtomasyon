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
    public partial class FrmYoklamaListesi : Form
    {
        public FrmYoklamaListesi()
        {
            InitializeComponent();
        }

        private void btnara_Click(object sender, EventArgs e)
        {   //Yoklama Listesi Ara Tarih ve sınıfa göre
            listBox1.Items.Clear();
            Baglanti.baglan();
            dtgridYoklamaListesi.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarih.Value.ToShortDateString()), cmbsinif.GetItemText(cmbsinif.SelectedItem));
            Baglanti.baglan();
            Baglanti.baglan();
            Yoklama.GelmeyenOgrenci(Convert.ToDateTime(dttarih.Value.ToShortDateString()), cmbsinif.GetItemText(cmbsinif.SelectedItem), listBox1);
            Baglanti.baglan().Close();
            dtgridYoklamaListesi.Columns[0].Visible = false;
            dtgridYoklamaListesi.Columns[1].Width = 143;
            dtgridYoklamaListesi.Columns[2].Width = 143;
            dtgridYoklamaListesi.Columns[3].Width = 144;
            dtgridYoklamaListesi.Columns[4].Width = 144;
        }
        

        private void FrmYoklamaListesi_Load(object sender, EventArgs e)
        {
            //Siniflari Çekme
            Baglanti.baglan();
            cmbsinif.DataSource = Sinif.comboboxsiniflarigetir();
            cmbsinif.DisplayMember = "Adi";
            cmbsinif.ValueMember = "SınıfID";
            Baglanti.baglan().Close();
            
        }

       
    }
}
