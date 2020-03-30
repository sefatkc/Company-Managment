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
    public partial class GorevSil : Form
    {
        SqlConnection baglanti;
        public GorevSil()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
            DAO_GorevSil.cagir(comboBoxGorev);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string selected = comboBoxGorev.GetItemText(comboBoxGorev.SelectedItem);
            SqlCommand komut = new SqlCommand($"delete from Duty where Duty_name = '{selected}';", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string selected = comboBoxGorev.GetItemText(comboBoxGorev.SelectedItem);
            string up = $"update Duty set Duty_name ='" + textBoxGorevAdi.Text + "' where Duty_name = '" + selected + "';";
            //("insert into Personel (P_name,P_surname) values('" + textBoxPad.Text + "','" + textBoxPsoyad.Text + "')", baglanti);
            SqlCommand komut = new SqlCommand(up, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
