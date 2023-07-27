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
    public partial class FrmVeliİlacBildirimi : Form
    {
        public FrmVeliİlacBildirimi()
        {
            InitializeComponent();
        }

        private void FrmVeliİlacBildirimi_Load(object sender, EventArgs e)
        {   //Velinin Öğrencisini Combobox'a Çekme
            Baglanti.baglan();
            dtgridilacbildirim.DataSource = İlacBildirim.İlacBildirimiAraVeli(Veli.OGRID);
            dtgridilacbildirim.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgridilacbildirim.Columns[3].Width = 162;
            dtgridilacbildirim.Columns[2].Width = 163;
            dtgridilacbildirim.Columns[1].Width = 163;
        }


        private void btnara_Click(object sender, EventArgs e)
        {   //Tarihe Göre İlaç Bildirimi
            Baglanti.baglan();
            dtgridilacbildirim.DataSource = İlacBildirim.İlacBildirimiAraVeli(Veli.OGRID, Convert.ToDateTime(dttarih.Value.ToShortDateString()));
            Baglanti.baglan().Close();
        }
    }
}
