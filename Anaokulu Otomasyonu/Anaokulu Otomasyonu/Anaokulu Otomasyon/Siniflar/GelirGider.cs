using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anaokulu_Otomasyon.Siniflar
{
  public  class GelirGider
    {
        #region Degiskenler
        public static int GelirgiderID;
        public static string gelirgider;
        public static DateTime gelirgiderTarih;
        public static int Gelirgidertutar;
        public static string gelirgiderturu;
        public static string odemeturu;
        public static string Donemi;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static int toplamgelir;
        
        #endregion
        #region Fonksiyonlar
        public static DataTable GelirGiderListele() //Gelir-Gider Listeleme
        {
            string sqlcumle = "Select GelirGiderID,GelirGider,Tarih,Tutar,GelirGiderTuru,OdemeTuru,Donem from GelirGider where Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void GelirGiderEkle(string gelirgider,DateTime tarih,int tutar,string gelirgidertur,string odemetur,string donem)
        {
            cmd = new SqlCommand("INSERT INTO GelirGider(GelirGider,Tarih,Tutar,GelirGiderTuru,OdemeTuru,Donem) values(@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", gelirgider);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", tutar);
            cmd.Parameters.AddWithValue("@p4", gelirgidertur);
            cmd.Parameters.AddWithValue("@p5", odemetur);
            cmd.Parameters.AddWithValue("@p6", donem);
            cmd.ExecuteNonQuery();
        } //Gider Ekleme
        public static void GelirGiderGuncelle(string gelirgider, DateTime tarih, int tutar, string gelirgidertur, string odemetur, string donem,int ID)
        {
            cmd = new SqlCommand("UPDATE GelirGider set GelirGider=@p1,Tarih=@p2,Tutar=@p3,GelirGiderTuru=@p4,OdemeTuru=@p5,Donem=@p6 where GelirGiderID=@p7", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", gelirgider);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", tutar);
            cmd.Parameters.AddWithValue("@p4", gelirgidertur);
            cmd.Parameters.AddWithValue("@p5", odemetur);
            cmd.Parameters.AddWithValue("@p6", donem);
            cmd.Parameters.AddWithValue("@p7", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Gider Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Gider Güncelleme
        public static void GelirGiderSil(int ID,DateTime tarih)
        {
            cmd = new SqlCommand("Update GelirGider set Durumu='false' where GelirGiderID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(tarih.ToLongDateString() + " " + "Tarihli Kaydı Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        }//Gider Silme
        public static DataTable GelirGiderAraTarih(DateTime Giris,DateTime Cikis) //2 Tarih Arası GelirGider Arama
        {
            string sqlcumle = "Select GelirGiderID,GelirGider,Tarih,Tutar,GelirGiderTuru,OdemeTuru,Donem from GelirGider where Tarih between @p1 and @p2 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", Giris);
            da.SelectCommand.Parameters.AddWithValue("@p2", Cikis);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public static DataTable GelirGiderAraDonem(string donem) //Döneme Göre GelirGider Arama
        {
            string sqlcumle = "Select GelirGiderID,GelirGider,Tarih,Tutar,GelirGiderTuru,OdemeTuru,Donem from GelirGider where Donem=@p1 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", donem);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       
        #endregion
    }
}
