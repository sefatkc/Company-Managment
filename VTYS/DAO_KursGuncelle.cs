using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace VTYS
{
    class DAO_KursGuncelle
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
        public static void cagir(ComboBox comboBox)
        {
            baglanti.Open();
            string cek = "select * from Course where Durum > 0;";
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

        public static int verikutugetir(ComboBox comboBox, TextBox textBox, TextBox textBox2, ComboBox kursVeren)
        {
            kursVeren.Items.Clear();
            baglanti.Open();
            string selected = comboBox.GetItemText(comboBox.SelectedItem);
            string cek = $"select * from Course where Cour_name = '{selected}';";/* İsme Göre select yapıp cek komutu olarak adlandırdık */
            SqlCommand test = new SqlCommand(cek, baglanti);
            SqlDataReader dr = test.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                textBox.Text = dr.GetString(1);
                textBox2.Text = dr.GetString(2);
            }
            SqlCommand all_ps = new SqlCommand("select P_name,P_surname from Personel;", baglanti);
            SqlDataReader dr_all_ps = all_ps.ExecuteReader();
            while (dr_all_ps.Read())
            {
                kursVeren.Items.Add(dr_all_ps.GetString(0) + " " + dr_all_ps.GetString(1));
            }
            string s1 = $"select P_name, P_surname from Personel where P_TC = (select distinct TC_Teacher from CoursePersonel where Cour_ID = {id});";
            SqlCommand e_v = new SqlCommand(s1, baglanti);
            SqlDataReader drev = e_v.ExecuteReader();
            while (drev.Read())
            {
                kursVeren.SelectedItem = (drev.GetString(0) + " " + drev.GetString(1));
            }
            baglanti.Close();
            return id;
        }
        public static void guncelle(CheckedListBox checklistbox, TextBox kursadi, TextBox kursSuresi, DateTimePicker date, string selected, ComboBox kursV)
        {
            baglanti.Open();

            // Kurs veren id aldi
            int v_id = 0;
            string k_v_s = kursV.GetItemText(kursV.SelectedItem);
            SqlCommand cmd2 = new SqlCommand($"select P_TC from Personel where CONCAT(P_name, ' ', P_surname) = '{k_v_s}';", baglanti);
            SqlDataReader dr_k_v = cmd2.ExecuteReader();
            while (dr_k_v.Read())
                v_id = dr_k_v.GetInt32(0);

            // Kurs id aldi
            int c_id = 0;
            SqlCommand c_idcek = new SqlCommand($"select Cour_id from Course where Cour_name = '{selected}';", baglanti);
            SqlDataReader dr_c_id = c_idcek.ExecuteReader();
            while (dr_c_id.Read())
                c_id = dr_c_id.GetInt32(0);

            // Course tabloyu update yapti
            if (!(String.IsNullOrEmpty(kursadi.Text.Trim())))
                selected = kursadi.Text;
            var s2 = $"update Course set Cour_name = '{selected}', Cour_time = '{kursSuresi.Text}' where Cour_id ={c_id};";
            SqlCommand c_up = new SqlCommand(s2, baglanti);
            c_up.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand($"DELETE FROM CoursePersonel WHERE Cour_ID = {c_id};", baglanti);
            cmd1.ExecuteNonQuery();

            List<String> personelChecked = new List<string>();
            for (int i = 0; i < checklistbox.Items.Count; i++)
            {
                if (checklistbox.GetItemChecked(i))
                {
                    string str = (string)checklistbox.Items[i];
                    personelChecked.Add(str);
                }
            }
            int len = personelChecked.Count();
            foreach (var i in personelChecked)
            {
                var s3 = $"select P_TC from Personel where CONCAT(P_name, ' ', P_surname) = '{i}';";
                int pid = 0;
                SqlCommand cmd = new SqlCommand(s3, baglanti);
                SqlDataReader dr_pid = cmd.ExecuteReader();
                while (dr_pid.Read())
                {
                    pid = dr_pid.GetInt32(0);
                }
                var s4 = $"insert into CoursePersonel (TC_Teacher,TC_Student,Cour_Date, Cour_ID) values ({v_id},{pid},'{date.Value.ToString("yyyy-MM-dd")}' ,{c_id});";
                SqlCommand ins = new SqlCommand(s4, baglanti);
                ins.ExecuteNonQuery();
            }
            baglanti.Close();
        }
        public static void cagirCheckListBox_Other(CheckedListBox checkedListBox, String tabName, int id)
        {
            //CoursePersonel
            List<String> match = new List<string>();
            baglanti.Open();
            string s1 = $"select P_name,P_surname from Personel where P_TC in (select TC_Student from CoursePersonel where Cour_ID = {id});";
            SqlCommand cmd = new SqlCommand(s1, baglanti);
            SqlDataReader dr_match = cmd.ExecuteReader();
            while (dr_match.Read())
            {
                match.Add(dr_match.GetString(0) + " " + dr_match.GetString(1));
            }

            int t_id = 0;
            SqlCommand cmd3 = new SqlCommand($"select TC_Teacher from CoursePersonel where Cour_ID = {id};", baglanti);
            SqlDataReader dr_t_id = cmd3.ExecuteReader();
            while (dr_t_id.Read())
                t_id = dr_t_id.GetInt32(0);


            SqlCommand cmd2 = new SqlCommand($"select P_name,P_surname,P_TC from Personel;", baglanti);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                if (t_id == dr.GetInt32(2))
                    continue;
                var ck = dr.GetString(0) + " " + dr.GetString(1);
                if (match.Contains(ck))
                {
                    checkedListBox.Items.Add(ck, CheckState.Checked);
                }
                else
                {
                    checkedListBox.Items.Add(ck);
                }
            }
            baglanti.Close();
        }

        public static void sil(ComboBox comboBox)
        {
            baglanti.Open();
            string selected = comboBox.GetItemText(comboBox.SelectedItem);
            SqlCommand cmd = new SqlCommand($"update Course set Durum = 0 where Cour_name = '{selected}';", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}