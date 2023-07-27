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
    public class Ogretmen
    {
        #region Degiskenler
        public static int OgretmenID;
        public static string ADSOYAD;
        public static string TC;
        public static DateTime dogumtarihi;
        public static string Adres;
        public static int Maas;
        public static string telefon;
        public static string KullaniciAdi;
        public static string Sifre;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        #endregion
        #region Fonksiyonlar
        public static void OgretmenEkle(string adsoyad, string tc, DateTime dogumtarih, string adres, int maas, string Telefon, string kullaniciadi, string sifre)
        {
            cmd = new SqlCommand("INSERT INTO Ogretmen(ADSOYAD,TC,DogumTarihi,Adres,Maas,Telefon,KullaniciAdi,Sifre) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", adsoyad);
            cmd.Parameters.AddWithValue("@p2", tc);
            cmd.Parameters.AddWithValue("@p3", dogumtarih);
            cmd.Parameters.AddWithValue("@p4", adres);
            cmd.Parameters.AddWithValue("@p5", maas);
            cmd.Parameters.AddWithValue("@p6", Telefon);
            cmd.Parameters.AddWithValue("@p7", kullaniciadi);
            cmd.Parameters.AddWithValue("@p8", sifre);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğretmen Başarıyla Eklendi", "Kayıt EKleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Öğretmen Ekle
        public static DataTable OgretmenListele()
        {
            string sqlcumle = "Select OgretmenID,ADSOYAD,TC,DogumTarihi,Adres,Maas,Telefon,KullaniciAdi,Sifre from Ogretmen where Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } // Öğretmen Listele
        public static void OgretmenGuncelle(string adsoyad, string tc, DateTime DogumTarihi, string adres, int maas, string Telefon, string kullaniciadi, string sifre, int ID)
        {
            cmd = new SqlCommand("UPDATE Ogretmen SET ADSOYAD=@p1,TC=@p2,DogumTarihi=@p3,Adres=@p4,Maas=@p5,Telefon=@p6,KullaniciAdi=@p7,Sifre=@p8 where OgretmenID=@p9", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", adsoyad);
            cmd.Parameters.AddWithValue("@p2", tc);
            cmd.Parameters.AddWithValue("@p3", DogumTarihi);
            cmd.Parameters.AddWithValue("@p4", adres);
            cmd.Parameters.AddWithValue("@p5", maas);
            cmd.Parameters.AddWithValue("@p6", Telefon);
            cmd.Parameters.AddWithValue("@p7", kullaniciadi);
            cmd.Parameters.AddWithValue("@p8", sifre);
            cmd.Parameters.AddWithValue("@p9", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğretmen Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Öğretmen Güncelle
        public static void OgretmenSil(int id,string adsoyad)
        {
            string sqlcumle = "Update Ogretmen Set Durumu='false' where OgretmenID=@p1";
            cmd = new SqlCommand(sqlcumle, Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", id);
            DialogResult cevap;
            cevap = MessageBox.Show(adsoyad + " " + "adlı Öğretmeni Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        } //Öğretmen Sil
        public static DataTable OgretmenAra(string adsoyad)
        {
            string sqlcumle = "Select OgretmenID,ADSOYAD,TC,DogumTarihi,Adres,Maas,Telefon,KullaniciAdi,Sifre from Ogretmen where ADSOYAD LIKE '%'+@p1+'%' AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", adsoyad);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //ADSOYAD'a göre Öğretmen Ara
        public static DataTable OgretmenAdSoyadGetir() //Comboboxlara Öğretmen ADSOYAD ve Ona Karşılık Gelen ID getirme
        {
            da = new SqlDataAdapter("Select OgretmenID,ADSOYAD from Ogretmen where Durumu='1'", Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool GirisYap(string Kulad, string sifre) //Öğretmen Giriş Doğrulama 
        {
            string command = "Select * from Ogretmen where KullaniciAdi=@p1 AND Sifre=@p2";
            SqlCommand cmd = new SqlCommand(command, Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", Kulad);
            cmd.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                OgretmenID = int.Parse(dr["OgretmenID"].ToString());
                ADSOYAD = dr["ADSOYAD"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
