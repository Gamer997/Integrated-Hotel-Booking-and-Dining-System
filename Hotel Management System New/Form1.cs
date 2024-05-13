using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_New
{
    
    public partial class Form1 : Form
    {
        public Form2 rooms;
        public FoodForm food;
        public FeedbackForm feedback;
        public ServicesForm services;
        public MembershipForm membership;
        public DashboardForm dashboard;
        public HomeForm home;
        public string userName, gmail;
        public static Form1 instance;
        public Form1(string UserName, string Email)
        {
            this.userName = UserName;
            this.gmail = Email;
            InitializeComponent();
            this.IsMdiContainer = true;
            instance = this;
        }

        private void metroControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instantiate HomeForm
            home = new HomeForm();

            // Set its properties
            home.MdiParent = this;
            home.Dock = DockStyle.Fill;

            // Show HomeForm
            home.Show();
        }
        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == true ) {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 170) { 
                menuTransition.Stop();
                    menuExpand = false;
                }

            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height<= 53)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            home.Activate();

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand )
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 51)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 197)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (rooms == null)
            {
                rooms = new Form2();
                rooms.FormClosed += Rooms_FormClosed;
                rooms.MdiParent = this;
                rooms.Dock = DockStyle.Fill;    
                rooms.Show();
            }
            else
            {
                rooms.Activate();
            }
        }
        private void Rooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            rooms?.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (food == null)
            {
                food = new FoodForm(this.userName, this.gmail);
                food.FormClosed += Food_FormClosed;
                food.MdiParent = this;
                food.Dock = DockStyle.Fill;
                food.Show();
            }
            else
            {
                food.Activate();
            }
        }
        private void Food_FormClosed(object sender, FormClosedEventArgs e)
        {
            food?.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (feedback == null)
            {
                feedback = new FeedbackForm();
                feedback.FormClosed += Feedback_FormClosed;
                feedback.MdiParent = this;
                feedback.Dock = DockStyle.Fill;
                feedback.Show();
            }
            else
            {
                feedback.Activate();
            }
        }
        private void Feedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            feedback?.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (services == null)
            {
                services = new ServicesForm();
                services.FormClosed += Services_FormClosed;
                services.MdiParent = this;
                services.Dock = DockStyle.Fill;
                services.Show();
            }
            else
            {
                services.Activate();
            }

        }
        private void Services_FormClosed(object sender, FormClosedEventArgs e)
        {
            services?.Activate();
        }

        private void pnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard== null)
            {
                dashboard = new DashboardForm();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard?.Activate();
        }

        private void pnMembership_Click(object sender, EventArgs e)
        {
            if (membership == null)
            {
                membership = new MembershipForm();
                membership.FormClosed += Dashboard_FormClosed;
                membership.MdiParent = this;
                membership.Dock = DockStyle.Fill;
                membership.Show();
            }
            else
            {
                membership.Activate();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Membership_FormClosed(object sender, FormClosedEventArgs e)
        {
            membership?.Activate();
        }
    }
}
