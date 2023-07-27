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
    public partial class FrmVeliDers : Form
    {
        public FrmVeliDers()
        {
            InitializeComponent();
        }

        private void FrmVeliDers_Load(object sender, EventArgs e)
        {   
            Baglanti.baglan();
            
            dtgdersgoruntule.DataSource = Ders.Listele();
            dtgdersgoruntule.Columns[0].Visible = false;
            Baglanti.baglan().Close();
            dtgdersgoruntule.Columns[1].Width = 150;
            dtgdersgoruntule.Columns[2].Width = 289;
        }

        private void dtgdersgoruntule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            rchaciklama.Text = dtgdersgoruntule.Rows[row].Cells[2].Value.ToString();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
