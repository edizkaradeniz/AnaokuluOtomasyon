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
   public class Duyuru
    {
        #region Degiskenler
        public static int DuyuruID;
        public static DateTime Duyurutarih;
        public static string DuyuruBaslik;
        public static string Duyuruİcerik;
        public static string Donem;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        #endregion
        #region Fonksiyonlar
        public static void DuyuruEkle(DateTime tarih,string baslik,string icerik,string donem) //Duyuru Ekle
        {
            cmd = new SqlCommand("Insert INTO Duyuru(Tarih,Baslik,İcerik,Dönem) values(@p1,@p2,@p3,@p4)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", tarih);
            cmd.Parameters.AddWithValue("@p2", baslik);
            cmd.Parameters.AddWithValue("@p3", icerik);
            cmd.Parameters.AddWithValue("@p4", donem);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Duyuru Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DataTable DuyuruListele() //Duyuru Listele
        {
            string sqlcumle = "Select DuyuruID,Tarih,Baslik,İcerik,Dönem from Duyuru where Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void DuyuruGuncelle(DateTime tarih, string baslik, string icerik, string donem, int ID) //Duyuru Guncelle
        {
            cmd = new SqlCommand("Update Duyuru set Tarih=@p1,Baslik=@p2,İcerik=@p3,Dönem=@p4 where DuyuruID=@p5", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", tarih);
            cmd.Parameters.AddWithValue("@p2", baslik);
            cmd.Parameters.AddWithValue("@p3", icerik);
            cmd.Parameters.AddWithValue("@p4", donem);
            cmd.Parameters.AddWithValue("@p5", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Duyuru Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void DuyuruSil(int ID,DateTime tarih) //Duyuru Sil
        {
            cmd = new SqlCommand("Update Duyuru set Durumu='false' where DuyuruID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(tarih.ToLongDateString() + " " + "Tarihli Duyuruyu Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }

        }
        public static DataTable DuyuruAraTarih(DateTime date)
        {
            string sqlcumle = "Select DuyuruID,Tarih,Baslik,İcerik,Dönem from Duyuru where Tarih=@p1 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", date);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable DuyuruAraDonem(string donem)
        {
            string sqlcumle = "Select DuyuruID,Tarih,Baslik,İcerik,Dönem from Duyuru where Dönem=@p1 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", donem);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




        #endregion
    }
}
