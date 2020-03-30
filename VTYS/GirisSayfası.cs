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
using System.Runtime.InteropServices;

namespace VTYS
{
    public partial class GirisSayfası : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection baglanti;

        public GirisSayfası()
        {
            InitializeComponent();
            baglanti = new SqlConnection(""Data Script String");

        }
        
        private void buttonGiris_Click(object sender, EventArgs e)
        {
           
        }

        private void GirisSayfası_Load(object sender, EventArgs e)
        {
           textBoxSifre.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxTc.Text) || String.IsNullOrWhiteSpace(textBoxSifre.Text))
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", " HATALI GİRİŞ ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                baglanti.Open(); // Bağlantıyı aç.
                string sql = "SELECT * FROM PersonelLogin WHERE O_TC = '" + textBoxTc.Text + "' AND Password = '" + textBoxSifre.Text + "';";
                SqlCommand sqlData = new SqlCommand(sql, baglanti);
                SqlDataReader dataTable = sqlData.ExecuteReader();
                string yetki = "";
                while (dataTable.Read())
                {
                    yetki = dataTable.GetString(2);
                }
                if ( yetki == "Müdür" )
                { 
                    Anasayfa anasayfa = new Anasayfa("Müdür");
                    anasayfa.Show();
                    this.Hide();
                }
                else if (yetki == "Proje Yöneticisi")
                {
                    Anasayfa anasayfa = new Anasayfa("Proje Yöneticisi");
                    anasayfa.Show();
                    this.Hide();
                }
                else if (yetki == "Personel")
                {
                    Anasayfa anasayfa = new Anasayfa("Personel");
                    anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
          
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
        }
    }
}
