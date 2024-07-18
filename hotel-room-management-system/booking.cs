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
    public partial class booking : Form
    {
        string connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\3-BIT\2ND Semester\ITE 1942 - ICT Project\1-ICT Project Evaluation\hotel-room-management-system\hotel-room-management-system\HotelRoomManagementSystem.mdf;Integrated Security=True";
        public booking()
        {
            InitializeComponent();

            txt_roomcharges.ReadOnly = true;
            txt_roomcharges.Enabled = false;
           
        }
        public void clear()
        {
            //Guest Details

            txt_address.Clear();
            txt_email.Clear();
            txt_firstname.Clear();
            txt_gid1.Clear();
            txt_lastname.Clear();
            txt_phonenumber.Clear();

            //booking information  comboBox.Items.Clear();

            txt_noa.Items.Clear();
            txt_noc.Items.Clear();
            cmb_rquality.Items.Clear();
            txt_gid.Clear();
            txt_roomnum.Clear();
            txt_roomcharges.Clear();
            txt_rlc.Clear();

        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_firstname.Text != "" && txt_email.Text != "" && txt_address.Text != "" && txt_lastname.Text != "" && txt_gid1.Text != "" && txt_phonenumber.Text != "")
            {
                SqlConnection connection = new SqlConnection(connectionString2);
                string query = $"INSERT INTO [Geust] VALUES('{txt_gid1.Text}','{txt_firstname.Text}','{txt_lastname.Text}','{txt_email.Text}','{txt_phonenumber.Text}','{txt_address.Text}')";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Insert done");
                    clear();
                }
                else
                {
                    MessageBox.Show("Insert fail");
                }
            }
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
                txt_firstname.Text = reader.GetString(1);
                txt_lastname.Text = reader.GetString(2);
                txt_email.Text = reader.GetString(3);
                txt_phonenumber.Text = reader.GetInt32(4).ToString();
                txt_address.Text = reader.GetString(5);
            }
            connection.Close();

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (txt_firstname.Text != "" && txt_email.Text != "" && txt_address.Text != "" && txt_lastname.Text != "" && txt_gid1.Text != "" && txt_phonenumber.Text != "")
            {
                SqlConnection connection = new SqlConnection(connectionString2);
                string query = $"DELETE [Geust] WHERE Geust_Id = '{txt_gid1.Text}'";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Delete success!");
                    clear();
                }
                else
                {
                    MessageBox.Show("Delete success!");
                }
            }
        }

        private void btn_update1_Click(object sender, EventArgs e)
        {
            if (txt_firstname.Text != "" && txt_lastname.Text != "" && txt_email.Text != "" && txt_address.Text != "" && txt_lastname.Text != "" && txt_gid1.Text != "" && txt_phonenumber.Text != "")
            {


                SqlConnection connection = new SqlConnection(connectionString2);
                string query = $"UPDATE [Geust] SET First_Name ='{txt_firstname.Text}', Last_Name='{txt_lastname.Text}',Email='{txt_email.Text}',Modile_No = '{txt_phonenumber.Text}', Address = '{txt_address.Text }' WHERE Geust_Id = '{txt_gid1.Text}'";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                int ex = command.ExecuteNonQuery();
                if (ex > 0)
                {
                    MessageBox.Show("Update success!");
                    geuestroom geuestRoom = new geuestroom();
                    geuestRoom.GuestData();
                    clear();
                }
                else
                {
                    MessageBox.Show("Update Fail!");
                }
            }
        }

        // BookRoom

        private void txt_roomnum_TextChanged(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString2);
            connection.Open();
            string query   = $"SELECT * FROM [BooKRoom] WHERE Room_Number = '{txt_roomnum.Text}'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txt_gid.Text         = reader.GetString(1);
                dateTimePicker1.Text = reader.GetString(2);
                dateTimePicker2.Text = reader.GetString(3);
                txt_noa.Text         = reader.GetInt32(4).ToString();
                txt_noc.Text         = reader.GetInt32(5).ToString();
                cmb_rquality.Text    = reader.GetString(6);
                txt_roomcharges.Text = reader.GetString(7);
                txt_rlc.Text         = reader.GetInt32(8).ToString();
            }
            connection.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_roomnum.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && txt_noa.Text != "" && txt_noc.Text != "" && cmb_rquality.Text != "" && txt_roomcharges.Text != "" && txt_rlc.Text != "")
            {

                SqlConnection connection = new SqlConnection(connectionString2);
                string query = $"UPDATE [BooKRoom] SET Geust_Id = '{txt_gid.Text}', Check_in_Date ='{dateTimePicker1.Text}', Check_out_Date ='{dateTimePicker2.Text}',Number_of_Adults='{txt_noa.Text}',Number_of_Children= '{txt_noc.Text}', Room_Type = '{cmb_rquality.Text }', Room_Charges = '{txt_roomcharges.Text }',Room_living_cost='{txt_rlc.Text}'";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                int ex = command.ExecuteNonQuery();
                if (ex > 0)
                {
                    MessageBox.Show("Update success!");
                    geuestroom geuestRoom = new geuestroom();
                    geuestRoom.GuestData();
                    clear();
                    txt_noa.SelectedIndex = -1;
                    txt_noa.Text = "";
                    txt_noa.Items.Clear();

                    txt_noc.SelectedIndex = -1;
                    txt_noc.Text = "";
                    txt_noc.Items.Clear();

                    cmb_rquality.SelectedIndex = -1;
                    cmb_rquality.Text = "";
                    cmb_rquality.Items.Clear();

                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Update Fail!");
                }
            }
        }
        
        private void btn_bookroom_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_roomnum.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && txt_noa.Text != "" && txt_noc.Text != "" && cmb_rquality.Text != "" && txt_roomcharges.Text != "" && txt_rlc.Text !="")
                {
                    string query = $"INSERT INTO [BooKRoom](Room_Number,Geust_Id,Check_in_Date,Check_out_Date,Number_of_Adults,Number_of_Children,Room_Type,Room_Charges,Room_living_cost) VALUES ('{txt_roomnum.Text}','{txt_gid.Text}','{dateTimePicker1.Text}','{dateTimePicker2.Text}','{txt_noa.Text}','{txt_noc.Text}','{cmb_rquality.Text}','{txt_roomcharges.Text}','{txt_rlc.Text}')";
                    SqlConnection connection = new SqlConnection(connectionString2);
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    string status = "NO";
                    string query1 = $"UPDATE [RoomAvailability] SET Available='{status}' WHERE Room_Number= '{txt_roomnum.Text}'";
                    SqlCommand command1 = new SqlCommand(query1, connection);
                
                    command1.ExecuteNonQuery();

                    {
                        MessageBox.Show("Done!");
                        clear();
                        txt_noa.SelectedIndex = -1;
                        txt_noa.Text = "";
                        txt_noa.Items.Clear();

                        txt_noc.SelectedIndex = -1;
                        txt_noc.Text = "";
                        txt_noc.Items.Clear();

                        cmb_rquality.SelectedIndex = -1;
                        cmb_rquality.Text = "";
                        cmb_rquality.Items.Clear();

                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
                    }

                    connection.Close();



                  

               
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


        private void btn_delete1_Click(object sender, EventArgs e)
        {
            if (txt_roomnum.Text != "" && txt_gid.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && txt_noa.Text != "" && txt_noc.Text != "" && cmb_rquality.Text != "" && txt_roomcharges.Text != "" && txt_rlc.Text != "")
            {
                SqlConnection connection = new SqlConnection(connectionString2);
                string query = $"DELETE [BooKRoom] WHERE Room_Number = '{txt_roomnum.Text}'";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Delete success!");
                    clear();
                    txt_noa.SelectedIndex = -1;
                    txt_noa.Text = "";
                    txt_noa.Items.Clear();

                    txt_noc.SelectedIndex = -1;
                    txt_noc.Text = "";
                    txt_noc.Items.Clear();

                    cmb_rquality.SelectedIndex = -1;
                    cmb_rquality.Text = "";
                    cmb_rquality.Items.Clear();

                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Delete Unsuccess!");
                }       
            }
        }

        private void cmb_rquality_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmb_rquality.SelectedItem.ToString();
            int price = 0;

            switch (selectedValue)
            {
                case "Superior Twin Room":
                    price = 4600;
                    break;
                case "Superior King Room":
                    price = 6500;
                    break;
                case "Deluxe Twin Room":
                    price = 8600;
                    break;
                case "Deluxe King Room":
                    price = 14000;
                    break;
                case "Premier Twin Room":
                    price = 15000;
                    break;
                case "Premier King Room":
                    price = 22000;
                    break;
                default:
                    price = 0;
                    break;
            }
            txt_roomcharges.Text = price.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            int roomPrice = 0;

            if (int.TryParse(txt_roomcharges.Text, out roomPrice))
            {
                TimeSpan duration = endDate - startDate;
                int totalDays = duration.Days + 1;

                int increasedDays = totalDays * 2;
                int totalCost = roomPrice * increasedDays;
                txt_rlc.Text = totalCost.ToString();
            }
        }
    }
}
