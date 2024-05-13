using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Hotel_Management_System_New
{
    
    public partial class DashboardForm : Form
    {
        public string UserName;
        public string email;
        public decimal roomCost;
        public decimal foodCost_;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            UserName = Form1.instance.userName;
            email = Form1.instance.gmail;
            label12.Text = UserName;
            label14.Text = email;
            roomCost = CalculateRoomCost();
            foodCost_ = GetFoodCost();
            label6.Text = $"${foodCost_}";
            UpdateLabels();

            

        }
        private void UpdateLabels()
        {
            // Calculate and update room cost
            decimal roomCost = CalculateRoomCost();
            label5.Text = $"${roomCost}";

            // Update membership cost
            decimal membershipCost = GetMembershipCost();
            label8.Text = $"${membershipCost}";

            // Update food cost (if applicable)
            decimal foodCost = GetFoodCost();
            label6.Text = $"${foodCost}";

            // Calculate and update total cost
            decimal totalCost = roomCost + membershipCost + foodCost;
            label3.Text = $"${totalCost}";
        }
        private decimal CalculateRoomCost()
        {
            // Connect to your database and retrieve the room booking cost for the user
            // Replace the connection string with your actual connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\UserDetails.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT SUM(total_cost) FROM RoomsBooking WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }

            return 0; // Default to 0 if no room booking cost found
        }

        
        private void label11_Click(object sender, EventArgs e)
        {
            //

        }
        private decimal GetMembershipCost()
        {
            // Connect to your database and retrieve the membership cost for the user
            // Replace the connection string with your actual connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\UserDetails.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT SUM(Cost) FROM Membership WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }

            return 0; // Default to 0 if no membership cost found
        }
        private decimal GetFoodCost()
        {

            // Connect to your database and retrieve the total food cost for the user
            // Replace the connection string with your actual connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\FoodOrder.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT SUM(ItemCost) FROM FoodOrders WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }

            return 0; // Default to 0 if no food cost found
        }
        private void label5_Click(object sender, EventArgs e)
        {
            //Room cost 
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //MemberShip Cost

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Food Cost
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            //Total Cost Total cost is sum of Food cost+ MemberShip Cost + Room Cost
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void DashboardForm_Activated(object sender, EventArgs e)
        {
            // Update the labels every time the DashboardForm is activated
            UpdateLabels();
        }

        private void roundPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
