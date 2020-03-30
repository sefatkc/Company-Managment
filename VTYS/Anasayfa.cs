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
using System.Globalization;
using System.Runtime.InteropServices;
namespace VTYS
{
    public partial class Anasayfa : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection baglanti;
        static String yetki;
        public Anasayfa(String yetki1)
        {      //""Data Script String"
                //"Data Source=NIRVANA;Initial Catalog=VTYS;Integrated Security=True;;MultipleActiveResultSets=True"
            InitializeComponent();
            yetki = yetki1;
            baglanti = new SqlConnection(""Data Script String");
            DAO_Anasayfa.isim_getir(comboBoxProje,"Project");
            DAO_Anasayfa.isim_getir(comboBoxKurs,"Course");
            //DAO_Anasayfa.personel_getir(comboBoxSec,"Personel");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonPersonelGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonPersonelEkle_Click_1(object sender, EventArgs e)
        {
            if (Anasayfa.yetki == "Müdür" || Anasayfa.yetki == "Proje Yöneticisi")
            {
                PersonelEkle pEkle = new PersonelEkle();
                pEkle.MdiParent = this;
                pEkle.StartPosition = FormStartPosition.Manual;
                pEkle.Location = new Point(0,175);
                pEkle.Show();
                panel3.Hide();
            }
            else
            {
                MessageBox.Show("Yetkin yeterli değil");
            }
           
        }

        private void buttonProjeEkle_Click_1(object sender, EventArgs e)
        {
            if (Anasayfa.yetki == "Müdür" || Anasayfa.yetki == "Proje Yöneticisi")
            {
                ProjeEkle proEkle = new ProjeEkle();
                proEkle.MdiParent = this;
                proEkle.StartPosition = FormStartPosition.Manual;
                proEkle.Location = new Point(0, 175);
                proEkle.Show();
                panel3.Hide();
            }
            else
            {
                MessageBox.Show("Yetkin yeterli değil");
            }
            
        }

        private void buttonKursEkle_Click_1(object sender, EventArgs e)
        {
            Kurs kurs = new Kurs();
            kurs.MdiParent = this;
            kurs.StartPosition = FormStartPosition.Manual;
            kurs.Location = new Point(0, 175);
            kurs.Show();
            panel3.Hide();
        }

        private void buttonUzmanlıkEkle_Click(object sender, EventArgs e)
        {
            UzmanlıkEkle uzmanlıkEkle = new UzmanlıkEkle();
            uzmanlıkEkle.MdiParent = this;
            uzmanlıkEkle.StartPosition = FormStartPosition.Manual;
            uzmanlıkEkle.Location = new Point(0, 175);
            uzmanlıkEkle.Show();
            panel3.Hide();
        }

        private void buttonGorevEkle_Click_1(object sender, EventArgs e)
        {
            if (Anasayfa.yetki == "Müdür")
            {
                GorevEkle sirketBolum = new GorevEkle();
                sirketBolum.MdiParent = this;
                sirketBolum.StartPosition = FormStartPosition.Manual;
                sirketBolum.Location = new Point(0, 175);
                sirketBolum.Show();
                panel3.Hide();
            }
            else
            {
                MessageBox.Show("Yetkin yeterli değil");
            }

        }

        private void buttonPersonelGuncelle_Click_1(object sender, EventArgs e)
        {
            if (Anasayfa.yetki == "Müdür")
            {
            PersonelGuncelle personelGuncelle = new PersonelGuncelle();
            personelGuncelle.MdiParent = this;
            personelGuncelle.StartPosition = FormStartPosition.Manual;
            personelGuncelle.Location = new Point(0, 175);
            personelGuncelle.Show();
            panel3.Hide();
            }
            else
            {
                MessageBox.Show("Yetkin yeterli değil");
            }

        }

        private void buttonProjeGuncelle_Click(object sender, EventArgs e)
        {
            if (Anasayfa.yetki == "Müdür" || Anasayfa.yetki == "Proje Yöneticisi")
            {
            ProjeGuncelle projeGuncelle = new ProjeGuncelle();
            projeGuncelle.MdiParent = this;
            projeGuncelle.StartPosition = FormStartPosition.Manual;
            projeGuncelle.Location = new Point(0, 175);
            projeGuncelle.Show();
            panel3.Hide();
            }
            else
            {
                MessageBox.Show("Yetkin yeterli değil");
            }

        }

        private void buttonKursGuncelle_Click(object sender, EventArgs e)
        {
            KursGuncelle kursGuncelle = new KursGuncelle();
            kursGuncelle.MdiParent = this;
            kursGuncelle.StartPosition = FormStartPosition.Manual;
            kursGuncelle.Location = new Point(0, 175);
            kursGuncelle.Show();
            panel3.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProje_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            comboBoxKurs.SelectedIndex = -1;
            comboBoxSec.SelectedIndex = -1;
            var selected = comboBoxProje.GetItemText(comboBoxProje.SelectedItem);
            //MessageBox.Show($"{selected}", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string ConnectionString = ""Data Script String";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string q = $"select P_name, P_surname from Personel where P_TC in(select P_TC from PersonelProject where Project_ID = (select Project_ID from Project where P_Name = '{selected}'));";/*Personal adı ve soyadı getiren sql sorgusu*/

            SqlCommand sqlCmd = new SqlCommand(q, con);
            SqlDataReader read = sqlCmd.ExecuteReader();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            ////Add column header
            
            listView1.Columns.Add("name", "Name");
            listView1.Columns.Add("surname", "Surname");

            //listView1.Columns.Add("");
            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;
            while (read.Read())
            {
                arr[0] = Convert.ToString(read.GetString(0));
                arr[1] = read.GetString(1);
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            con.Close();
            /*string devam = $"select Date_Start,Date_Finish from Project where P_name = '{selected}';";
            SqlCommand sql = new SqlCommand(devam, con);
            SqlDataReader rd = sql.ExecuteReader();
            while (rd.Read())
            {
                //DateTime dt = DateTime.ParseExact(dateString, "ddMMyyyy",CultureInfo.InvariantCulture);
                //DateTime dateTime = Convert.ToDateTime(read.GetSqlDateTime(2));
                //DateTime dateTime1 = Convert.ToDateTime(read.GetSqlDateTime(3));

                arr[2] = Convert.ToString(read.GetDateTime(0));
                arr[3] = Convert.ToString(read.GetDateTime(1));
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            con.Close();*/
        }

        private void buttonGorevSil_Click(object sender, EventArgs e)
        {
            if (Anasayfa.yetki == "Müdür")
            {
            GorevSil gorevSil = new GorevSil();
            gorevSil.MdiParent = this;
            gorevSil.StartPosition = FormStartPosition.Manual;
            gorevSil.Location = new Point(0, 175);
            gorevSil.Show();
            }
            else
            {
                MessageBox.Show("Yetkin yeterli değil");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ppdDiyalog.ShowDialog();
        }
        Font Baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(comboBoxProje.Text +comboBoxSec.Text + comboBoxKurs.Text, Baslik, sb, 200, 100);
            e.Graphics.DrawString("   Adı                               Soyadı      ", Baslik, sb, 70, 150);
            e.Graphics.DrawString(" --------------------------------------------------------   ", Baslik, sb, 70, 170);

            for (int i =0; i< listView1.Items.Count; i++)
            {
                e.Graphics.DrawString(listView1.Items[i].SubItems[0].Text, govde, sb, 70, 190+(i*30));
                e.Graphics.DrawString(listView1.Items[i].SubItems[1].Text, govde, sb,300, 190 + (i * 30));
             
            }
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxKurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            comboBoxProje.SelectedIndex = -1;
            comboBoxSec.SelectedIndex = -1;
            var selected = comboBoxKurs.GetItemText(comboBoxKurs.SelectedItem);
            //MessageBox.Show($"{selected}", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string ConnectionString = ""Data Script String";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string q = $"select P_name, P_surname from Personel where P_TC in(select TC_Student from CoursePersonel where Cour_ID = (select Cour_id from Course where Cour_Name = '{selected}'));";/*Personal adı ve soyadı getiren sql sorgusu*/

            SqlCommand sqlCmd = new SqlCommand(q, con);
            SqlDataReader read = sqlCmd.ExecuteReader();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //listView1.Columns.Add("");
            ////Add column header
            listView1.Columns.Add("name", "Name");
            listView1.Columns.Add("surname", "Surname");
            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;
            while (read.Read())
            {
                arr[0] = Convert.ToString(read.GetString(0));
                arr[1] = read.GetString(1);
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* Microsoft.Office.Interop.Excel.Application xlOrn = new Microsoft.Office.Interop.Excel.Application();
            if (xlOrn == null)
            {
                MessageBox.Show("Excel yüklü değil!!");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlOrn.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "Sayfa 1 Örnek Yazı";
            xlWorkBook.SaveAs("F:\\", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlOrn.Quit();

            MessageBox.Show("Excel dosyası d:\\yazilimbilisim.xls komununda oluşturuldu!");*/
        }
        protected override void OnLoad(EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.MouseDown += new MouseEventHandler(AppFormBase_MouseDown);
                this.MouseMove += new MouseEventHandler(AppFormBase_MouseMove);
                this.MouseUp += new MouseEventHandler(AppFormBase_MouseUp);
            }

            base.OnLoad(e);
        }

        void AppFormBase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }

        void AppFormBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X,
                this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        void AppFormBase_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        public Point downPoint = Point.Empty;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void comboBoxSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            comboBoxProje.SelectedIndex = -1;
            comboBoxKurs.SelectedIndex = -1;
            var selected = comboBoxSec.GetItemText(comboBoxSec.SelectedItem);
            string q = "";
            if (selected == "Personeller")
            {
                selected = "Personel";
                q = $"select P_name, P_surname from {selected};";/*Personal adı ve soyadı getiren sql sorgusu*/
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                //listView1.Columns.Add("");
                ////Add column header
                listView1.Columns.Add("name", "Name");
                listView1.Columns.Add("surname", "Surname");
                string ConnectionString = ""Data Script String";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand sqlCmd = new SqlCommand(q, con);
                SqlDataReader read = sqlCmd.ExecuteReader();
                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;
                while (read.Read())
                {
                    arr[0] = Convert.ToString(read.GetString(0));
                    arr[1] = read.GetString(1);
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
                con.Close();
            }
            else if(selected == "Projeler")
            {
                selected = "Project";
                q = $"select P_Name from {selected};";
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                //listView1.Columns.Add("");
                ////Add column header
                listView1.Columns.Add("project_name", "Project Name");

                string ConnectionString = ""Data Script String";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();


                SqlCommand sqlCmd = new SqlCommand(q, con);
                SqlDataReader read = sqlCmd.ExecuteReader();

                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;
                while (read.Read())
                {
                    arr[0] = Convert.ToString(read.GetString(0));
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
                con.Close();
            }
            else if(selected == "Kurslar")
            {
                selected = "Course";
                q = $"select Cour_name from {selected};";
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;
                //listView1.Columns.Add("");
                ////Add column header
                listView1.Columns.Add("course_name", "Course Name");

                string ConnectionString = ""Data Script String";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();


                SqlCommand sqlCmd = new SqlCommand(q, con);
                SqlDataReader read = sqlCmd.ExecuteReader();

                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;
                while (read.Read())
                {
                    arr[0] = Convert.ToString(read.GetString(0));
                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
                con.Close();
            }

        }
    }
}