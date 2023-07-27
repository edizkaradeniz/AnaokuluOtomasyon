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
  public  class Etkinlik
    {
        #region Degiskenler
        public static int EtkinlikID;
        public static DateTime EtkinlikTarih;
        public static string EtkinlikBaslik;
        public static string Etkinlikİcerik;
        public static string EtkinlikDonem;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        #endregion
        #region Fonksiyonlar
        public static DataTable EtkinlikListele()
        {
            string sqlcumle = "Select EtkinlikID,Tarih,Baslik,İcerik,Donem from Etkinlik where Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Etkinlik Listele
        public static void EtkinlikEkle(DateTime tarih,string baslik,string icerik,string donem) //Etkinlik Ekle
        {
            cmd = new SqlCommand("Insert INTO Etkinlik(Tarih,Baslik,İcerik,Donem) values(@p1,@p2,@p3,@p4)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", tarih);
            cmd.Parameters.AddWithValue("@p2", baslik);
            cmd.Parameters.AddWithValue("@p3", icerik);
            cmd.Parameters.AddWithValue("@p4", donem);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Etkinlik Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void EtkinlikGuncelle(DateTime tarih, string baslik, string icerik, string donem,int ID) //Etkinlik Guncelle
        {
            cmd = new SqlCommand("Update Etkinlik set Tarih=@p1,Baslik=@p2,İcerik=@p3,Donem=@p4 where EtkinlikID=@p5",Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", tarih);
            cmd.Parameters.AddWithValue("@p2", baslik);
            cmd.Parameters.AddWithValue("@p3", icerik);
            cmd.Parameters.AddWithValue("@p4", donem);
            cmd.Parameters.AddWithValue("@p5", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Etkinlik Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void EtkinlikSil(int ID,DateTime tarih)
        {
            cmd = new SqlCommand("Update Etkinlik set Durumu='false' where EtkinlikID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(tarih.ToLongDateString() + " " + "Tarihli Etkinliği Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        }
        public static DataTable EtkinlikAraDonem(string donem)
        {
            string sqlcumle = "Select EtkinlikID,Tarih,Baslik,İcerik,Donem from Etkinlik where Donem=@p1 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", donem);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable EtkinlikAraTarih(DateTime tarih)
        {
            string sqlcumle = "Select  EtkinlikID,Tarih,Baslik,İcerik,Donem from Etkinlik where Tarih=@p1 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", tarih);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion
    }
}
