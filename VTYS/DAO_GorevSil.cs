using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace VTYS
{
    class DAO_GorevSil
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
        public static void cagir(ComboBox comboBox)
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                //MessageBox.Show("Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string cek = "select * from Duty;";
            SqlCommand test = new SqlCommand(cek, baglanti);
            SqlDataReader dr = test.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox.Items.Add(dr.GetString(1));
                }
            }
            //Duty_name

            baglanti.Close();
        }
    }
}
