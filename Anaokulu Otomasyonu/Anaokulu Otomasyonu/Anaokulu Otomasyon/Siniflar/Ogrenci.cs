using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Anaokulu_Otomasyon.Siniflar
{
    public class Ogrenci
    {
        #region Degiskenler
        public static int ID;
        public static string ADSOYAD;
        public static string TC;
        public static string DogumTarihi;
        public static string Cinsiyet;
        public static int SinifID;
        public static DateTime KayitTarihi;
        public static string Donemi;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static DataTable dt;
        #endregion
        #region Fonksiyonlar
        public static void OgrenciEkle(string adsoyad, string tc, DateTime dogumtarihi, string cinsiyet, int sinifID, DateTime kayittarihi, string donemi)//Öğrenci Ekleme
        {

            cmd = new SqlCommand("INSERT INTO Ogrenci(ADSOYAD,TC,DogumTarihi,Cinsiyet,SınıfID,KayitTarihi,Dönemi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", adsoyad);
            cmd.Parameters.AddWithValue("@p2", tc);
            cmd.Parameters.AddWithValue("@p3", dogumtarihi);
            cmd.Parameters.AddWithValue("@p4", cinsiyet);
            cmd.Parameters.AddWithValue("@p5", sinifID);
            cmd.Parameters.AddWithValue("@p6", kayittarihi);
            cmd.Parameters.AddWithValue("@p7", donemi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Başarıyla Eklendi", "Kayıt EKleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void OgrenciGuncelle(string adsoyad, string tc, DateTime dogum, string cinsiyet, int sinifID, DateTime kayit, string donem, int id)
        {

            cmd = new SqlCommand("UPDATE Ogrenci set ADSOYAD=@p1,TC=@p2,DogumTarihi=@p3,Cinsiyet=@p4,SınıfID=@p5,KayitTarihi=@p6,Dönemi=@p7 where OgrID=@p8", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", adsoyad);
            cmd.Parameters.AddWithValue("@p2", tc);
            cmd.Parameters.AddWithValue("@p3", dogum);
            cmd.Parameters.AddWithValue("@p4", cinsiyet);
            cmd.Parameters.AddWithValue("@p5", sinifID);
            cmd.Parameters.AddWithValue("@p6", kayit);
            cmd.Parameters.AddWithValue("@p7", donem);
            cmd.Parameters.AddWithValue("@p8", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Öğrenci Güncelleme
        public static DataTable Listele()//Tüm Öğrencileri Çekme
        {
            string sqlcumle = "Select OgrID,ADSOYAD,TC,DogumTarihi,Cinsiyet,Adi,KayitTarihi,Dönemi from Ogrenci AS a INNER JOIN Sinif AS b ON a.SınıfID=b.SınıfID where a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable Arama(string arama)//Döneme Göre Öğrenci Arama
        {
            string sqlcumle = "Select OgrID,ADSOYAD,TC,DogumTarihi,Cinsiyet,Adi,KayitTarihi,Dönemi from Ogrenci AS a INNER JOIN Sinif AS b ON a.SınıfID=b.SınıfID where a.Dönemi=@p1 AND a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", arama);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable Textboxara(string arama)
        {
            string sqlcumle = "Select OgrID,ADSOYAD,TC,DogumTarihi,Cinsiyet,Adi,KayitTarihi,Dönemi from Ogrenci AS a INNER JOIN Sinif AS b ON a.SınıfID=b.SınıfID where ADSOYAD LIKE '%'+@p1+'%' AND a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", arama);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Öğrenci ADSOYAD göre Arama İşlemi
        public static void OgrenciSil(int ID,string adsoyad)
        {
            string sqlcumle = "Update Ogrenci Set Durumu='false' where ogrID=@p1";
            cmd = new SqlCommand(sqlcumle, Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(adsoyad + " " + "Adlı Öğrenciyi Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }

        } //Öğrenci Sil
        public static DataTable OgrenciAdsoyadCEK()
        {
            da = new SqlDataAdapter("Select OGRID,ADSOYAD from Ogrenci where Durumu='1'", Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Öğrenci ADSOYAD ve ona Karşılık Gelen ID'leri Çekme
        public static DataTable OgrenciAraSinif(int ID) //Öğrenciyi Sinifa Göre Arama
        {
            string sqlcumle = "Select OgrID,ADSOYAD,TC,DogumTarihi,Cinsiyet,Adi,KayitTarihi,Dönemi from Ogrenci AS a INNER JOIN Sinif AS b ON a.SınıfID=b.SınıfID where a.SınıfID=@p1 AND a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable OgrenciVeliCek(int veliID)
        {
            da = new SqlDataAdapter("SELECT b.OGRID,a.ADSOYAD FROM Veli AS b INNER JOIN Ogrenci AS a ON b.OGRID=a.OgrID WHERE VeliID=@p1 AND b.Durumu='1'", Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", veliID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
