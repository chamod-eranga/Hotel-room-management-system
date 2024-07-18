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

namespace hotel_room_management_system
{
    public partial class feedcheak : Form
    {
        string connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\3-BIT\2ND Semester\ITE 1942 - ICT Project\1-ICT Project Evaluation\hotel-room-management-system\hotel-room-management-system\HotelRoomManagementSystem.mdf;Integrated Security=True";

        public feedcheak()
        {
            InitializeComponent();

           

            txt_gid1.ReadOnly = true;
            txt_gid1.Enabled = false;

            txtGName.ReadOnly = true;
            txtGName.Enabled = false;

            txt_lastname.ReadOnly = true;
            txt_lastname.Enabled = false;

            txt_indate.ReadOnly = true;
            txt_indate.Enabled = false;

            txt_outdate.ReadOnly = true;
            txt_outdate.Enabled = false;

            txt_rlc.ReadOnly = true;
            txt_rlc.Enabled = false;
        }




        private void submit_btn_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "\n";
            
            txtResult.Text += "                                 THE RITZ-CARLTON HOTEL                            \n";

            txtResult.Text += "\n "; 

            txtResult.Text += "_______________________________________________________\n\n";
            txtResult.Text += "Date \t\t:" + DateTime.Now + "\n\n";

            txtResult.Text += "Room Number\t:   " + room_txtbox.Text + "\n\n";
            txtResult.Text += "Guest ID   \t:   " + txt_gid1.Text    + "\n\n";
            txtResult.Text += "Guest First Name\t:   " + txtGName.Text    + "\n\n";
            txtResult.Text += "Guest Last Name\t:   " + txt_lastname.Text + "\n\n";
            txtResult.Text += "Guest in Date\t:   " + txt_indate.Text + "\n\n";
            txtResult.Text += "Guest out Date\t:   " + txt_outdate.Text + "\n\n";
            txtResult.Text += "Room Charge\t:   " + txt_rlc.Text    + "\n\n";
            txtResult.Text += "TAX \t\t:    " + txt_tax.Text    + "\n\n";

            txtResult.Text += "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n\n";

            txtResult.Text += "Total Fees\t :   " + txt_tfee.Text    + "\n\n";


            txtResult.Text += "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n\n";

            txtResult.Text += "\n ";

            try
            {
                if (room_txtbox.Text != "" && txt_gid1.Text != "" && txtGName.Text != "" && txt_lastname.Text != "" && txt_rlc.Text != "" && txt_tax.Text != "" && txt_tfee.Text != "" && cb_fd1.Text != "" && cb_fd2.Text != "" && cb_fd3.Text != "" && cmb_staff.Text != "")
                {
                    string query = $"INSERT INTO [FinalBill] VALUES ('{room_txtbox.Text}','{txt_gid1.Text}','{txtGName.Text}','{txt_lastname.Text}','{txt_rlc.Text}','{txt_tax.Text}','{txt_tfee.Text}','{cb_fd1.Text}','{cb_fd2.Text}','{cb_fd3.Text}','{cmb_staff.Text}')";
                    SqlConnection connection = new SqlConnection(connectionString2);
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    

                    string query1 = $"INSERT INTO [DashFinalGeustFeedback] VALUES ('{room_txtbox.Text}','{txt_gid1.Text}','{cb_fd1.Text}','{cb_fd2.Text}','{cb_fd3.Text}','{cmb_staff.Text}','{txt_tfee.Text}')";
                    SqlCommand command1 = new SqlCommand(query1,connection);
                    command1.ExecuteNonQuery();

                    string query2 = $"UPDATE [RoomAvailability] SET Available = 'YES' WHERE Room_Number = '{room_txtbox.Text}'";
                    SqlCommand command2 = new SqlCommand(query2,connection);
                    command2.ExecuteNonQuery();

                    string query3 = $"DELETE [BookRoom] WHERE Room_Number = '{room_txtbox.Text}'";
                    SqlCommand command3 = new SqlCommand(query3,connection);
                    command3.ExecuteNonQuery();
                    connection.Close();
                }
                
                else
                {
                    MessageBox.Show("invalid fields");
                }
                
                if (room_txtbox.Text != "" && txt_gid1.Text != "" && cb_fd1.Text != "" && cb_fd2.Text != "" && cb_fd3.Text != "" && cmb_staff.Text != "")
                {

                }
                else
                {
                    MessageBox.Show("invalid fields");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

    
        private void btn_clear_Click(object sender, EventArgs e)
        {
            room_txtbox.Text = "";
            txt_gid1.Text = "";
            txtGName.Text = "";
            txt_lastname.Text = "";
            txt_indate.Text = "";
            txt_outdate.Text = "";
            txt_rlc.Text = "";
            txt_tax.Text = "";
            txt_tfee.Text = "";
            txtResult.Text = "";

            cb_fd1.SelectedIndex = -1; 
            cb_fd1.Text = ""; 
            cb_fd1.Items.Clear(); 

            cb_fd2.SelectedIndex = -1; 
            cb_fd2.Text = ""; 
            cb_fd2.Items.Clear(); 

            cb_fd3.SelectedIndex = -1;
            cb_fd3.Text = ""; 
            cb_fd3.Items.Clear();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Perpetua Titling MT", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }



        private void btn_calculate_Click(object sender, EventArgs e)
        {
            
            double amount = Convert.ToDouble(txt_rlc.Text);
            double percentage = Convert.ToDouble(txt_tax.Text);

           
            double taxFee = amount + percentage * 100;

          
            txt_tfee.Text = taxFee.ToString();
        }
        

        private void room_txtbox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString2);
            connection.Open();
            string query = $"SELECT * FROM [BookRoom] WHERE Room_Number = '{room_txtbox.Text}'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txt_gid1.Text = reader.GetString(1);
                txt_indate.Text = reader.GetString(2);
                txt_outdate.Text = reader.GetString(3);
                txt_rlc.Text = reader.GetInt32(8).ToString();
            }  
            connection.Close();
        }

        private void txt_gid1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString2);
            connection.Open();
            string query = $"SELECT * FROM [Geust] WHERE Geust_Id = '{txt_gid1.Text}'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtGName.Text = reader.GetString(1);
                txt_lastname.Text = reader.GetString(2);

            }
            connection.Close();
        }

        private void txt_tfee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
