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



namespace hotel_room_management_system.New_staff_member_register
{
    public partial class new_member_reg : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\3-BIT\2ND Semester\ITE 1942 - ICT Project\1-ICT Project Evaluation\hotel-room-management-system\hotel-room-management-system\HotelRoomManagementSystem.mdf;Integrated Security=True";

        public new_member_reg()
        {
            InitializeComponent();

            StaffMembers();
        }

         public void Clear()
        {
            txt_Fname.Clear();
            txt_Lname.Clear();
            txt_Uname.Clear();
            txt_Pass.Clear();
            txt_nic.Clear();
            cb_emptype.Text = string.Empty;

            txtUpdateUID.Clear();
            txtUpdateFirstName.Clear();
            txtUpdateLastName.Clear();
            txtUpdatePassword.Clear();
            txtUpdateUserName.Clear();


        }

        private void Adduser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Fname.Text != "" && txt_Lname.Text != "" && txt_nic.Text != "" && txt_Pass.Text != "" && txt_Uname.Text != "" && cb_emptype.Text != "")
                {
                    string query = $"INSERT INTO [StaffMembers](first_name,last_name,user_id,password,user_name,employee_type) VALUES ('{txt_Fname.Text}','{txt_Lname.Text}','{txt_nic.Text}','{txt_Pass.Text}','{txt_Uname.Text}','{cb_emptype.Text}')";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    Clear();
                    MessageBox.Show("Done!");

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
        private void Update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"UPDATE [StaffMembers] SET first_name = '{txtUpdateFirstName.Text}',last_name = '{txtUpdateLastName.Text}',password = '{txtUpdatePassword.Text}',user_name = '{txtUpdateUserName.Text}',employee_type = '{comboBox2.Text}' WHERE user_id = '{txtUpdateUID.Text}'";
            SqlCommand command = new SqlCommand(query,connection);
            command.ExecuteNonQuery();
            connection.Close();
            Clear();
            MessageBox.Show("Update success!");
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"DELETE FROM [StaffMembers] WHERE user_id = '{txtUpdateUID.Text}'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Clear();
            MessageBox.Show("Delete success!");
        }

        private void txtUpdateNIC_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"SELECT * FROM [StaffMembers] WHERE user_id = '{txtUpdateUID.Text}'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtUpdateFirstName.Text = reader.GetString(0);
                txtUpdateLastName.Text = reader.GetString(1);
                txtUpdateUserName.Text = reader.GetString(2);
                txtUpdatePassword.Text = reader.GetInt32(4).ToString();
                cb_emptype.Text = reader.GetString(5);
            }
            connection.Close();
        }

        public void StaffMembers()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"SELECT * FROM [StaffMembers]";
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

       
    }
}

