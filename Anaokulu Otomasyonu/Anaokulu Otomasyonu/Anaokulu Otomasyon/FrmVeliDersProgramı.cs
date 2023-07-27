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
    public partial class FrmVeliDersProgramı : Form
    {
        public FrmVeliDersProgramı()
        {
            InitializeComponent();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            dtgriddersprogrami.DataSource = DersProgrami.DersprogramiAraTarih(Convert.ToDateTime(dttarih.Value.ToShortDateString()));
            dtgriddersprogrami.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgriddersprogrami.Columns[2].Width = 100;
            dtgriddersprogrami.Columns[3].Width = 100;
            dtgriddersprogrami.Columns[5].Width = 113;
            dtgriddersprogrami.Columns[6].Width = 113;
        }

        private void FrmVeliDersProgramı_Load(object sender, EventArgs e)
        {
         
        }
    }
}
