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
    public partial class ProjeEkle : Form
    {
        SqlConnection baglanti;
        public ProjeEkle()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
            DAO_Proje.cagirComboBox(comboBoxPrjSrm,"Personel");
            DAO_Proje.cagirCheckListBox(checkedListBoxPersoneller, "Personel");
        }
        
        private void textBoxProjeAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerKursBaslangic_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerKursBitis_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Project (P_Name,Date_Start,Date_Finish) values('" + textBoxProjeAdi.Text + "','" + dateTimePickerKursBaslangic.Value.ToString("yyyy-MM-dd") + "','" + dateTimePickerKursBitis.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            var temp = DAO_Proje.IdEkleProje("Project", textBoxProjeAdi.Text);/*personel id*/
            int cordi = DAO_Proje.cagirComboBoxID(comboBoxPrjSrm, "Personel");/*cordinator id*/
            for (int i = 0; i < checkedListBoxPersoneller.Items.Count; i++)
            {
                if (checkedListBoxPersoneller.GetItemChecked(i))
                {
                    string str = (string)checkedListBoxPersoneller.Items[i];
                    int tc = DAO_Proje.IdEkleChecklist("Personel",str);
                    string str1 = $"insert into PersonelProject (P_TC,Cordinator,Project_ID)" +$"values({tc},{cordi},{temp});";
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand(str1, baglanti);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            MessageBox.Show("Proje Eklendi!");

        }

        private void comboBoxPrjSrm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProjeAdi_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ProjeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
