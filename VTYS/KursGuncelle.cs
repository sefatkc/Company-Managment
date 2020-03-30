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
    public partial class KursGuncelle : Form
    {
        SqlConnection baglanti;

        public KursGuncelle()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=SQL7004.site4now.net;Initial Catalog=DB_A43BB8_vtysproje;User Id=DB_A43BB8_vtysproje_admin;Password=vtysproje18;");
            DAO_KursGuncelle.cagir(comboBoxKurs);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            string selected = comboBoxKurs.GetItemText(comboBoxKurs.SelectedItem);
            DAO_KursGuncelle.guncelle(checkedListPersoneller, textBoxKursAdi, textBoxSuresi, dateTimePicker, selected, comboBoxV);
        }

        private void comboBoxKurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListPersoneller.Items.Clear();
            //DAO_KursGuncelle.cagirCheckListBox(checkedListPersoneller, "Personel");
            int id = DAO_KursGuncelle.verikutugetir(comboBoxKurs, textBoxKursAdi, textBoxSuresi, comboBoxV);/* kutulara gerekli yerlerine adlarını yolluyoruz*/
            DAO_KursGuncelle.cagirCheckListBox_Other(checkedListPersoneller, "CoursePersonel", id);

        }

        private void buttonKursSil_Click(object sender, EventArgs e)
        {
            DAO_KursGuncelle.sil(comboBoxKurs);
        }

        private void KursGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}