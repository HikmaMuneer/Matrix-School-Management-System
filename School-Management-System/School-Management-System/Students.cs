using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace School_Management_System
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }

        private void txt_stuname_TextChanged(object sender, EventArgs e)
        {

        }
       

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Asus\Documents\schoolDB.mdf;Integrated Security = True; Connect Timeout = 30");
        
        //Display all students 
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from tbl_student";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_stu.DataSource = ds.Tables[0];
            Con.Close();
        }



        //Creating a new student
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_stuname.Text == "" || txt_fees.Text ==""|| txt_stuadd.Text==""||cmb_gender.SelectedIndex==-1 || cmb_grade.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbl_student(stuName,stuGen,stuDOB,stuClass,stuPay,stuAdd) values (@Sname,@SGen,@SDob,@SGrade,@SPay,@SAdd)", Con);
                    cmd.Parameters.AddWithValue("@Sname", txt_stuname.Text);
                    cmd.Parameters.AddWithValue("@SGen", cmb_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", dobPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SGrade", cmb_grade.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SPay", txt_fees.Text);
                    cmd.Parameters.AddWithValue("@SAdd", txt_stuadd.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Registered successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Con.Close();
                    //display the data after adding
                    DisplayStudent();
                    //reset the data 
                    Reset();
                }
                catch(Exception ex) { 
                    MessageBox.Show(ex.Message); 
                }
                
            }
        }

        //Close Application
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Reset Data 
        int Key = 0;
        private void Reset()
        {
            Key = 0;
            txt_stuname.Text = "";
            txt_stuadd.Text = "";
            txt_fees.Text = "";
            cmb_gender.SelectedIndex = -1;
            cmb_grade.SelectedIndex = -1;
        }
        
        private void dgv_stu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_stuname.Text = dgv_stu.SelectedRows[0].Cells[1].Value.ToString();
            cmb_gender.SelectedItem = dgv_stu.SelectedRows[0].Cells[2].Value.ToString();
            dobPicker.Text = dgv_stu.SelectedRows[0].Cells[3].Value.ToString();
            cmb_grade.SelectedItem = dgv_stu.SelectedRows[0].Cells[4].Value.ToString();
            txt_fees.Text = dgv_stu.SelectedRows[0].Cells[5].Value.ToString();
            txt_stuadd.Text = dgv_stu.SelectedRows[0].Cells[6].Value.ToString();
            if (txt_stuname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dgv_stu.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        //Delete students 
        private void btn_del_Click(object sender, EventArgs e)
        {
            if(Key == 0)
            {
                MessageBox.Show("Select a Student","Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from tbl_student where stuId=@StKey",Con);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
               
            }
        }

        //Edit students details
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_stuname.Text == "" || txt_fees.Text == "" || txt_stuadd.Text == "" || cmb_gender.SelectedIndex == -1 || cmb_grade.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update tbl_student set stuName=@Sname,stuGen=@SGen,stuDOB=@SDob,stuClass=@SGrade,stuPay=@SPay,stuAdd=@SAdd where stuId=@StKey", Con);
                    cmd.Parameters.AddWithValue("@Sname", txt_stuname.Text);
                    cmd.Parameters.AddWithValue("@SGen", cmb_gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", dobPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SGrade", cmb_grade.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SPay", txt_fees.Text);
                    cmd.Parameters.AddWithValue("@SAdd", txt_stuadd.Text);
                    cmd.Parameters.AddWithValue("@StKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated successfully!");
                    Con.Close();
                    //display the data after updating
                    DisplayStudent();
                    //reset the data 
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //Go back
        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();

        }
    }
}
