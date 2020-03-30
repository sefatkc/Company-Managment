using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace VTYS
{
    class DAO_Proje
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
        public static void cagirCheckListBox(CheckedListBox checkedListBox, String tabName)
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                //MessageBox.Show("Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string cek = $"select * from {tabName} where Durum = 1;";

            SqlCommand test = new SqlCommand(cek, baglanti);
            SqlDataReader dr = test.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    checkedListBox.Items.Add(dr.GetString(1) + " " + dr.GetString(2));
                }
            }
            baglanti.Close();
        }
        public static void cagirComboBox(ComboBox comboBox, String tabName)
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                //MessageBox.Show("Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string cek = $"select * from {tabName};";

            SqlCommand test = new SqlCommand(cek, baglanti);
            SqlDataReader dr = test.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox.Items.Add(dr.GetString(1) + " " + dr.GetString(2));
                }
            }
            baglanti.Close();
        }
        public static int IdEkleProje(String tabloName, string ad)
        {
            baglanti.Open();
            string[] ad1 = ad.Split();
            string cek = $"select * from {tabloName} where P_Name = '{ad}';";/*İsme Göre select yapıp cek komutu olarak adlandırdık */
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
        public static int IdEkleChecklist(String tabloName, string ad)
        {
            baglanti.Open();
            string[] ad1 = ad.Split();
            string cek = $"select * from {tabloName} where P_name = '{ad1[0]}' and P_surname = '{ad1[1]}' and Durum = 1;";/*İsme Göre select yapıp cek komutu olarak adlandırdık */
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
        public static int cagirComboBoxID(ComboBox comboBox, String tabName)
        {
            baglanti.Open();
            String[] select;
            string selected = comboBox.GetItemText(comboBox.SelectedItem);
            select = selected.Split();
            string cek = $"select * from {tabName} where P_name = '{select[0]}' and P_surname = '{select[1]}' and Durum = 1;";
            SqlCommand test = new SqlCommand(cek, baglanti);
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
