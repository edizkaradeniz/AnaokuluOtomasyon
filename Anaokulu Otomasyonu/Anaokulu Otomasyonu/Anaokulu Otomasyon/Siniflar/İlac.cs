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
   public class İlac
    {
        #region Degiskenler
        public static int İlacID;
        public static int OgrenciID;
        public static string İlacAdi;
        public static string İlacAciklama;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataTable dt;
        #endregion
        #region Fonksiyonlar
        public static DataTable İlacListele() //İlaç Kullanan Öğrencileri Listeler
        {
            string sqlcumle = "Select İlacID,ADSOYAD,İlacAdi,İlacAciklama,Adi AS Sınıfı from İlac AS a INNER JOIN Ogrenci AS b ON OgrenciID=OgrID INNER JOIN Sinif AS c ON b.SınıfID=c.SınıfID where a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable İlacAraSinif(string sinif)
        {
            string sqlcumle = "Select İlacID,ADSOYAD,İlacAdi,İlacAciklama,Adi AS Sınıfı from İlac AS a INNER JOIN Ogrenci AS b ON OgrenciID=OgrID INNER JOIN Sinif AS c ON b.SınıfID=c.SınıfID where c.Adi=@p1 AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", sinif);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //İlaç Arama Sinifa Göre
        public static DataTable İlacAraADSOYAD(string adsoyad)
        {
            string sqlcumle = "Select İlacID,ADSOYAD,İlacAdi,İlacAciklama,Adi AS Sınıfı from İlac AS a INNER JOIN Ogrenci AS b ON OgrenciID=OgrID INNER JOIN Sinif AS c ON b.SınıfID=c.SınıfID where b.ADSOYAD LIKE '%'+@p1+'%' AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", adsoyad);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //İlaç ara Adsoyad'a Göre
        public static void İlacEkle(int ogrenciID,string ilacadi,string ilacaciklama)
        {
            cmd = new SqlCommand("Insert INTO İlac(OgrenciID,İlacAdi,İlacAciklama) values(@p1,@p2,@p3)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1",ogrenciID);
            cmd.Parameters.AddWithValue("@p2", ilacadi);
            cmd.Parameters.AddWithValue("@p3", ilacaciklama);
            cmd.ExecuteNonQuery();
            MessageBox.Show("İlaç Başarıyla Eklendi", "Kayıt EKleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //İlaç Ekle Veli
        public static void İlacGuncelle(string ilacadi, string ilacaciklama,int ID)
        {
            cmd = new SqlCommand("Update İlac set İlacAdi=@p1,İlacAciklama=@p2 where İlacID=@p3", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ilacadi);
            cmd.Parameters.AddWithValue("@p2", ilacaciklama);
            cmd.Parameters.AddWithValue("@p3", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("İlaç Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static  DataTable İlacListeleVeli(int ogrenciID)
        {
            string sqlcumle = "Select İlacID,ADSOYAD,İlacAdi,İlacAciklama from İlac AS a INNER JOIN Ogrenci AS b ON OgrenciID=OgrID where OgrID=@p1 AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void İlacSil(int ID,string ilac)
        {
            cmd = new SqlCommand("Update İlac set Durumu='false' where İlacID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(ilac + " " + "adli İlacı Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        }
        #endregion
    }
}
