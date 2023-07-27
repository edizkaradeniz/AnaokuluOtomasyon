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
    class YemekBildirimi
    {
        #region Degiskenler
        public static int YemekBildirimID;
        public static int OgrenciID;
        public static DateTime Tarih;
        public static string Aciklama;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        #endregion
        #region Fonksiyonlar
        public static void YemekBildirimEkle(int ogrenciID,DateTime Tarih,string aciklama)
        {
            cmd = new SqlCommand("Insert Into YemekBildirimi(OgrenciID,Tarih,Aciklama) values(@p1,@p2,@p3)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            cmd.Parameters.AddWithValue("@p2", Tarih);
            cmd.Parameters.AddWithValue("@p3", aciklama);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yemek Bildirimi  Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //YemekBildirimiEkle
        public static void YemekBildirimGuncelle(int ogrenciID, DateTime Tarih, string aciklama,int ID)//YemekBildirimGuncelle
        {
            cmd = new SqlCommand("UPDATE YemekBildirimi set OgrenciID=@p1,Tarih=@p2,Aciklama=@p3 where YemekBildirimID=@p4", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ogrenciID);
            cmd.Parameters.AddWithValue("@p2", Tarih);
            cmd.Parameters.AddWithValue("@p3", aciklama);
            cmd.Parameters.AddWithValue("@p4", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yemek Bildirimi Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DataTable YemekBildirimAra(DateTime tarih)
        {
            string sqlcumle = "Select YemekBildirimID,ADSOYAD,Tarih,Aciklama AS 'Yemeğini Yedimi' from YemekBildirimi AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where Tarih=@p1 AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Yemek Bildirimi Ara Tarihe Göre
        public static void YemekBildirimSil(int ID,string adsoyad,DateTime Tarih)
        {
            cmd = new SqlCommand("Update YemekBildirimi set Durumu='false' where YemekBildirimID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(adsoyad + " " + "adlı Öğrencinin"+" "+Tarih.ToLongDateString()+" "+" Tarihli Kaydını Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yemek Bildirimi Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }
        public static DataTable YemekBildirimiVeli(int ogrenciID)
        {
            da = new SqlDataAdapter("Select YemekBildirimID,ADSOYAD,Tarih,Aciklama AS 'Yemeğini Yedimi' from YemekBildirimi AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where OgrenciID=@p1 AND a.Durumu='True' ", Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public static DataTable YemekBildirimiVeli(int ogrenciID,DateTime tarih)
        {
            da = new SqlDataAdapter("Select YemekBildirimID,ADSOYAD,Tarih,Aciklama AS 'Yemeğini Yedimi' from YemekBildirimi AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where OgrenciID=@p1 AND Tarih=@p2 AND a.Durumu='True' ", Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID);
            da.SelectCommand.Parameters.AddWithValue("@p2", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
