using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Anaokulu_Otomasyon.Siniflar
{
    public class Yonetici
    {
        #region Degiskenler
        public static int ID;
        public static string ADSOYAD;
        public static string KullaniciAdi;
        public static string Sifre;
        #endregion
        #region Fonksiyonlar
        public static bool GirisYap(string Kulad, string sifre) //Yönetici Giriş Doğrulama 
        {
            string command = "Select * from Yonetici where KullaniciAdi=@p1 AND Sifre=@p2";
            SqlCommand cmd = new SqlCommand(command, Baglanti.baglan());
            cmd.Parameters.AddWithValue("@p1", Kulad);
            cmd.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ID = int.Parse(dr["YoneticiID"].ToString());
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
