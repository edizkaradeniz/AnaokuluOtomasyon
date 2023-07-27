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
    public partial class FrmOgretmenİlacİslem : Form
    {
        public FrmOgretmenİlacİslem()
        {
            InitializeComponent();
        }

        private void FrmOgretmenİlacİslem_Load(object sender, EventArgs e)
        {   //Sinifları combobox'a çekme
            Baglanti.baglan();
            cmbsinif.DataSource = Sinif.comboboxsiniflarigetir();
            cmbsinif.DisplayMember = "Adi";
            cmbsinif.ValueMember = "SınıfID";
            Baglanti.baglan().Close();
           

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridviewİlac.DataSource = İlac.İlacAraSinif(cmbsinif.GetItemText(cmbsinif.SelectedItem));
            Baglanti.baglan().Close();
            dtgridviewİlac.Columns[0].Visible = false;
            dtgridviewİlac.Columns[1].Width = 150;
            dtgridviewİlac.Columns[2].Width = 125;
            dtgridviewİlac.Columns[3].Width = 228;
        }
    }
}
