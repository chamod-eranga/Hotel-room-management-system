using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel_room_management_system.New_staff_member_register;

namespace hotel_room_management_system
{
    public partial class HomePage : Form

    {
        int mov;
        int movX;
        int movY;

        public HomePage(string _name)
        {
            InitializeComponent();
            timer1.Start();
            Time_txt.Text = DateTime.Now.ToString("hh:mm:ss ");
            Date_txt.Text = DateTime.Now.ToLongDateString();

            btn_Staff.Enabled = false;

            if (_name == "Manager") 
            {
                btn_Staff.Enabled = true;
            }
        }

       

        private void btn_Dash_Click_1(object sender, EventArgs e)
        {
            dash form2 = new dash();
            form2.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form2);
            form2.Dock = DockStyle.Fill;
            form2.Show();
        }

        private void btn_BOOKING_Click_1(object sender, EventArgs e)
        {
            booking form3 = new booking();
            form3.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.Dock = DockStyle.Fill;
            form3.Show();
        }

        private void btn_gestroom_Click_1(object sender, EventArgs e)
        {
            geuestroom form4 = new geuestroom();
            form4.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form4);
            form4.Dock = DockStyle.Fill;
            form4.Show();
        }

        private void btn_feedcheak_Click_1(object sender, EventArgs e)
        {
            feedcheak form5 = new feedcheak();
            form5.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form5);
            form5.Dock = DockStyle.Fill;
            form5.Show();
        }

        private void btn_Staff_Click_1(object sender, EventArgs e)
        {
            var userControl = new new_member_reg();

            userControl.Size = panel1.Size;
            userControl.Location = new Point(0, 0);
            panel1.Controls.Add(userControl);

            new_member_reg form2 = new new_member_reg();
            panel1.Controls.Clear();
            form2.Dock = DockStyle.Fill;
            panel1.Controls.Add(form2);

            form2.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            dash subForm = new dash();
            subForm.TopLevel = false;
            subForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(subForm);
            subForm.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();

            this.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Time_txt.Text = DateTime.Now.ToString("hh:mm:ss ");
            Date_txt.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelheader_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panelheader_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
