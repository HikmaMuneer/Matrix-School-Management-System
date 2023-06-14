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

namespace School_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Asus\Documents\schoolDB.mdf;Integrated Security = True; Connect Timeout = 30");


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu(); 
            Obj.Show();
            this.Hide();
        }

        //Count the students
        private void CountStudent()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tbl_student",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_students.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        //Count the teachers
        private void CountTeachers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tbl_teacher", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_teachers.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        //Count the events
        private void CountEvents()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tbl_events", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_events.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        //Count the payments
        private void CountPayments()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(PayAmt) from tbl_payment", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_payments.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudent();
            CountTeachers();
            CountEvents();
            CountPayments();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
