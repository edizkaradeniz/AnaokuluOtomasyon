using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace Anaokulu_Otomasyon.Siniflar
{
   public class Veli
    {
        #region Degiskenler
        public static int ID;
        public static string ADSOYAD;
        public static int OGRID;
        public static string telefon;
        public static string adres;
        public static string Kuladi;
        public static string Sifre;
        public static int Yillikfiyat;
        public static string Donemi;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static DataTable dt;
        #endregion
        #region Fonksiyonlar
        public static DataTable VeliListele()
        {
            string sqlcumle = "Select VeliID,a.ADSOYAD,b.ADSOYAD AS ÖğrenciAdSoyad,Telefon,Adres,KullaniciAdi,Sifre,YillikFiyat,a.Dönemi from Veli AS a INNER JOIN Ogrenci AS b ON a.OGRID=b.OgrID where a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }//Veli Listele
        public static void Veliekle(string adsoyad,int ogrID,string telefon,string Adres,string kulad,string Sifre,int yillikfiyat,string dönemi)
        {
            cmd = new SqlCommand("INSERT INTO veli(ADSOYAD,OGRID,Telefon,Adres,KullaniciAdi,Sifre,YillikFiyat,Dönemi,Durumu) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,1)",Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1",adsoyad);
            cmd.Parameters.AddWithValue("@p2",ogrID);
            cmd.Parameters.AddWithValue("@p3",telefon);
            cmd.Parameters.AddWithValue("@p4",Adres);
            cmd.Parameters.AddWithValue("@p5",kulad);
            cmd.Parameters.AddWithValue("@p6",Sifre);
            cmd.Parameters.AddWithValue("@p7",yillikfiyat);
            cmd.Parameters.AddWithValue("@p8",dönemi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Veli Başarıyla Eklendi", "Kayıt EKleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }  //Veli Ekleme 
        public static void VeliGuncelle(string adsoyad, int ogrID, string telefon, string Adres, string kulad, string Sifre, int yillikfiyat, string dönemi,int id) //Veli Güncelle
        {
            cmd = new SqlCommand("UPDATE veli set ADSOYAD=@p1,OGRID=@p2,Telefon=@p3,Adres=@p4,KullaniciAdi=@p5,Sifre=@p6,YillikFiyat=@p7,Dönemi=@p8 where VeliID=@p9", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", adsoyad);
            cmd.Parameters.AddWithValue("@p2", ogrID);
            cmd.Parameters.AddWithValue("@p3", telefon);
            cmd.Parameters.AddWithValue("@p4", Adres);
            cmd.Parameters.AddWithValue("@p5", kulad);
            cmd.Parameters.AddWithValue("@p6", Sifre);
            cmd.Parameters.AddWithValue("@p7", yillikfiyat);
            cmd.Parameters.AddWithValue("@p8", dönemi);
            cmd.Parameters.AddWithValue("@p9", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Veli Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DataTable VeliAra(string dönem)//Döneme Göre Arama
        {
            string sqlcumle = "Select VeliID,a.ADSOYAD,b.ADSOYAD AS ÖğrenciAdSoyad,Telefon,Adres,KullaniciAdi,Sifre,YillikFiyat,a.Dönemi from Veli AS a INNER JOIN Ogrenci AS b ON a.OGRID=b.OgrID where a.Durumu='1' AND a.Dönemi=@p1";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", dönem);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void VeliSil(int id,string adsoyad) //Veli Silme
        {
            string sqlcumle = "Update Veli Set Durumu='false' where VeliID=@p1";
            cmd = new SqlCommand(sqlcumle, Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", id);
            DialogResult cevap;
            cevap = MessageBox.Show(adsoyad + " " + "adlı Veliyi Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        }
        public static  DataTable VeliAraAD(string adsoyad) //Veli Adına Göre Arama
        {
            string sqlcumle = "Select VeliID,a.ADSOYAD,b.ADSOYAD AS ÖğrenciAdSoyad,Telefon,Adres,KullaniciAdi,Sifre,YillikFiyat,a.Dönemi from Veli AS a INNER JOIN Ogrenci AS b ON a.OGRID=b.OgrID where a.ADSOYAD LIKE '%'+@p1+'%' AND a.Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", adsoyad);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable ComboboxVeliADSOYADcek()//Veli AD-Soyad Çekme Comboboxlara
        {
            da = new SqlDataAdapter("Select VeliID,ADSOYAD from Veli where Durumu='1' ",Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool GirisYap(string kulad,string sifre)
        {
            string command = "Select * from Veli where KullaniciAdi=@p1 AND Sifre=@p2";
            SqlCommand cmd = new SqlCommand(command, Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", kulad);
            cmd.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ID = int.Parse(dr["VeliID"].ToString());
                ADSOYAD = dr["ADSOYAD"].ToString();
                OGRID = int.Parse(dr["OGRID"].ToString());
                return true;
            }
            else
            {
                return false;
            }
        } //Veli Girişi Doğrulama
        #endregion
    }
}
