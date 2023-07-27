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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtkuladogretmen.Text = "";
            txtkuladveli.Text = "";
            txtkuladyönetici.Text = "";
            txtsifreogretmen.Text = "";
            txtsifreveli.Text = "";
            txtsifreyönetici.Text = "";
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToString();
        }

        private void btnYönetici_Click(object sender, EventArgs e)
        {
            //Yönetici Girişi Kontrol
            Baglanti.baglan();
            bool kontrol = Yonetici.GirisYap(txtkuladyönetici.Text, txtsifreyönetici.Text); 
            if (kontrol)
            {
                FrmYönetici frm = new FrmYönetici();
                frm.Show();
                this.Hide();
            }
            else if (txtkuladyönetici.Text == "" || txtsifreyönetici.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı veya Şifreyi Boş Bırakmayınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Baglanti.baglan().Close();
            temizle();
        }
        private void btnögretmen_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            bool kontrol = Ogretmen.GirisYap(txtkuladogretmen.Text, txtsifreogretmen.Text);
            if (kontrol)
            {
                FrmOgretmenPanel frm = new FrmOgretmenPanel();
                frm.Show();
                this.Hide();
            }
            else if (txtkuladogretmen.Text == "" || txtsifreogretmen.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı veya Şifreyi Boş Bırakmayınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Baglanti.baglan().Close();
            temizle();
        }

        private void btnveli_Click(object sender, EventArgs e)
        {
            Baglanti.baglan();
            bool kontrol = Veli.GirisYap(txtkuladveli.Text, txtsifreveli.Text);
            if (kontrol)
            {
                FrmVeliPanel frm = new FrmVeliPanel();
                frm.Show();
                this.Hide();
            }
            else if (txtkuladveli.Text == "" || txtsifreveli.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı veya Şifreyi Boş Bırakmayınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Baglanti.baglan().Close();
            temizle();
        }
    }
}
