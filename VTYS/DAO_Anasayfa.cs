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
    class DAO_Anasayfa
    {
        public static void isim_getir(ComboBox comboBox, String tabname)
        {
            string ConnectionString = "Data Script String";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                //MessageBox.Show("Succesfull", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string q = $"select * from {tabname};";
                SqlCommand sqlCmd = new SqlCommand(q, con);
                SqlDataReader read = sqlCmd.ExecuteReader();

                if (read.HasRows)
                {
                    while (read.Read())
                    {

                        comboBox.Items.Add(read.GetString(1));

                    }
                }
                else
                {
                    MessageBox.Show("Error", "errr", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            con.Close();
        }public static void personel_getir(ComboBox comboBox, String tabname)
        {
            string ConnectionString = "Data Script String";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                //MessageBox.Show("Succesfull", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string q = $"select * from {tabname};";
                SqlCommand sqlCmd = new SqlCommand(q, con);
                SqlDataReader read = sqlCmd.ExecuteReader();

                if (read.HasRows)
                {
                    while (read.Read())
                    {

                        comboBox.Items.Add(read.GetString(1) +" "+ read.GetString(2));

                    }
                }
                else
                {
                    MessageBox.Show("Error", "errr", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            con.Close();
        }
    }
}
