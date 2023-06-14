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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            DisplayEvents();
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Asus\Documents\schoolDB.mdf;Integrated Security = True; Connect Timeout = 30");
        
        //Display all events 
        private void DisplayEvents()
        {
            Con.Open();
            string Query = "Select * from tbl_events";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView_events.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            txt_event.Text = "";
            txt_duration.Text = "";
        }

        //Add new event
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_event.Text == "" || txt_duration.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbl_events(EDesc,EDate,EDuration) values (@Edesc,@Edate,@Eduration)", Con);
                    cmd.Parameters.AddWithValue("@Edesc", txt_event.Text);
                    cmd.Parameters.AddWithValue("@Edate", event_date.Value.Date);
                    cmd.Parameters.AddWithValue("@Eduration", txt_duration.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event added successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Con.Close();
                    //display the data after adding
                    DisplayEvents();
                    //reset the data 
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //Delete Event
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a event", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from tbl_events where EId=@Eid", Con);
                    cmd.Parameters.AddWithValue("@Eid", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Deleted successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Con.Close();
                    DisplayEvents();
                    //Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }


            }
        }

        //Exit Application
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Go back
        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        int Key = 0;
        private void dataGridView_events_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_event.Text = dataGridView_events.SelectedRows[0].Cells[1].Value.ToString();
            event_date.Text = dataGridView_events.SelectedRows[0].Cells[2].Value.ToString();
            txt_duration.Text = dataGridView_events.SelectedRows[0].Cells[3].Value.ToString();
            if (txt_event.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(dataGridView_events.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        //Updating events
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_event.Text == "" || txt_duration.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update tbl_events set EDesc=@EvDesc,EDate=@EvDate,EDuration=@EvDuration where EId = @EKey", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", txt_event.Text);
                    cmd.Parameters.AddWithValue("@EvDate", event_date.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDuration", txt_duration.Text);
                    cmd.Parameters.AddWithValue("@EKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Updated successfully!");
                    Con.Close();
                    //display the data after updating
                    DisplayEvents();
                    //reset the fields
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
