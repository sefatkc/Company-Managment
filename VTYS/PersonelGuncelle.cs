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
    public partial class PersonelGuncelle : Form
    {
        SqlConnection baglanti;
        public PersonelGuncelle()
        {

            //"Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;"
            //"Data Source=NIRVANA;Initial Catalog=VTYS;Integrated /Security=True"/
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
            DAO_Personel_Guncelle.cagir(comboBoxPersonel);
            DAO_Personel_Guncelle.strcek_hepsi(comboBoxGorev,"Duty");
            DAO_Personel_Guncelle.strcek_hepsi(comboBoxBolum, "Company");
            DAO_Personel_Guncelle.strcek_hepsi(comboBoxUzmanlik, "Education_level");
        }

        private void comboBoxPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO_Personel_Guncelle.cagirCheckListBox(checkedListBox1, "Expertise");
            baglanti.Open();
            String[] select;
            string selected = comboBoxPersonel.GetItemText(comboBoxPersonel.SelectedItem);
            select = selected.Split();
            string cek = $"select * from Personel where P_name = '{select[0]}' and P_surname = '{select[1]}' and Durum = 1;";/* İsme Göre select yapıp cek komutu olarak adlandırdık */
            SqlCommand test = new SqlCommand(cek, baglanti);/*cek komutunu sql servere yolladık */
           // string cekExpertise = $"select Expertise_field from Expertise where P_TC = '{IdEkleChecklist("Personel", select[0],select[1])}';" ;/*Uzmanlık adlarını getirdik*/
           // SqlCommand cekExpertisecmd = new SqlCommand(cekExpertise, baglanti);
            SqlDataReader dr = test.ExecuteReader();
           // SqlDataReader dr2 = cekExpertisecmd.ExecuteReader();
            int edu = 0;
            int duty = 0;
            int com = 0;
            int P_TC = 0;
            while (dr.Read())
            {
                P_TC = dr.GetInt32(0);
                textBoxGuncAd.Text = dr.GetString(1);/* kutulara gerekli yerlerine adlarını yolluyoruz*/
                textBoxGuncsoyad.Text = dr.GetString(2);
                edu = dr.GetInt32(3);
                dateTimePickerBaslama.Text = Convert.ToString(dr.GetDateTime(4));
                duty = dr.GetInt32(5);
                com = dr.GetInt32(6);
                textBoxSalary.Text = Convert.ToString(dr.GetInt32(7));
                textBoxTCno.Text = dr.GetString(8);
            }
            baglanti.Close();
            checkedListBox1.Items.Clear();
            DAO_Personel_Guncelle.cagirCheckListBox_Other(checkedListBox1, "Expertise", P_TC);
            comboBoxUzmanlik.SelectedItem = DAO_Personel_Guncelle.strcek("Education_level", "Edu_id", edu);
            comboBoxGorev.SelectedItem = DAO_Personel_Guncelle.strcek("Duty", "Duty_id", duty);
            comboBoxBolum.SelectedItem = DAO_Personel_Guncelle.strcek("Company", "C_id", com);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxGuncAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int com = DAO_Personel_Guncelle.IdEkle(comboBoxBolum, "Company", "C_name");
            int edu = DAO_Personel_Guncelle.IdEkle(comboBoxUzmanlik, "Education_level", "Edu_level_name");
            int duty = DAO_Personel_Guncelle.IdEkle(comboBoxGorev, "Duty", "Duty_name");
            baglanti.Open();
            String[] select;
            string selected = comboBoxPersonel.GetItemText(comboBoxPersonel.SelectedItem);
            select = selected.Split();
            /* string up = $"update Personel set  O_TC ='" + textBoxTCno.Text + "'" + "P_name ='" + textBoxGuncAd.Text + "'" +
                 ", P_surname ='" + textBoxGuncsoyad.Text + "'," +
                 " Edu_id ='" + edu + "'," +
                 " P_date_start ='" + dateTimePickerBaslama.Value.ToString("yyyy-MM-dd") + "'," +
                 " Duty_id ='" + duty + "', C_id ='" + com + "'," +
                 " Salary ='" + textBoxSalary.Text + "'" +
                 " where P_name = '" + select[0] + "' and P_surname = '" + select[1] + "';";
             //("insert into Personel (P_name,P_surname) values('" + textBoxPad.Text + "','" + textBoxPsoyad.Text + "')", baglanti);
             SqlCommand komut = new SqlCommand(up, baglanti);
             komut.ExecuteNonQuery();*/
            string s1 = "select P_TC from Personel where P_name = '" + select[0] + "' and P_surname = '" + select[1] + "';";
            SqlCommand qq = new SqlCommand(s1, baglanti);
            SqlDataReader pdr = qq.ExecuteReader();
            int pid = 0;
            while (pdr.Read())
            {
                pid = pdr.GetInt32(0);
            }

            baglanti.Close();
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand($"DELETE FROM Expertise WHERE P_TC = {pid};", baglanti);
            cmd1.ExecuteNonQuery();
            baglanti.Close();
            List<String> uzmanlikChecked = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string str = (string)checkedListBox1.Items[i];
                    uzmanlikChecked.Add(str);
                }
            }
            int len = uzmanlikChecked.Count();
            baglanti.Open();
            foreach (var i in uzmanlikChecked)
            {
                SqlCommand ins = new SqlCommand($"insert into Expertise (Expertise_field, P_TC) values ('{i}',{pid});", baglanti);
                ins.ExecuteNonQuery();
            }
            baglanti.Close();
            baglanti.Open();
            string up = $"update Personel set P_name ='" + textBoxGuncAd.Text + "'" +
                ", P_surname ='" + textBoxGuncsoyad.Text + "'," +
                " Edu_id ='" + edu + "'," +
                " P_date_start ='" + dateTimePickerBaslama.Value.ToString("yyyy-MM-dd") + "'," +
                " Duty_id ='" + duty + "', C_id ='" + com + "'," +
                " Salary ='" + textBoxSalary.Text + "'" +
                " where P_name = '" + select[0] + "' and P_surname = '" + select[1] + "';"; // we can use pid here
            //("insert into Personel (P_name,P_surname) values('" + textBoxPad.Text + "','" + textBoxPsoyad.Text + "')", baglanti);
            SqlCommand komut = new SqlCommand(up, baglanti);
            komut.ExecuteNonQuery();
            if (!(String.IsNullOrEmpty(textBoxUzmanadi.Text.Trim())))
            {
                var s2 = $"insert into Expertise (Expertise_field, P_TC) values ('{textBoxUzmanadi.Text.Trim()}',{pid});";
                SqlCommand ins = new SqlCommand(s2, baglanti);
                ins.ExecuteNonQuery();
            }
            baglanti.Close();
 
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String[] select;
            string selected = comboBoxPersonel.GetItemText(comboBoxPersonel.SelectedItem);
            select = selected.Split();
            SqlCommand komut = new SqlCommand($"update Personel set Durum = 0  where P_name = '" + select[0] + "' and P_surname = '" + select[1] + "' ; ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

