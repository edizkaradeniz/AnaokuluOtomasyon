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
    public partial class FrmVeliYoklama : Form
    {
        public FrmVeliYoklama()
        {
            InitializeComponent();
        }

        private void FrmVeliYoklama_Load(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridYoklama.DataSource = Yoklama.YoklamaAraVeli(Veli.OGRID);
            dtgridYoklama.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgridYoklama.Columns[1].Width = 185;
            dtgridYoklama.Columns[2].Width = 150;
            dtgridYoklama.Columns[3].Width = 150;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridYoklama.DataSource = Yoklama.YoklamaAraVeli(Veli.OGRID, Convert.ToDateTime(dttarih.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }
    }
}
