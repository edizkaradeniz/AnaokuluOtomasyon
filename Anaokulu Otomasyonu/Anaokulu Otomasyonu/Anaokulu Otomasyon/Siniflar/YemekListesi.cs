using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Anaokulu_Otomasyon.Siniflar
{
   public class YemekListesi
    {
        #region Degiskenler
        public static int YemekListeID;
        public static DateTime Tarih;
        public static string Sabah;
        public static string Oglen;
        public static string Ikindi;
        public static string Donem;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataTable dt;
            #endregion
        #region Fonksiyonlar
        public static DataTable YemekListele()
        {
            string sqlcumle = "Select YemekListesiID,Tarih,Sabah,Ogle,Ikindi,Donemi from YemekListesi where Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Yemek Listesi Listele
        public static void YemekListesiEkle(DateTime tarih,string sabah,string ogle,string ikindi,string donem)
        {
            cmd = new SqlCommand("Insert INTO YemekListesi(Tarih,Sabah,Ogle,Ikindi,Donemi) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", tarih);
            cmd.Parameters.AddWithValue("@p2", sabah);
            cmd.Parameters.AddWithValue("@p3", ogle);
            cmd.Parameters.AddWithValue("@p4", ikindi);
            cmd.Parameters.AddWithValue("@p5", donem);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yemek Listesi Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Yemek Listesi Ekle
        public static void YemekListesiGuncelle(DateTime tarih, string sabah, string ogle, string ikindi, string donem,int ID) //Yemek Listesi Güncelle
        {
            cmd = new SqlCommand("UPDATE YemekListesi set Tarih=@p1,Sabah=@p2,Ogle=@p3,Ikindi=@p4,Donemi=@p5 where YemekListesiID=@p6", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", tarih);
            cmd.Parameters.AddWithValue("@p2", sabah);
            cmd.Parameters.AddWithValue("@p3", ogle);
            cmd.Parameters.AddWithValue("@p4", ikindi);
            cmd.Parameters.AddWithValue("@p5", donem);
            cmd.Parameters.AddWithValue("@p6", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yemek Listesi Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void YemekListesiSil(int ID,DateTime tarih)
        {
            cmd = new SqlCommand("Update YemekListesi set Durumu='false' where YemekListesiID" +
                "=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(tarih.ToLongDateString() + " " + "Tarihli Yemek Listesini Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        } // Yemek Listesi Sil
        public static DataTable YemekListesiAraDonem(string donem) //Yemek Listesi Ara Döneme Göre
        {
            string sqlcumle = "Select YemekListesiID,Tarih,Sabah,Ogle,Ikindi,Donemi from YemekListesi where Donemi=@p1 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", donem);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable YemekListesiAraTarih(DateTime date) //Yemek Listesi Ara Tarihe Göre
        {
            string sqlcumle = "Select YemekListesiID,Tarih,Sabah,Ogle,Ikindi,Donemi from YemekListesi where Tarih=@p1 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", date);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
