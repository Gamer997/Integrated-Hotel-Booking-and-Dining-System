namespace Hotel_Management_System_New
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnRooms = new System.Windows.Forms.Panel();
            this.pnFood = new System.Windows.Forms.Panel();
            this.pnServices = new System.Windows.Forms.Panel();
            this.pnFeedback = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Button();
            this.pnDashboard = new System.Windows.Forms.Button();
            this.pnMembership = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnRooms.SuspendLayout();
            this.pnFood.SuspendLayout();
            this.pnServices.SuspendLayout();
            this.pnFeedback.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.metroControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 27);
            this.panel1.TabIndex = 0;
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox1.IsDerivedStyle = true;
            this.metroControlBox1.Location = new System.Drawing.Point(1033, -4);
            this.metroControlBox1.MaximizeBox = true;
            this.metroControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeBox = true;
            this.metroControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox1.StyleManager = null;
            this.metroControlBox1.TabIndex = 1;
            this.metroControlBox1.Text = "metroControlBox1";
            this.metroControlBox1.ThemeAuthor = "Taiizor";
            this.metroControlBox1.ThemeName = "MetroLight";
            this.metroControlBox1.Click += new System.EventHandler(this.metroControlBox1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnRooms);
            this.sidebar.Controls.Add(this.pnFood);
            this.sidebar.Controls.Add(this.pnServices);
            this.sidebar.Controls.Add(this.pnFeedback);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 27);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(197, 592);
            this.sidebar.TabIndex = 1;
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel7);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Location = new System.Drawing.Point(3, 3);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(193, 52);
            this.menuContainer.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 52);
            this.panel2.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnDashboard);
            this.panel7.Location = new System.Drawing.Point(3, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 52);
            this.panel7.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnMembership);
            this.panel6.Location = new System.Drawing.Point(3, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(193, 52);
            this.panel6.TabIndex = 8;
            // 
            // pnRooms
            // 
            this.pnRooms.Controls.Add(this.button7);
            this.pnRooms.Location = new System.Drawing.Point(3, 61);
            this.pnRooms.Name = "pnRooms";
            this.pnRooms.Size = new System.Drawing.Size(193, 52);
            this.pnRooms.TabIndex = 10;
            // 
            // pnFood
            // 
            this.pnFood.Controls.Add(this.button2);
            this.pnFood.Location = new System.Drawing.Point(3, 119);
            this.pnFood.Name = "pnFood";
            this.pnFood.Size = new System.Drawing.Size(193, 52);
            this.pnFood.TabIndex = 4;
            // 
            // pnServices
            // 
            this.pnServices.Controls.Add(this.button3);
            this.pnServices.Location = new System.Drawing.Point(3, 177);
            this.pnServices.Name = "pnServices";
            this.pnServices.Size = new System.Drawing.Size(193, 52);
            this.pnServices.TabIndex = 5;
            // 
            // pnFeedback
            // 
            this.pnFeedback.Controls.Add(this.button4);
            this.pnFeedback.Location = new System.Drawing.Point(3, 235);
            this.pnFeedback.Name = "pnFeedback";
            this.pnFeedback.Size = new System.Drawing.Size(193, 52);
            this.pnFeedback.TabIndex = 6;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(197, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 130);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hotelify";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.pictureBox1.Image = global::Hotel_Management_System_New.Properties.Resources.hotel_white;
            this.pictureBox1.Location = new System.Drawing.Point(-16, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = global::Hotel_Management_System_New.Properties.Resources.home_16_px_light;
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(-20, -6);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menu.Size = new System.Drawing.Size(223, 74);
            this.menu.TabIndex = 2;
            this.menu.Text = "Home";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.pnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDashboard.ForeColor = System.Drawing.Color.White;
            this.pnDashboard.Image = global::Hotel_Management_System_New.Properties.Resources.dashboard16_px;
            this.pnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnDashboard.Location = new System.Drawing.Point(-16, -12);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnDashboard.Size = new System.Drawing.Size(223, 80);
            this.pnDashboard.TabIndex = 2;
            this.pnDashboard.Text = "      Dashboard";
            this.pnDashboard.UseVisualStyleBackColor = false;
            this.pnDashboard.Click += new System.EventHandler(this.pnDashboard_Click);
            // 
            // pnMembership
            // 
            this.pnMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.pnMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMembership.ForeColor = System.Drawing.Color.White;
            this.pnMembership.Image = global::Hotel_Management_System_New.Properties.Resources.membership_card;
            this.pnMembership.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMembership.Location = new System.Drawing.Point(-16, -12);
            this.pnMembership.Name = "pnMembership";
            this.pnMembership.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnMembership.Size = new System.Drawing.Size(223, 80);
            this.pnMembership.TabIndex = 2;
            this.pnMembership.Text = "       MemberShip";
            this.pnMembership.UseVisualStyleBackColor = false;
            this.pnMembership.Click += new System.EventHandler(this.pnMembership_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::Hotel_Management_System_New.Properties.Resources.bed_16_px1;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-16, -12);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(223, 80);
            this.button7.TabIndex = 2;
            this.button7.Text = "Rooms";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Hotel_Management_System_New.Properties.Resources.restaurant_cutlery_circular_symbol_of_a_spoon_and_a_fork_in_a_circle1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-15, -13);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(223, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "Food";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Hotel_Management_System_New.Properties.Resources.self_service;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-16, -10);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(223, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "Services";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Hotel_Management_System_New.Properties.Resources.feedback_16px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-14, -13);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(223, 80);
            this.button4.TabIndex = 2;
            this.button4.Text = "Feedback";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHam
            // 
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.Image = global::Hotel_Management_System_New.Properties.Resources.list_16px_light;
            this.btnHam.Location = new System.Drawing.Point(3, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(42, 26);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Hotel_Management_System_New.Properties.Resources.removenew32px;
            this.pictureBox2.Location = new System.Drawing.Point(1102, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1140, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnRooms.ResumeLayout(false);
            this.pnFood.ResumeLayout(false);
            this.pnServices.ResumeLayout(false);
            this.pnFeedback.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel pnFood;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnServices;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnFeedback;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button pnMembership;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button pnDashboard;
        private System.Windows.Forms.Panel pnRooms;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

