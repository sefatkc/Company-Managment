using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VTYS
{   
    class DAO_Personel
    {

        public static SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
        public static void cagirCheckListBox(CheckedListBox checkedListBox, String tabName)
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                //MessageBox.Show("Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string cek = $"select distinct Expertise_field from {tabName};";

            SqlCommand test = new SqlCommand(cek, baglanti);
            SqlDataReader dr = test.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    checkedListBox.Items.Add(dr.GetString(0));
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
                    comboBox.Items.Add(dr.GetString(1));
                }
            }
            baglanti.Close();
        }
        public static int IdEkle(ComboBox combobox, String tabloName, String columnName)
        {
            baglanti.Open();
            string selected = combobox.GetItemText(combobox.SelectedItem);
            string cek = $"select * from {tabloName} where {columnName} = '{selected}';";
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
        public static String IdPass(String tabloName, String columnName, TextBox textBox)
        {
            baglanti.Open();
            string cek = $"select * from {tabloName} where {columnName} = '{textBox.Text}';";
            SqlCommand test = new SqlCommand(cek, baglanti);
            SqlDataReader dr = test.ExecuteReader();
            string a = "1";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    a = dr.GetString(0);
                }
            }
            baglanti.Close();
            return a;
        }
        public static int IdEkleChecklist(String tabloName, string ad, string soyad)
        {
            baglanti.Open();
            string[] ad1 = ad.Split();
            string cek = $"select * from {tabloName} where P_name = '{ad}' and P_surname = '{soyad}';";/*İsme Göre select yapıp cek komutu olarak adlandırdık */
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
        public static void passwordEkle(TextBox textBox, TextBox textBox2, ComboBox comboBox)
        {
            baglanti.Open();
            string selected = comboBox.GetItemText(comboBox.SelectedItem);
            string cmd = $"insert into PersonelLogin (O_TC, Password, Yetki) values('{textBox.Text}','{textBox2.Text}','{selected}');";
            SqlCommand sqlCommand = new SqlCommand(cmd, baglanti);
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();
        }

    }
}
