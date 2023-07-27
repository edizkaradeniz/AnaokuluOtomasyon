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
   public class Yoklama
    {
        #region Degiskenler
        public static int YoklamaID;
        public static int OgrenciID;
        public static DateTime YoklamaTarih;
        public static string OkulaGeldimi;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        #endregion
        #region Fonksiyonlar
        public static  DataTable YoklamaAra(DateTime tarih,string sinif) //Yoklama Arama Tarih Ve SİNİFA göre
        {
            string sqlcumle = "Select YoklamaID,b.ADSOYAD,a.Tarih,OkulaGeldimi,c.Adi AS Sınıf From Yoklama AS a INNER JOIN Ogrenci AS b ON a.OgrenciID=b.OgrID INNER JOIN Sinif AS c ON b.SınıfID=c.SınıfID where Tarih=@p1 AND Adi=@p2 AND a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", tarih);
            da.SelectCommand.Parameters.AddWithValue("@p2", sinif);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void GelmeyenOgrenci(DateTime tarih,string sinif,ListBox liste) //Gelmeyen Öğrencileri Listbox'a Aktarma
        {
            string sqlcumle = "Select YoklamaID,b.ADSOYAD,a.Tarih,OkulaGeldimi,c.Adi AS Sınıf From Yoklama AS a INNER JOIN Ogrenci AS b ON a.OgrenciID=b.OgrID INNER JOIN Sinif AS c ON b.SınıfID=c.SınıfID where Tarih=@p1 AND Adi=@p2 AND a.Durumu='1' AND OkulaGeldimi='Hayır'";
            cmd = new SqlCommand(sqlcumle, Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", tarih);
            cmd.Parameters.AddWithValue("@p2", sinif);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                liste.Items.Add(dr["ADSOYAD"].ToString());
            }
        }
        public static void YoklamaEkle(int ogrenciID,DateTime tarih,string Okul)
        {
            cmd = new SqlCommand("Insert INTO Yoklama(OgrenciID,Tarih,OkulaGeldimi) values(@p1,@p2,@p3)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", Okul);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yoklama Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Yoklama Ekle
        public static void YoklamaGuncelle(int ogrenciID, DateTime tarih, string Okul,int ID)//Yoklama Güncelle
        {
            cmd = new SqlCommand("UPDATE Yoklama set OgrenciID=@p1,Tarih=@p2,OkulaGeldimi=@p3 where YoklamaID=@p4 ", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", Okul);
            cmd.Parameters.AddWithValue("@p4", ID);
            MessageBox.Show("Yoklama Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.ExecuteNonQuery();
        }
        public static void YoklamaSil(int ID,string adsoyad,DateTime Tarih) //Yoklama Sil
        {
            cmd = new SqlCommand("Update Yoklama set Durumu='false' where YoklamaID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(adsoyad + " " + "adlı Öğrencinin"+" "+Tarih.ToShortDateString()+" "+"Tarihli Yoklamasını Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yoklama Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

            }
        }
        public static DataTable YoklamaAra(DateTime tarih)
        {
            string sqlcumle = "Select YoklamaID,ADSOYAD,Tarih,OkulaGeldimi from Yoklama AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where Tarih=@p1 AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable YoklamaAraVeli(int ogrenciID)
        {
            string sqlcumle = "Select YoklamaID,ADSOYAD,Tarih,OkulaGeldimi from Yoklama AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where OgrenciID=@p1 AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable YoklamaAraVeli(int ogrenciID,DateTime tarih)
        {
            string sqlcumle = "Select YoklamaID,ADSOYAD,Tarih,OkulaGeldimi from Yoklama AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where OgrenciID=@p1 AND Tarih=@p2 AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID);
            da.SelectCommand.Parameters.AddWithValue("@p2", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
