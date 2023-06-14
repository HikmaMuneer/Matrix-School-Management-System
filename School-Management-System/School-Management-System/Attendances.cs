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

namespace School_Management_System
{
    public partial class Attendances : Form
    {
        public Attendances()
        {
            InitializeComponent();
            DisplayAttendace();
            FillStudId();
        }

        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select stuId from tbl_student", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("stuId", typeof(int));
            dt.Load(rdr);
            cmb_stuId.ValueMember = "stuId";
            cmb_stuId.DataSource = dt;
            Con.Close();
        }

        private void GetStudName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from tbl_student where stuId = @SID", Con);
            Cmd.Parameters.AddWithValue("@SID",cmb_stuId.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txt_stuname.Text = dr["stuName"].ToString();
            }
            Con.Close() ;
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Asus\Documents\schoolDB.mdf;Integrated Security = True; Connect Timeout = 30");
        //Display all students 
        private void DisplayAttendace()
        {
            Con.Open();
            string Query = "Select * from tbl_attendance";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView_attendance.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            cmb_stuId.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;
            txt_stuname.Text = "";
        }

        //Mark Attendance
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_stuname.Text == "" || cmb_status.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbl_attendance(AttStuId,AttStuName,AttDate,AttStatus) values (@StId,@StName,@AttDate,@Status)", Con);
                    cmd.Parameters.AddWithValue("@StId", cmb_stuId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", txt_stuname.Text);
                    cmd.Parameters.AddWithValue("@AttDate", attendance_date.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", cmb_status.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Marked!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Con.Close();
                    //display the data after adding
                    DisplayAttendace();
                    //reset the fields
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //Close Application
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmb_stuId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        int Key = 0;
        private void dataGridView_attendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_stuId.SelectedItem = dataGridView_attendance.SelectedRows[0].Cells[1].Value.ToString();
            txt_stuname.Text = dataGridView_attendance.SelectedRows[0].Cells[2].Value.ToString();
            attendance_date.Text = dataGridView_attendance.SelectedRows[0].Cells[3].Value.ToString();
            cmb_status.SelectedItem = dataGridView_attendance.SelectedRows[0].Cells[4].Value.ToString();
            
            if (txt_stuname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView_attendance.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        //Edit Information
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_stuname.Text == "" || cmb_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student");
            }
            else
            {
                try
                {
                    Con.Open();             
                    SqlCommand cmd = new SqlCommand("Update tbl_attendance set AttStuId=@StuId,AttStuName=@StuName,AttDate=@ADate,AttStatus=@AStatus where AttNo=@ANum", Con);
                    cmd.Parameters.AddWithValue("@StuId", cmb_stuId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StuName", txt_stuname.Text);
                    cmd.Parameters.AddWithValue("@ADate", attendance_date.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", cmb_status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ANum", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated successfully!");
                    Con.Close();
                    //display the data after updating
                    DisplayAttendace();
                    //reset the fields
                    Reset(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void cmb_stuId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
