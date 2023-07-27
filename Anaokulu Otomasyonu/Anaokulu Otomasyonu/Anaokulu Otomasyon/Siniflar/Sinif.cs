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
  public  class Sinif
    {
        #region Degiskenler
        static FrmOgrenci frm = new FrmOgrenci();
        public static int ID;
        public static string Sinifadi;
        public static int Kontenjan;
        public static string Donem;
        public static int OgretmenID;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        #endregion Degiskenler
        #region Fonksiyonlar
        public static DataTable comboboxsiniflarigetir()
        {
            dt = new DataTable();
            da = new SqlDataAdapter("Select SınıfID,Adi from Sinif where Durumu='1' ", Baglanti.baglan());
            da.Fill(dt);
            return dt;
        }//Comboboxlara Sınıf Adlarını ve ona karşılık gelen ID getirme
        public static void Sinifekle(string sinifadi,int kontenjan,string donem,int ogretmenID)
        {
            cmd = new SqlCommand("INSERT INTO Sinif(Adi,Kontenjan,Dönem,OgretmenID) values(@p1,@p2,@p3,@p4)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", sinifadi);
            cmd.Parameters.AddWithValue("@p2", kontenjan);
            cmd.Parameters.AddWithValue("@p3", donem);
            cmd.Parameters.AddWithValue("@p4", ogretmenID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sınıf Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Sınıf Ekle
        public static DataTable SinifListele()
        {
            string sqlcumle = "Select SınıfID,Adi,Kontenjan,a.Dönem,ADSOYAD from Sinif AS a INNER JOIN Ogretmen AS b ON a.OgretmenID=b.OgretmenID where a.Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Sınıf Listele
        public static void Guncelle(string sinifadi, int kontenjan, string donem, int ogretmenID,int id)
        {
            cmd = new SqlCommand("UPDATE Sinif set Adi=@p1,Kontenjan=@p2,Dönem=@p3,OgretmenID=@p4 where SınıfID=@p5", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", sinifadi);
            cmd.Parameters.AddWithValue("@p2",kontenjan);
            cmd.Parameters.AddWithValue("@p3",donem);
            cmd.Parameters.AddWithValue("@p4",ogretmenID);
            cmd.Parameters.AddWithValue("@p5",id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sinif Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Sınıf Guncelle
        public static void SinifSil(int id,string ad)
        {
            cmd = new SqlCommand("UPDATE Sinif set Durumu='false' where SınıfID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", id);
            DialogResult cevap;
            cevap = MessageBox.Show(ad + " " + "adlı Sınıfı Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        } //Sinif Sil
        public static DataTable SinifAra(string ad)
        {
            string sqlcumle = "Select SınıfID,Adi,Kontenjan,a.Dönem,ADSOYAD from Sinif AS a INNER JOIN Ogretmen AS b ON a.OgretmenID=b.OgretmenID where Adi LIKE '%'+@p1+'%'AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ad);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } // Sinif Adına Göre Sınıf Ara
        public static DataTable SinifAraDonem(string donem)
        {
            string sqlcumle = "Select SınıfID,Adi,Kontenjan,a.Dönem,ADSOYAD from Sinif AS a INNER JOIN Ogretmen AS b ON a.OgretmenID=b.OgretmenID where a.Dönem=@p1 AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", donem);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }//Döneme Göre Sınıf Ara
        #endregion
    }
}
