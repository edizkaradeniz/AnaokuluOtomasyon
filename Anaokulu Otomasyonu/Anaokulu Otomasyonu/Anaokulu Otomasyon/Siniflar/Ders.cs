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
  public class Ders
    {
        #region Degiskenler
        public static int DersID;
        public static string DersAdi;
        public static string DersAciklama;
        public static DataTable dt;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        #endregion
        #region Fonksiyonlar
        public static DataTable Listele()
        {
            string sqlcumle = "Select DersID,DersAdi,Aciklama from Ders where Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Ders Listele
        public static void DersEkle(string ders,string Aciklama)
        {
            cmd = new SqlCommand("Insert Into Ders(DersAdi,Aciklama) values(@p1,@p2)",Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ders);
            cmd.Parameters.AddWithValue("@p2", Aciklama);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ders Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Ders Ekle
        public static void DersGuncelle(string ders,string Aciklama,int ID)
        {
            cmd = new SqlCommand("UPDATE Ders set DersAdi=@p1,Aciklama=@p2 where DersID=@p3", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ders);
            cmd.Parameters.AddWithValue("@p2", Aciklama);
            cmd.Parameters.AddWithValue("@p3", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ders Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }  //Ders Güncelle
        public static DataTable DersAra(string ders)
        {
            string sqlcumle = "Select DersID,DersAdi,Aciklama from Ders Where DersAdi LIKE '%'+@p1+'%' AND Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", ders);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Ders Adina Göre Ders Arama
        public static void DersSil(int id,string adsoyad)
        {
            cmd = new SqlCommand("UPDATE Ders set Durumu='false' where DersID=@p1", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", id);
            DialogResult cevap;
            cevap = MessageBox.Show(adsoyad + " " + "adlı Dersi Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
        } //Ders Silme
        #endregion

    }
}
