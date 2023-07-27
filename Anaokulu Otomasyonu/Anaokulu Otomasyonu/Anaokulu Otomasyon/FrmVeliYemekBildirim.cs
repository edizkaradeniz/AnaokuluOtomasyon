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
    public partial class FrmVeliYemekBildirim : Form
    {
        public FrmVeliYemekBildirim()
        {
            InitializeComponent();
        }

        private void FrmVeliYemekBildirim_Load(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimiVeli(Veli.OGRID);
            dtgridyemekbildirim.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgridyemekbildirim.Columns[3].Width = 348;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimiVeli(Veli.OGRID, Convert.ToDateTime(dttarih.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }


    }
}
