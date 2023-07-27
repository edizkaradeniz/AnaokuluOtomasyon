using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anaokulu_Otomasyon.Siniflar;
using System.Windows.Forms;

namespace Anaokulu_Otomasyon
{
    public partial class FrmVeliPanel : Form
    {
        public FrmVeliPanel()
        {
            InitializeComponent();
            
        }
        void labelyazi(Label lbl,string değer)
        {
            lbl.Text = değer;
        }
        void Formdegis(Form frm)
        {
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlcontainer.Controls.Add(frm);
            frm.Show();
        }
        void paneltemizle()
        {
            pnlcontainer.Controls.Clear();
        }
        private void FrmVeliPanel_Load(object sender, EventArgs e)
        {
            labelyazi(lblyazi, "ANASAYFA");
            label3.Text = "Veli:"+" "+Veli.ADSOYAD.ToString();
        }

        private void btnDersler_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "DERSLER");
            FrmVeliDers frm = new FrmVeliDers();
            Formdegis(frm);
        }

        private void btnDersprogrami_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "DERS PROGRAMI");
            FrmVeliDersProgramı frm = new FrmVeliDersProgramı();
            Formdegis(frm);
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "DUYURULAR");
            FrmVeliDuyuru frm = new FrmVeliDuyuru();
            Formdegis(frm);
        }

        private void btnEtkinlikler_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "ETKİNLİKLER");
            FrmVeliEtkinlik frm = new FrmVeliEtkinlik();
            Formdegis(frm);
        }

        private void btnYemekListesi_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "YEMEK LİSTESİ");
            FrmVeliYemekListesi frm = new FrmVeliYemekListesi();
            Formdegis(frm);
        }

        private void btnYemekBildirimi_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "YEMEK BİLDİRİMİ");
            FrmVeliYemekBildirim frm = new FrmVeliYemekBildirim();
            Formdegis(frm);
        }

        private void btnGaleri_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "GALERİ");
            FrmVeliGaleri frm = new FrmVeliGaleri();
            Formdegis(frm);
        }

        private void btnÖdemeler_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "ÖDEMELER");
            FrmVeliÖdemeler frm = new FrmVeliÖdemeler();
            Formdegis(frm);
        }

        private void btnYoklama_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "YOKLAMA LİSTESİ");
            FrmVeliYoklama frm = new FrmVeliYoklama();
            Formdegis(frm);
        }

        private void btnİlacislemleri_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "İLAÇ İŞLEMLERİ");
            FrmVeliİlac frm = new FrmVeliİlac();
            Formdegis(frm);
        }

        private void btnİlacBildirimi_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "İLAÇ BİLDİRİMİ");
            FrmVeliİlacBildirimi frm = new FrmVeliİlacBildirimi();
            Formdegis(frm);
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Hide();
        }
    }
}
