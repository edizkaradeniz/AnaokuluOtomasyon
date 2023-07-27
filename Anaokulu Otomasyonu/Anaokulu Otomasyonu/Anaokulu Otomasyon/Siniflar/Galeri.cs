using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Anaokulu_Otomasyon.Siniflar
{
    class Galeri
    {
        #region Degiskenler
        public static int ResimID;
        public static string ResimAdi;
        public static DateTime ResimTarihi;
        public static string ResimYolu;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        public static List<string> Liste;
        #endregion
        #region Fonksiyonlar
        public static void Resimekle(string adi, DateTime tarih, string resimyolu) //Resim Ekle
        {
            cmd = new SqlCommand("INSERT INTO Galeri(ResimAdi,Tarih,ResimYolu) values(@p1,@p2,@p3)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", adi);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", resimyolu);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Resim Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ResimGuncelle(string adi, DateTime tarih, string resimyolu,int ID) //Resim Guncelle
        {
            cmd = new SqlCommand("UPDATE Galeri set ResimAdi=@p1,Tarih=@p2,ResimYolu=@p3 where ResimID=@p4", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", adi);
            cmd.Parameters.AddWithValue("@p2", tarih);
            cmd.Parameters.AddWithValue("@p3", resimyolu);
            cmd.Parameters.AddWithValue("@p4", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Resim Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DataTable ResimListele() //Resim Listele 
        {
            da = new SqlDataAdapter("Select ResimID,ResimAdi,Tarih,ResimYolu from Galeri where Durumu='1'", Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void ResimSil(int ID,DateTime tarih) //Resim Sil
        {
            cmd = new SqlCommand("UPDATE Galeri set Durumu='false' where ResimID=@p1",Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(tarih.ToLongDateString() + " " + "Tarihli Resmi Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        }
        public static List<String> ResimYollarınıcek()//Resim Yollarını cek
        {
            Liste = new List<string>();
            cmd = new SqlCommand("Select ResimYolu from Galeri where Durumu='1' ", Baglanti.baglan());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Liste.Add(dr["ResimYolu"].ToString());
            }
            return Liste;
        }
        #endregion

    }
}
