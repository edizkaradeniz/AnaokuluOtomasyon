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
    public partial class FrmVeliGaleri : Form
    {
        public FrmVeliGaleri()
        {
            InitializeComponent();
        }

        private void FrmVeliGaleri_Load(object sender, EventArgs e)
        {
        
        }
        int i = 0;
        List<string> Listem = new List<string>(Galeri.ResimYollarınıcek());
        private void btnileri_Click(object sender, EventArgs e)
        {

            pctresim.ImageLocation = Listem[i].ToString();
            i++;
            if (Listem.Count == i)
            {
                MessageBox.Show("Resim Gösterisi Bitti");
                btnileri.Enabled = false;
                btngeri.Enabled = true;
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            i--;
            pctresim.ImageLocation = Listem[i].ToString();
            if (i == 0)
            {
                MessageBox.Show("İlk Resim");
                btngeri.Enabled = false;
                btnileri.Enabled = true;
            }
        }
    }
}
