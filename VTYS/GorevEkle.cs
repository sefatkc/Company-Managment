using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTYS
{
    public partial class GorevEkle : Form
    {
        public GorevEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
        private void textBoxUzmanlikAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Duty (Duty_name) values('" + textBoxGorevAdi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görev Eklendi!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
