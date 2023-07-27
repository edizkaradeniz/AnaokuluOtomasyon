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
   public class DersProgrami
    {
        #region Degiskenler
        public static int DersProgramiID;
        public static DateTime Tarih;
        public static string Donem;
        public static string Ders1;
        public static string Ders2;
        public static string Ders3;
        public static string Ders4;
        public static string Ders5;
        public static string Ders6;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static DataTable dt;
        #endregion
        #region Fonksiyonlar
        public static DataTable DersProgramiListele()
        {
            string sqlcumle = "Select DersProgramiID,Ders1 AS '1.DERS',Ders2 AS '2.DERS',Ders3 AS '3.DERS',Ders4 AS '4.DERS',Ders5 AS '5.DERS',Ders6 AS '6.DERS',Dönem,Tarih from DersProgrami where Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //Ders Programi Listele
        public static void DersprogramiEkle(string ders1,string ders2,string ders3,string ders4,string ders5,string ders6,string donem,DateTime dt)
        {
            cmd = new SqlCommand("Insert Into Dersprogrami(Ders1,Ders2,Ders3,Ders4,Ders5,Ders6,Dönem,Tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1",ders1);
            cmd.Parameters.AddWithValue("@p2",ders2);
            cmd.Parameters.AddWithValue("@p3",ders3);
            cmd.Parameters.AddWithValue("@p4",ders4);
            cmd.Parameters.AddWithValue("@p5",ders5);
            cmd.Parameters.AddWithValue("@p6",ders6);
            cmd.Parameters.AddWithValue("@p7",donem);
            cmd.Parameters.AddWithValue("@p8",dt);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ders Programı Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Ders Programi Ekle
        public static void DersprogramiGuncelle(string ders1, string ders2, string ders3, string ders4, string ders5, string ders6, string donem, DateTime dt,int ID)
        {
            cmd = new SqlCommand("UPDATE DersProgrami set Ders1=@p1,Ders2=@p2,Ders3=@p3,Ders4=@p4,Ders5=@p5,Ders6=@p6,Dönem=@p7,Tarih=@p8 where DersprogramiID=@p9", Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ders1);
            cmd.Parameters.AddWithValue("@p2", ders2);
            cmd.Parameters.AddWithValue("@p3", ders3);
            cmd.Parameters.AddWithValue("@p4", ders4);
            cmd.Parameters.AddWithValue("@p5", ders5);
            cmd.Parameters.AddWithValue("@p6", ders6);
            cmd.Parameters.AddWithValue("@p7", donem);
            cmd.Parameters.AddWithValue("@p8", dt);
            cmd.Parameters.AddWithValue("@p9", ID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ders Programı Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   //Ders Programi Güncelle
        public static void DersProgramiSil(int ID,DateTime tarih)//Ders Programi Sil
        {
            cmd = new SqlCommand("Update DersProgrami set Durumu='false' where DersProgramiID=@p1",Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", ID);
            DialogResult cevap;
            cevap = MessageBox.Show(tarih.ToLongDateString() + " " + "Tarihli Ders Programını Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {

            }

        }   
        public static DataTable DersprogramiAraTarih(DateTime date)
        {
            string sqlcumle = "Select DersProgramiID,Ders1 AS '1.DERS',Ders2 AS '2.DERS',Ders3 AS '3.DERS',Ders4 AS '4.DERS',Ders5 AS '5.DERS',Ders6 AS '6.DERS',Dönem,Tarih from DersProgrami where Tarih=@p1 AND Durumu='1'";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1",date);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        } //DersProgrami Ara Tarihe Göre
        public static DataTable DersProgramiAraDonem(string donem)
        {
            string sqlcumle = "Select DersProgramiID,Ders1 AS '1.DERS',Ders2 AS '2.DERS',Ders3 AS '3.DERS',Ders4 AS '4.DERS',Ders5 AS '5.DERS',Ders6 AS '6.DERS',Dönem,Tarih from DersProgrami where Dönem=@p1 AND Durumu='1' ";
            da = new SqlDataAdapter(sqlcumle, Baglanti.baglan());
            da.SelectCommand.Parameters.AddWithValue("@p1", donem);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }  //Ders Programi Ara Doneme Göre
        
        #endregion
    }
}
