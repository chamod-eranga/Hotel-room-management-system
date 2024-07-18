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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
        string connectionString = "Server=CHAMODERANGA;Integrated Security = True;";
        string connectionString2 = "Data Source=CHAMODERANGA;Initial Catalog = Admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        




        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Login (Name , Password) VALUES ('{txtName.Text}' , '{txtPassword.Text}')";
            string query2 = $"SELECT * FROM Login WHERE Name = '{txtName.Text}' AND Password = '{txtPassword.Text}'";

            
            var connection = new SqlConnection(connectionString2);

            connection.Open();
            var command = new SqlCommand(query2, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
              DialogResult result =  MessageBox.Show("Done", "Login successfull",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);

                if (result == DialogResult.OK)
                {
                    MainWindow mainwindow = new MainWindow();
                    mainwindow.Show();
                    
                }
                else 
                {
                    MessageBox.Show(DialogResult.Cancel.ToString());
                }


                

            }
            else 
            {
                MessageBox.Show("Error","Login Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            connection.Close();

            



            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                
            }
        }

  
    }
}
