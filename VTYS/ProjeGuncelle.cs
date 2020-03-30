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
    public partial class ProjeGuncelle : Form
    {
        SqlConnection baglanti;
        public ProjeGuncelle()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
            DAO_Proje_Guncelle.cagir(comboBoxProje);
        }
       
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string selected = comboBoxProje.GetItemText(comboBoxProje.SelectedItem);
            string up = $"update Project set P_Name ='" + textBoxProjeAdi.Text + "' where P_Name = '" + selected + "';";
            SqlCommand komut = new SqlCommand(up, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int selected_f = DAO_Proje_Guncelle.IdEkle(comboBoxProje, "Project", "P_Name");
            baglanti.Open();
            SqlCommand komut_f = new SqlCommand($"delete from PersonelProject where Project_ID = '{selected_f}';", baglanti);
            komut_f.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            string selected = comboBoxProje.GetItemText(comboBoxProje.SelectedItem);
            SqlCommand komut = new SqlCommand($"delete from Project where P_Name = '{selected}';", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void comboBoxProje_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string selected = comboBoxProje.GetItemText(comboBoxProje.SelectedItem);
            string cek = $"select * from Project where P_Name = '{selected}';";/*İsme Göre select yapıp cek komutu olarak adlandırdık*/
            SqlCommand test = new SqlCommand(cek, baglanti);/*cek komutunu sql servere yolladık */
            SqlDataReader dr = test.ExecuteReader();
            while (dr.Read())
            {
                textBoxProjeAdi.Text = dr.GetString(1);/*kutulara gerekli yerlerine adlarını yolluyoruz*/
             
            }
            baglanti.Close();

        }

        private void ProjeGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
