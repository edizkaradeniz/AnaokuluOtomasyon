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
    class İlacBildirim
    {
        #region Degiskenler
        public static int İlacBildirimID;
        public static int OgrenciID;
        public static DateTime Tarih;
        public static string Aciklama;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        #endregion
        public static void İlacBildirimEkle(int ogrenciID,DateTime tarih,string aciklama)
        {
            cmd = new SqlCommand("INSERT INTO İlacBildirimi(OgrenciID,Tarih,Aciklama) values(@p1,@p2,@p3)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", aciklama);
            cmd.ExecuteNonQuery();
            MessageBox.Show("İlaç Bildirimi Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//İlaç Bildirimi Ekle
        public static void İlacBildirimiGuncelle(int ogrenciID, DateTime tarih, string aciklama,int ID)
        {
            cmd = new SqlCommand("Update İlacBildirimi set OgrenciID=@p1,Tarih=@p2,Aciklama=@p3 where İlacBildirimiID=@p4", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", aciklama);
            cmd.Parameters.AddWithValue("@p4", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("İlaç Bildirimi Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //İlaç Bildirimi Guncelle
        public static void İlacBildirimiSil(int ID,string adsoyad,DateTime Tarih)
        {
            cmd = new SqlCommand("Update İlacBildirimi set Durumu='false' where İlacBildirimiID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);

            DialogResult cevap;
            cevap = MessageBox.Show(adsoyad + " " + "adlı Öğrencinin"+" "+Tarih.ToLongDateString()+" "+"Tarihli İlaç Bildirimini Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("İlaç Bildirimi Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }//İlaç Bildirimi Silme
        public static DataTable İlacBildirimiAraTarih(DateTime tarih)
        {
            string sqlcumle = "Select İlacBildirimiID,ADSOYAD,Tarih,Aciklama AS 'İlacını İçtimi' from İlacBildirimi AS b INNER JOIN Ogrenci ON OgrenciID=OgrID  where Tarih=@p1 AND b.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //İlaç Bildirimi Ara Tarihe Göre
        public static DataTable İlacBildirimiAraVeli(int ogrenciID)
        {
            string sqlcumle = "Select İlacBildirimiID,ADSOYAD,Tarih,Aciklama  AS 'İlacını İçtimi' from İlacBildirimi AS b INNER JOIN Ogrenci ON OgrenciID=OgrID  where OgrenciID=@p1 AND b.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable İlacBildirimiAraVeli(int ogrenciID,DateTime tarih)
        {
            string sqlcumle = "Select İlacBildirimiID,ADSOYAD,Tarih,Aciklama  AS 'İlacını İçtimi' from İlacBildirimi AS b INNER JOIN Ogrenci ON OgrenciID=OgrID  where OgrenciID=@p1 AND Tarih=@p2 AND b.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID);
            da.SelectCommand.Parameters.AddWithValue("@p2", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
