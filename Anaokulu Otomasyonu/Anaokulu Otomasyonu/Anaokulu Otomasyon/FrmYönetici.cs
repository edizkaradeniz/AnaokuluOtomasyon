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
    public partial class FrmYönetici : Form
    {
        public FrmYönetici()
        {
            InitializeComponent();

        }
       public void Formdegis(Form frm)
        {
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlcontainer.Controls.Add(frm);
            frm.Show();
        }

        void yaziyaz(string yazi)
        {
            lblyazi.Text = yazi.ToString();
        }
        void paneltemizle()
        {
            pnlcontainer.Controls.Clear();
        }

        private void btnogrislem_Click(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("ÖĞRENCİ İŞLEMLERİ");
            FrmOgrenci frm = new FrmOgrenci();
            Formdegis(frm);
        }

        private void FrmYönetici_Load(object sender, EventArgs e)
        {
            lbladsoyad.Text ="Yönetici:"+" "+Yonetici.ADSOYAD;
            yaziyaz("ANASAYFA");
        }

        private void btnogretmenislem_Click(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("ÖĞRETMEN İŞLEMLERİ");
            FrmOgretmen frm = new FrmOgretmen();
            Formdegis(frm);
        }

        private void btnveliislem_Click(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("VELİ İŞLEMLERİ");
            FrmVeli frm = new FrmVeli();
            Formdegis(frm);
        }

        private void btnduyuruislem_Click(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("DUYURU İŞLEMLERİ");
            FrmDuyuru frm = new FrmDuyuru();
            Formdegis(frm);
        }

        private void btnsinifbilgiislem_Click(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("SINIF BİLGİLERİ");
            FrmSinifBilgileri frm = new FrmSinifBilgileri();
            Formdegis(frm);
        }

        private void btnyemeklisteişlem_Click(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("YEMEK LİSTESİ");
            FrmYemekListesi frm = new FrmYemekListesi();
            Formdegis(frm);
        }

        private void btndersislem_Click(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("DERS İŞLEMLERİ");
            FrmDers frm = new FrmDers();
            Formdegis(frm);
        }

        private void btndersprogramislem_Click_1(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("DERS PROGRAMI");
            FrmDersProgrami frm = new FrmDersProgrami();
            Formdegis(frm);
        }

        private void btnetkinlikislem_Click(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("ETKİNLİK İŞLEMLERİ");
            FrmEtkinlik frm = new FrmEtkinlik();
            Formdegis(frm);

        }
        private void btngelirgiderislem_Click_1(object sender, EventArgs e)
        {
            paneltemizle();
            yaziyaz("GELİR-GİDER İŞLEMLERİ");
            FrmGelirGider frm = new FrmGelirGider();
            Formdegis(frm);

        }

        private void btnYoklamalisteislem_Click_1(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("YOKLAMA LİSTESİ");
            FrmYoklamaListesi frm = new FrmYoklamaListesi();
            Formdegis(frm);

        }

        private void btnilacislem_Click_1(object sender, EventArgs e)
        {

            paneltemizle();
            yaziyaz("İLAÇ LİSTESİ");
            Frmilac frm = new Frmilac();
            Formdegis(frm);
        }

        private void btnaidat_Click(object sender, EventArgs e)
        {
            paneltemizle();
            yaziyaz("AİDAT İŞLEMLERİ");
            FrmAidat frm = new FrmAidat();
            Formdegis(frm);
        }

        private void btnGaleri_Click(object sender, EventArgs e)
        {
            paneltemizle();
            yaziyaz("GALERİ");
            FrmGaleri frm = new FrmGaleri();
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
