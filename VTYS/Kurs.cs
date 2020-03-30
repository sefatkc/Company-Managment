using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS
{
    public partial class Kurs : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
        public Kurs()
        {
            InitializeComponent();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select P_name, P_surname from Personel;", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBoxV.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
                    checkedListBox.Items.Add(dr.GetString(0) + " " + dr.GetString(1), CheckState.Unchecked);
                }
            }
            baglanti.Close();

        }


        private void textBoxKursAdi_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string s = "insert into Course (Cour_name, Cour_time) values('" + textBoxKursAdi.Text + "','" + textBoxSuresi.Text + "');";/*ilk önce kurs adı ve kurs süresi eklendi*/
            SqlCommand komut = new SqlCommand(s, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            int cour_id = 0;
            SqlCommand cid = new SqlCommand($"select Cour_id from Course where Cour_name = '{textBoxKursAdi.Text}';", baglanti);/*kurs id alıyoruz*/
            SqlDataReader dr1 = cid.ExecuteReader();
            while (dr1.Read())
            {
                cour_id = dr1.GetInt32(0);
            }
            baglanti.Close();
            string selected = comboBoxV.GetItemText(comboBoxV.SelectedItem);/*eğitim veren personel*/
            int vid = DAO_Kurs.IdEkle("Personel", selected);/*eğitim veren personel id*/
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    string str = (string)checkedListBox.Items[i];/*check olanların adını aldı*/
                    var temp = DAO_Kurs.IdEkle("Personel", str);/*eğitim alan personel id*/
                    string str1 = $"insert into CoursePersonel (TC_Teacher,TC_Student,Cour_Date, Cour_ID)" +
                        $"values({vid},{temp},'{dateTimePicker.Value.ToString("yyyy-MM-dd")}'," +
                        $"{cour_id});";
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand(str1, baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(str);
                    baglanti.Close();
                }
            }
            MessageBox.Show("Kurs Eklendi!");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Kurs_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS
{
    public partial class Kurs : Form
    {
        public Kurs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");

        private void textBoxKursAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Course (Cour_name) values('" + textBoxKursAdi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kurs Eklendi!");
        }

        private void Kurs_Load(object sender, EventArgs e)
        {

        }
    }
}*/
