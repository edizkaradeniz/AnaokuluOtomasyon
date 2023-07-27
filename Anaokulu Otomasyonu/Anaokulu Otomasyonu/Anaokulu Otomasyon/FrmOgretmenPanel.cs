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
    public partial class FrmOgretmenPanel : Form
    {
        public FrmOgretmenPanel()
        {
            InitializeComponent();
        }
        void labelyazi(Label lbl, string değer)
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

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "ÖĞRENCİ İŞLEMLERİ");
            FrmOgretmenOgrenciİslem frm = new FrmOgretmenOgrenciİslem();
            Formdegis(frm);
        }

        private void FrmOgretmenPanel_Load(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "ANASAYFA");
            label3.Text = "Öğretmen:" + " " + Ogretmen.ADSOYAD;
           
        }

        private void btnveli_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "VELİ İŞLEMLERİ");
            FrmOgretmenVeliislem frm = new FrmOgretmenVeliislem();
            Formdegis(frm);
        }

        private void btnders_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "DERS İŞLEMLERİ");
            FrmVeliDers frm = new FrmVeliDers();
            Formdegis(frm);
            frm.label1.Text = "";
        }

        private void btndersprogrami_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "DERS PROGRAMI");
            FrmVeliDersProgramı frm = new FrmVeliDersProgramı();
            Formdegis(frm);
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "DUYURULAR");
            FrmVeliDuyuru frm = new FrmVeliDuyuru();
            Formdegis(frm);
        }

        private void btnetkinlikler_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "ETKİNLİKLER");
            FrmVeliEtkinlik frm = new FrmVeliEtkinlik();
            Formdegis(frm);
            
        }

        private void btnyemeklistesi_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "YEMEK LİSTESİ");
            FrmVeliYemekListesi frm = new FrmVeliYemekListesi();
            Formdegis(frm);
        }

        private void btnyemekbildirimi_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "YEMEK BİLDİRİMİ");
            FrmOgretmenYemekBildirimi frm = new FrmOgretmenYemekBildirimi();
            Formdegis(frm);
        }

        private void btnİlacİslemleri_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "İLAÇ İŞLEMLERİ");
            FrmOgretmenİlacİslem frm = new FrmOgretmenİlacİslem();
            Formdegis(frm);
        }

        private void btnİlacBildirimi_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "İLAÇ BİLDİRİMİ");
            FrmOgretmenİlacBildirimi frm = new FrmOgretmenİlacBildirimi();
            Formdegis(frm);
        }

        private void btnYoklama_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "YOKLAMA İŞLEMLERİ");
            FrmOgretmenYoklama frm = new FrmOgretmenYoklama();
            Formdegis(frm);
        }

        private void btnGaleri_Click(object sender, EventArgs e)
        {
            paneltemizle();
            labelyazi(lblyazi, "GALERİ");
            FrmOgretmenGaleri frm = new FrmOgretmenGaleri();
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
