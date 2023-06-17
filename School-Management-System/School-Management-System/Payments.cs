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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
            DisplayPayments();
            FillStudId();
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Asus\Documents\schoolDB.mdf;Integrated Security = True; Connect Timeout = 30");
        
        //Display all payments 
        private void DisplayPayments()
        {
            Con.Open();
            string Query = "Select * from tbl_payment";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView_payments.DataSource = ds.Tables[0];
            Con.Close();
        }

        //Load Students ID
        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select stuId from tbl_student", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("stuId", typeof(int));
            dt.Load(rdr);
            cmb_stuid.ValueMember = "stuId";
            cmb_stuid.DataSource = dt;
            Con.Close();
        }

        //Load Students Names
        private void GetStudName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from tbl_student where stuId = @SID", Con);
            Cmd.Parameters.AddWithValue("@SID", cmb_stuid.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_stuname.Text = dr["stuName"].ToString();
            }
            Con.Close();
        }

        //Reset fields
        private void Reset()
        {
            cmb_stuid.SelectedIndex = -1;
            txt_stuname.Text = "";
            txt_amt.Text = "";
        }

        //New Payments
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_stuid.SelectedIndex == -1 || txt_stuname.Text == "" || txt_amt.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else if (!IsValidAmount(txt_amt.Text))
            {
                MessageBox.Show("Invalid Amount. Only numbers are allowed.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string paymentperiod;
                paymentperiod = payment_date.Value.Month.ToString() +"/"+ payment_date.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from tbl_payment where stuId = '" + cmb_stuid.SelectedValue.ToString() + "' and Month = '"+paymentperiod.ToString()+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("No due payments for this month !", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into tbl_payment(stuId,stuName,Month,PayAmt) values (@Stid,@Stname,@PayMonth,@PayAmt)", Con);
                    cmd.Parameters.AddWithValue("@Stid", cmb_stuid.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Stname", txt_stuname.Text);
                    cmd.Parameters.AddWithValue("@PayMonth", paymentperiod);
                    cmd.Parameters.AddWithValue("@PayAmt", txt_amt.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment completed successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


                }
                Con.Close();
                DisplayPayments();
                Reset();
            }
        }

        //Validations
        private bool IsValidAmount(string number)
        {
            return int.TryParse(number, out _);
        }

        //Close Application
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmb_stuid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        //Go Back
        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void dataGridView_payments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
