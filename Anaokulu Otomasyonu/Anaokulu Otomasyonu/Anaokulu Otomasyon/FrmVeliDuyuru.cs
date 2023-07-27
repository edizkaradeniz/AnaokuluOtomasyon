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
    public partial class FrmVeliDuyuru : Form
    {
        public FrmVeliDuyuru()
        {
            InitializeComponent();
        }

        private void FrmVeliDuyuru_Load(object sender, EventArgs e)
        {  //Duyuruları Listele
            Baglanti.baglan();
            dtgridviewduyuru.DataSource = Duyuru.DuyuruListele();
            dtgridviewduyuru.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgridviewduyuru.Columns[1].Width = 122;
            dtgridviewduyuru.Columns[2].Width = 140;
        }

        private void dtgridviewduyuru_CellClick(object sender, DataGridViewCellEventArgs e)
        {  //Tıklanan satırın bilgisini textbox aktar
            int row = e.RowIndex;
            txtduyurubaslik.Text = dtgridviewduyuru.Rows[row].Cells[2].Value.ToString();
            rchicerik.Text= dtgridviewduyuru.Rows[row].Cells[3].Value.ToString();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            //Tarihe Göre Duyuru Ara
            Baglanti.baglan();
            dtgridviewduyuru.DataSource = Duyuru.DuyuruAraTarih(Convert.ToDateTime(dttarih.Value.ToShortDateString()));
            Baglanti.baglan().Close();

        }
    }
}
