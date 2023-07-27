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
    public partial class FrmVeliYemekListesi : Form
    {
        public FrmVeliYemekListesi()
        {
            InitializeComponent();
        }

        private void btnara_Click(object sender, EventArgs e)
        {   //Tarihe Göre Arama
            Baglanti.baglan();
            dtgridyemeklistesi.DataSource = YemekListesi.YemekListesiAraTarih(Convert.ToDateTime(dttarih.Value.ToShortDateString()));
            dtgridyemeklistesi.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgridyemeklistesi.Columns[2].Width = 142;
            dtgridyemeklistesi.Columns[3].Width = 142;
            dtgridyemeklistesi.Columns[4].Width = 142;
        }

        private void dtgridyemeklistesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            rchsabah.Text = dtgridyemeklistesi.Rows[row].Cells[2].Value.ToString();
            rchogle.Text = dtgridyemeklistesi.Rows[row].Cells[3].Value.ToString();
            rchikindi.Text = dtgridyemeklistesi.Rows[row].Cells[4].Value.ToString();
        }

        private void FrmVeliYemekListesi_Load(object sender, EventArgs e)
        {
           
        }
    }
}
