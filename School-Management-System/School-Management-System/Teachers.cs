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
using System.Windows.Input;

namespace School_Management_System
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }

        //SQL connection
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Asus\Documents\schoolDB.mdf;Integrated Security = True; Connect Timeout = 30");
        
        //Display all teachers 
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from tbl_teacher";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView_tlist.DataSource = ds.Tables[0];
            Con.Close();
        }

        //reset the fields
        public void Reset()
        {
            txt_tname.Text = "";
            txt_tno.Text = "";
            txt_tadd.Text = "";
            cmb_tgen.SelectedIndex = -1;
            cmb_tsub.SelectedIndex = -1;
        }

        //Register teachers
        private void btn_tregister_Click(object sender, EventArgs e)
        {
            if (txt_tname.Text == "" || txt_tno.Text == "" || txt_tadd.Text == "" || cmb_tgen.SelectedIndex == -1 || cmb_tsub.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else if (!IsValidName(txt_tname.Text))
            {
                MessageBox.Show("Invalid Name. Only letters are allowed.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (!IsValidNumber(txt_tno.Text))
            {
                MessageBox.Show("Invalid Phone Number. Only numbers are allowed.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (txt_tno.Text.Length > 10)
            {
                MessageBox.Show("Phone Number should not exceed 10 characters.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbl_teacher(TName,TGen,TPhone,TSub,TAdd,TDOB) values (@Tname,@TGen,@TPhone,@TSub,@TAdd,@TDOB)", Con);
                    cmd.Parameters.AddWithValue("@Tname", txt_tname.Text);
                    cmd.Parameters.AddWithValue("@TGen", cmb_tgen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", txt_tno.Text);
                    cmd.Parameters.AddWithValue("@TSub", cmb_tsub.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", txt_tadd.Text);
                    cmd.Parameters.AddWithValue("@TDOB", tDob_Picker.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Registered successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Con.Close();
                    //display the data after adding
                    DisplayTeachers();
                    //reset the data 
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //Validations
        private bool IsValidName(string name)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }
        private bool IsValidNumber(string number)
        {
            return int.TryParse(number, out _);
        }


        //Close button
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Set the data grid
        int Key = 0;
        private void dataGridView_tlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tname.Text = dataGridView_tlist.SelectedRows[0].Cells[1].Value.ToString();
            cmb_tgen.SelectedItem = dataGridView_tlist.SelectedRows[0].Cells[2].Value.ToString();
            tDob_Picker.Text = dataGridView_tlist.SelectedRows[0].Cells[6].Value.ToString();
            cmb_tsub.SelectedItem = dataGridView_tlist.SelectedRows[0].Cells[4].Value.ToString();
            txt_tadd.Text = dataGridView_tlist.SelectedRows[0].Cells[5].Value.ToString();
            txt_tno.Text = dataGridView_tlist.SelectedRows[0].Cells[3].Value.ToString();
            if (txt_tname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView_tlist.SelectedRows[0].Cells[0].Value.ToString());
            }
            
        }

        

        //Delete Teachers
        private void btn_tdel_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Teacher", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
         
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from tbl_teacher where TId=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }


            }
        }

        //Edit Teachers
        private void btn_tedit_Click(object sender, EventArgs e)
        {
            if (txt_tname.Text == "" || txt_tadd.Text == "" || txt_tno.Text == "" || cmb_tgen.SelectedIndex == -1 || cmb_tsub.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a teacher");
            }
            else if (!IsValidName(txt_tname.Text))
            {
                MessageBox.Show("Invalid Name. Only letters are allowed.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (!IsValidNumber(txt_tno.Text))
            {
                MessageBox.Show("Invalid Phone Number. Only numbers are allowed.");
            }
            else if (txt_tno.Text.Length > 10)
            {
                MessageBox.Show("Phone Number should not exceed 10 characters.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update tbl_teacher set TName=@Tname,TGen=@Tgen,TPhone=@Tphone,TSub=@Tsub,TAdd=@Tadd,TDOB=@Tdob where TId=@TKey", Con);
                    cmd.Parameters.AddWithValue("@Tname", txt_tname.Text);
                    cmd.Parameters.AddWithValue("@Tgen", cmb_tgen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Tphone", txt_tno.Text);
                    cmd.Parameters.AddWithValue("@Tsub", cmb_tsub.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Tadd", txt_tadd.Text);
                    cmd.Parameters.AddWithValue("@Tdob", tDob_Picker.Value.Date);
                    cmd.Parameters.AddWithValue("@TKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated successfully!");
                    Con.Close();
                    //display the data after updating
                    DisplayTeachers();
                    //reset the data 
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //Go back to home
        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void txt_tname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
