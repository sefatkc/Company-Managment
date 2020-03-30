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
    class DAO_Personel_Guncelle
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
        public static void cagir(ComboBox comboBox)
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                //MessageBox.Show("Succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string cek = "select * from Personel where Durum = 1;";
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
        public static string strcek(string tname, string cname, int id)
        {
            baglanti.Open();
            string rt = "";
            string cek = $"select * from {tname} where {cname} ={id};";
            SqlCommand s = new SqlCommand(cek, baglanti);
            SqlDataReader dr = s.ExecuteReader();
            while (dr.Read())
            {
                rt = dr.GetString(1);
            }
            baglanti.Close();
            return rt;
        }
        public static void strcek_hepsi(ComboBox comboBox,string tname)
        {
            baglanti.Open();
            string cek = $"select * from {tname};";
            SqlCommand s = new SqlCommand(cek, baglanti);
            SqlDataReader dr = s.ExecuteReader();
            while (dr.Read())
            {
                comboBox.Items.Add(dr.GetString(1));
            }
            baglanti.Close();

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
        public static void cagirCheckListBox(CheckedListBox checkedListBox ,String tabName)
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
        public static void cagirCheckListBox_Other(CheckedListBox checkedListBox, String tabName, int id)
        {
            List<String> match = new List<string>();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand($"select Expertise_field from Expertise where P_TC = {id};", baglanti);
            SqlDataReader dr_match = cmd.ExecuteReader();
            while (dr_match.Read())
            {
                match.Add(dr_match.GetString(0));
            }
            baglanti.Close();
            baglanti.Open();
            string cek = $"select distinct Expertise_field from {tabName};";
            SqlCommand test = new SqlCommand(cek, baglanti);
            SqlDataReader dr = test.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (match.Contains(dr.GetString(0)))
                    {
                        checkedListBox.Items.Add(dr.GetString(0), CheckState.Checked);
                    }
                    else
                    {
                        checkedListBox.Items.Add(dr.GetString(0));
                    }
                }
            }
            baglanti.Close();
        }
    }
}
