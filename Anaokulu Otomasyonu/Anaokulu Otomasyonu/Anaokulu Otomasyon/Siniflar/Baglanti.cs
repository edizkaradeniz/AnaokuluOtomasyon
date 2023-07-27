using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Anaokulu_Otomasyon.Siniflar
{ //Tüm Formlara Veritabanı baglantisi
  public  class Baglanti
    {
        
        
      public static SqlConnection cnn;
       
        public static SqlConnection baglan()
        {
            cnn = new SqlConnection(@"Data Source=LAPTOP-9IQ5NO3T\SQLEXPRESS;Initial Catalog=Anaokuludb;Integrated Security=True;");
            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.Open();
            }
            return cnn;
        }  //Veritabanı Bağlantısı Açma
    }
}
