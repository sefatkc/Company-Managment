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
    
    public partial class PersonelEkle : Form
    {
        SqlConnection baglanti;

        public PersonelEkle()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
            DAO_Personel.cagirCheckListBox(checkedListBox1,"Expertise");
            DAO_Personel.cagirComboBox(comboBoxUzmanlik,"Education_level");
            DAO_Personel.cagirComboBox(comboBoxGorev,"Duty");
            DAO_Personel.cagirComboBox(comboBoxBolum,"Company");
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string str = (string)checkedListBox1.Items[i];
                    //MessageBox.Show(str);
                }
            }
            baglanti.Close();
        }
        

        private void buttonEkle_Click(object sender, EventArgs e)
        {   
            DAO_Personel.passwordEkle(textBoxTCno, textBoxPwd, comboBoxYetki);
            int com = DAO_Personel.IdEkle(comboBoxBolum, "Company", "C_name");
            int edu = DAO_Personel.IdEkle(comboBoxUzmanlik, "Education_level", "Edu_level_name");
            int duty = DAO_Personel.IdEkle(comboBoxGorev, "Duty", "Duty_name");
            var o_tc = DAO_Personel.IdPass("PersonelLogin","O_TC",textBoxTCno);
            baglanti.Open();
            SqlCommand komut = new SqlCommand
                ("insert into Personel (P_name,P_surname,Edu_id,P_date_start,Duty_id,C_id,Salary,O_TC) " +
                "values('" + textBoxPad.Text + "','" + textBoxPsoyad.Text + "','"
                + edu
                + "','" + dateTimePickerBaslama.Value.ToString("yyyy-MM-dd") + "','"
                + duty + "','"
                + com
                + "'," + textBoxSalary.Text + ",'"+ o_tc +"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string soyad = textBoxPsoyad.Text;
            string ad = textBoxPad.Text;
            var temp = DAO_Personel.IdEkleChecklist("Personel", ad, soyad);/*personel id*/
            baglanti.Open();
            if (!(String.IsNullOrEmpty(textBoxUzmanadi.Text.Trim())))
            {
                var s2 = $"insert into Expertise (Expertise_field, P_TC) values ('{textBoxUzmanadi.Text.Trim()}',{temp});";
                SqlCommand ins = new SqlCommand(s2, baglanti);
                ins.ExecuteNonQuery();

            }
            baglanti.Close();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string str = (string)checkedListBox1.Items[i];
                    /*uzmanlık id */
                    string str1 = $"insert into Expertise (P_TC,Expertise_field)" +
                        $"values({temp},'{str}');";
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand(str1, baglanti);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            

            MessageBox.Show("Personel Eklendi!");
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBoxUzmanlik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxYetki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUzmanadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGorev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTCno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
