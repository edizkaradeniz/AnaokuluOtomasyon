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
    class Aidat
    {
        #region Degiskenler
        public static int aidatID;
        public static int VeliID;
        public static DateTime AidatTarih;
        public static int Tutar;
        public static string OdemeTuru;
        public static string Donem;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        #endregion
        #region Fonksiyonlar 
        public static DataTable AidatListele() //Aidatları Listele
        {
            string sqlcumle = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID where a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void AidatEkle(int veliID,DateTime tarih,int tutar,string odemetur,string donem)//Aidat Ekle
        {

            cmd = new SqlCommand("Insert INTO Aidat(VeliID,Tarih,Tutar,OdemeTuru,Donem) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", veliID);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", tutar);
            cmd.Parameters.AddWithValue("@p4", odemetur);
            cmd.Parameters.AddWithValue("@p5", donem);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Aidat Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void AidatGuncelle(int veliID, DateTime tarih, int tutar, string odemetur, string donem, int ID)//Aidat Guncelle
        {
            cmd = new SqlCommand("UPDATE Aidat set VeliID=@p1,Tarih=@p2,Tutar=@p3,OdemeTuru=@p4,Donem=@p5 where AidatID=@p6", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", veliID);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", tutar);
            cmd.Parameters.AddWithValue("@p4", odemetur);
            cmd.Parameters.AddWithValue("@p5", donem);
            cmd.Parameters.AddWithValue("@p6", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Aidat Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void AidatSil(int ID,string adsoyad,DateTime tarih) //Aidat Sil
        {
            cmd = new SqlCommand("Update Aidat set Durumu='false' where AidatID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(adsoyad + " " + "Adlı Velinin"+" "+tarih.ToShortDateString()+" "+"Tarihli Aidatını Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        }
        public static DataTable AidatAraDonem(string donem)
        {
            string sqlcumle = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,a.Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID  where Donem=@p1 AND a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", donem);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Aidat Ara Döneme Göre
        public static DataTable AidatAraTarih(DateTime tarih)
        {
            string sqlcumle = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,a.Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID where Tarih=@p1 AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Aidat Ara Tarihe Göre
        public static DataTable AidatAraVeli(string adsoyad)
        {
            string sqlcumle = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,a.Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID where ADSOYAD LIKE '%'+@p1+'%' AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", adsoyad);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Aidat ara Veli adına göre
        public static DataTable AidatGoruntuleVeli(int veliID)
        {
            string sqlcumle = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID  where a.VeliID=@p1 AND a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", veliID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }//Veli Giriş Yaptığında Kendi Ödediği Aidatları Görüntüleme
        public static DataTable AidatGoruntuleVeli(int veliID,DateTime tarih)
        {
            string sqlcumle = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID  where a.VeliID=@p1 AND Tarih=@p2 AND a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", veliID);
            da.SelectCommand.Parameters.AddWithValue("@p2", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Veli Giriş Yaptıgında Kendi Ödediği Aidatları Tarihe Göre görüntülüme
        #endregion
    }
}
