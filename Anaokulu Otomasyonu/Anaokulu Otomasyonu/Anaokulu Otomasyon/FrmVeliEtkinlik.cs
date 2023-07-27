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
    public partial class FrmVeliEtkinlik : Form
    {
        public FrmVeliEtkinlik()
        {
            InitializeComponent();
        }

        private void FrmVeliEtkinlik_Load(object sender, EventArgs e)
        {   //Etkinlik Listele
            Baglanti.baglan();
            dtgridEtkinlik.DataSource = Etkinlik.EtkinlikListele();
            dtgridEtkinlik.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgridEtkinlik.Columns[2].Width = 158;
            dtgridEtkinlik.Columns[3].Width = 250;
        }

        private void btnara_Click(object sender, EventArgs e)
        {   //Tarihe Göre Etkinlik Ara
            Baglanti.baglan();
            dtgridEtkinlik.DataSource = Etkinlik.EtkinlikAraTarih(Convert.ToDateTime(dttarih.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }

        private void dtgridEtkinlik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtetkinlikbaslik.Text = dtgridEtkinlik.Rows[row].Cells[2].Value.ToString();
            rchetkinlikbilgi.Text= dtgridEtkinlik.Rows[row].Cells[3].Value.ToString();
        }

       
    }
}
