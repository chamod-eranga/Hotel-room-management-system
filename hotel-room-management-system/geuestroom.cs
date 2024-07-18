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
    public partial class geuestroom : Form
    {
        string connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\3-BIT\2ND Semester\ITE 1942 - ICT Project\1-ICT Project Evaluation\hotel-room-management-system\hotel-room-management-system\HotelRoomManagementSystem.mdf;Integrated Security=True";
        public geuestroom()
        {
            InitializeComponent();
            GuestData();
            RoomData();
        }

        public void GuestData()
        {
            
            SqlConnection connection = new SqlConnection(connectionString2);
            string query = $"SELECT * FROM [Geust]";
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            datagridview2.DataSource = dataTable;
        }

   
        public void RoomData()
        {

            SqlConnection connection = new SqlConnection(connectionString2);
            connection.Open();
            string query = $"SELECT * FROM [BooKRoom]";
            

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;
            connection.Close();

           
        }
    }
}
