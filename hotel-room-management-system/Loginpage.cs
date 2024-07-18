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
using System.Drawing.Drawing2D;

namespace hotel_room_management_system
{
    public partial class LoginPage : Form
    {
        //movable custom border
        int mov;
        int movX;
        int movY;

        public string Name { get; set; }


        public LoginPage()
        {
            InitializeComponent();
                        
        }

        string connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\3-BIT\2ND Semester\ITE 1942 - ICT Project\MAIN PROJECT\Hotel Management System\hotel-room-management-system\hotel-room-management-system\HotelRoomManagementSystem.mdf;Integrated Security=True";


        private void Singup_btn_Click_1(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Login (Name , Password) VALUES ('{txtUsername.Text}' , '{txtPassword.Text}')";
            string query2 = $"SELECT * FROM Login WHERE UserName = '{txtUsername.Text}' AND Password = '{txtPassword.Text}'";


            try
            {
                var connection = new SqlConnection(connectionString2);

                connection.Open();
                var command = new SqlCommand(query2, connection);
                SqlDataReader reader = command.ExecuteReader();

                LoginPage loginPage = new LoginPage();
               

                while (reader.Read())
                {
                    // Access the data using the column names or indexes
                    loginPage.Name = reader.GetString(0);
                    // Process the retrieved data as desired
                }
               

                if (reader.HasRows)
                {
                    HomePage homePage = new HomePage(loginPage.Name);
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Error", "Login Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        txtPassword.Clear();
                        txtUsername.Clear();
                        txtPassword.Focus();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e) //movable custom border
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }


        private void panal1_MouseUp(object sender, MouseEventArgs e) //movable custom border
        {
            mov = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) //movable custom border
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}