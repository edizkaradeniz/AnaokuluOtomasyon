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
    public partial class FrmVeliÖdemeler : Form
    {
        public FrmVeliÖdemeler()
        {
            InitializeComponent();
        }

        private void FrmVeliÖdemeler_Load(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridodemeler.DataSource = Aidat.AidatGoruntuleVeli(Veli.ID);
            dtgridodemeler.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgridodemeler.Columns[1].Width = 148;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridodemeler.DataSource = Aidat.AidatGoruntuleVeli(Veli.ID, Convert.ToDateTime(dttarih.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }
    }
}
