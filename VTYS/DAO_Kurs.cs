using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VTYS
{
    class DAO_Kurs
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
        public static int IdEkle(String tabloName, string ad)
        {
            baglanti.Open();
            string[] ad1 = ad.Split();
            string cek = $"select * from {tabloName} where P_name = '{ad1[0]}' and P_surname = '{ad1[1]}';";/*İsme Göre select yapıp cek komutu olarak adlandırdık */
            SqlCommand test = new SqlCommand(cek, baglanti);/*cek komutunu sql servere yolladık */
            SqlDataReader dr = test.ExecuteReader();
            int a = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    a = dr.GetInt32(0);
                }
            }
            baglanti.Close();
            return a;
        }
    }
}
