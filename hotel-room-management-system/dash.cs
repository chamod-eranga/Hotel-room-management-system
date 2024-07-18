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
    public partial class dash : Form
    {
        string connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\3-BIT\2ND Semester\ITE 1942 - ICT Project\1-ICT Project Evaluation\hotel-room-management-system\hotel-room-management-system\HotelRoomManagementSystem.mdf;Integrated Security=True";
        public dash()
        {
            InitializeComponent();

            FinalGeustFeedbackData();
            Roomavailability();
        }

      

        private void btn_button2_Click_1(object sender, EventArgs e)
        {
            booking form5 = new booking();
            form5.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form5);
            form5.Dock = DockStyle.Fill;
            form5.Show();
        }

        private void btn_button3_Click(object sender, EventArgs e)
        {
            booking form5 = new booking();
            form5.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form5);
            form5.Dock = DockStyle.Fill;
            form5.Show();
        }

        private void btn_button1_Click(object sender, EventArgs e)
        {
            booking form5 = new booking();
            form5.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form5);
            form5.Dock = DockStyle.Fill;
            form5.Show();
        }

        public void FinalGeustFeedbackData()
        {

            SqlConnection connection = new SqlConnection(connectionString2);
            connection.Open();
            string query = $"SELECT * FROM [DashFinalGeustFeedback]";
            

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        public void updateRoomAvailability()
        {
            try
            {
                string query = $"SELECT Room_Number FROM [BookRoom]";
                SqlConnection connection = new SqlConnection(connectionString2);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                List<int> roomNumbers = new List<int>();

                while (sqlDataReader.Read())
                {
                    roomNumbers.Add((int)sqlDataReader["Room_Number"]);
                }
                connection.Close();
                string status = "NO";
                for (int x = 0; x < roomNumbers.Count; x++)
                {
                    string query1 = $"UPDATE [RoomAvailability] SET Available='{status}' WHERE Room_Number={roomNumbers[x]}";
                    SqlCommand command1 = new SqlCommand(query1, connection);
                    connection.Open();
                    command1.ExecuteNonQuery();
                    connection.Close();
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Roomavailability()
        {

            SqlConnection connection = new SqlConnection(connectionString2);
            string query = $"SELECT * FROM [RoomAvailability]";
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
