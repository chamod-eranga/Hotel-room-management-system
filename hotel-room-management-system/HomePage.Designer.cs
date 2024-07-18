
namespace hotel_room_management_system
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelside = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Dash = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.Date_txt = new System.Windows.Forms.Label();
            this.btn_feedcheak = new System.Windows.Forms.Button();
            this.Time_txt = new System.Windows.Forms.Label();
            this.btn_gestroom = new System.Windows.Forms.Button();
            this.btn_BOOKING = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelheader.SuspendLayout();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.SlateGray;
            this.panelheader.Controls.Add(this.btn_minimize);
            this.panelheader.Controls.Add(this.btn_close);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1109, 36);
            this.panelheader.TabIndex = 7;
            this.panelheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseDown);
            this.panelheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseMove);
            this.panelheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelheader_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.Location = new System.Drawing.Point(1038, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 29);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "−";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(1074, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 29);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "×";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(284, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 645);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.SlateGray;
            this.panelside.Controls.Add(this.pictureBox7);
            this.panelside.Controls.Add(this.pictureBox6);
            this.panelside.Controls.Add(this.pictureBox5);
            this.panelside.Controls.Add(this.pictureBox4);
            this.panelside.Controls.Add(this.pictureBox3);
            this.panelside.Controls.Add(this.pictureBox2);
            this.panelside.Controls.Add(this.btn_Dash);
            this.panelside.Controls.Add(this.logout_btn);
            this.panelside.Controls.Add(this.btn_Staff);
            this.panelside.Controls.Add(this.Date_txt);
            this.panelside.Controls.Add(this.btn_feedcheak);
            this.panelside.Controls.Add(this.Time_txt);
            this.panelside.Controls.Add(this.btn_gestroom);
            this.panelside.Controls.Add(this.btn_BOOKING);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 36);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(284, 645);
            this.panelside.TabIndex = 6;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::hotel_room_management_system.Properties.Resources.calendar;
            this.pictureBox7.Location = new System.Drawing.Point(13, 364);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::hotel_room_management_system.Properties.Resources.room;
            this.pictureBox6.Location = new System.Drawing.Point(13, 415);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 39;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::hotel_room_management_system.Properties.Resources.completed_task;
            this.pictureBox5.Location = new System.Drawing.Point(13, 479);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::hotel_room_management_system.Properties.Resources.people;
            this.pictureBox4.Location = new System.Drawing.Point(13, 540);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::hotel_room_management_system.Properties.Resources.check_out;
            this.pictureBox3.Location = new System.Drawing.Point(13, 589);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hotel_room_management_system.Properties.Resources.dashboard;
            this.pictureBox2.Location = new System.Drawing.Point(13, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Dash
            // 
            this.btn_Dash.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Dash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Dash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dash.FlatAppearance.BorderSize = 0;
            this.btn_Dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dash.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dash.ForeColor = System.Drawing.Color.Black;
            this.btn_Dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dash.Location = new System.Drawing.Point(47, 314);
            this.btn_Dash.Name = "btn_Dash";
            this.btn_Dash.Size = new System.Drawing.Size(200, 33);
            this.btn_Dash.TabIndex = 34;
            this.btn_Dash.Text = "DASHBOARD";
            this.btn_Dash.UseVisualStyleBackColor = false;
            this.btn_Dash.Click += new System.EventHandler(this.btn_Dash_Click_1);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(49, 589);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(200, 33);
            this.logout_btn.TabIndex = 33;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Staff.FlatAppearance.BorderSize = 0;
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Staff.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.Black;
            this.btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Staff.Location = new System.Drawing.Point(46, 540);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(204, 33);
            this.btn_Staff.TabIndex = 32;
            this.btn_Staff.Text = "STAFF REGISTRATION";
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click_1);
            // 
            // Date_txt
            // 
            this.Date_txt.AutoSize = true;
            this.Date_txt.BackColor = System.Drawing.Color.Transparent;
            this.Date_txt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_txt.ForeColor = System.Drawing.Color.Black;
            this.Date_txt.Location = new System.Drawing.Point(34, 271);
            this.Date_txt.Name = "Date_txt";
            this.Date_txt.Size = new System.Drawing.Size(222, 19);
            this.Date_txt.TabIndex = 31;
            this.Date_txt.Text = "Thursday, 18  September 2023";
            // 
            // btn_feedcheak
            // 
            this.btn_feedcheak.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_feedcheak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_feedcheak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_feedcheak.FlatAppearance.BorderSize = 0;
            this.btn_feedcheak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_feedcheak.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_feedcheak.ForeColor = System.Drawing.Color.Black;
            this.btn_feedcheak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_feedcheak.Location = new System.Drawing.Point(46, 466);
            this.btn_feedcheak.Name = "btn_feedcheak";
            this.btn_feedcheak.Size = new System.Drawing.Size(204, 59);
            this.btn_feedcheak.TabIndex = 11;
            this.btn_feedcheak.Text = "FEEDBACK / CHECKINS";
            this.btn_feedcheak.UseVisualStyleBackColor = false;
            this.btn_feedcheak.Click += new System.EventHandler(this.btn_feedcheak_Click_1);
            // 
            // Time_txt
            // 
            this.Time_txt.AutoSize = true;
            this.Time_txt.BackColor = System.Drawing.Color.Transparent;
            this.Time_txt.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Time_txt.Location = new System.Drawing.Point(79, 227);
            this.Time_txt.Name = "Time_txt";
            this.Time_txt.Size = new System.Drawing.Size(119, 32);
            this.Time_txt.TabIndex = 30;
            this.Time_txt.Text = "10:59:58";
            // 
            // btn_gestroom
            // 
            this.btn_gestroom.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_gestroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gestroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gestroom.FlatAppearance.BorderSize = 0;
            this.btn_gestroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gestroom.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestroom.ForeColor = System.Drawing.Color.Black;
            this.btn_gestroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gestroom.Location = new System.Drawing.Point(49, 415);
            this.btn_gestroom.Name = "btn_gestroom";
            this.btn_gestroom.Size = new System.Drawing.Size(200, 33);
            this.btn_gestroom.TabIndex = 7;
            this.btn_gestroom.Text = "GUESTS / ROOMS";
            this.btn_gestroom.UseVisualStyleBackColor = false;
            this.btn_gestroom.Click += new System.EventHandler(this.btn_gestroom_Click_1);
            // 
            // btn_BOOKING
            // 
            this.btn_BOOKING.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_BOOKING.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BOOKING.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BOOKING.FlatAppearance.BorderSize = 0;
            this.btn_BOOKING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BOOKING.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BOOKING.ForeColor = System.Drawing.Color.Black;
            this.btn_BOOKING.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BOOKING.Location = new System.Drawing.Point(49, 364);
            this.btn_BOOKING.Name = "btn_BOOKING";
            this.btn_BOOKING.Size = new System.Drawing.Size(200, 33);
            this.btn_BOOKING.TabIndex = 6;
            this.btn_BOOKING.Text = "BOOKING";
            this.btn_BOOKING.UseVisualStyleBackColor = false;
            this.btn_BOOKING.Click += new System.EventHandler(this.btn_BOOKING_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel_room_management_system.Properties.Resources.Casher;
            this.pictureBox1.Location = new System.Drawing.Point(40, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.ClientSize = new System.Drawing.Size(1109, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelheader.ResumeLayout(false);
            this.panelside.ResumeLayout(false);
            this.panelside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Dash;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Label Date_txt;
        private System.Windows.Forms.Button btn_feedcheak;
        private System.Windows.Forms.Label Time_txt;
        private System.Windows.Forms.Button btn_gestroom;
        private System.Windows.Forms.Button btn_BOOKING;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}