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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotel_Management_System_New
{
    
    public partial class MembershipForm : Form
    {
        private string userName;
        private string email;

        private string MembershipType { get; set; }
        public MembershipForm()
        {
            userName = Form1.instance.userName;
            email = Form1.instance.gmail;

            InitializeComponent();
        }

        private void MembershipForm_Load(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Silver
            //Payment confirmation
            BuyMembership("Silver", 30);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Gold
            BuyMembership("Gold", 50);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Platinum
            BuyMembership("Platinum", 80);

        }

        private void BuyMembership(string membershipType, decimal cost)
        {
            // Check if the user already has a membership of the same type
            if (UserHasMembershipOfType(membershipType))
            {
                MessageBox.Show("You cannot buy membership again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert the membership details into the database
            InsertMembershipDetails(membershipType, cost);

            // Show a success message
            MessageBox.Show("Membership purchased successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool UserHasMembershipOfType(string membershipType)
        {
            // SQL query to check if the user already has a membership of the same type
            string query = "SELECT COUNT(*) FROM Membership WHERE Email = @Email AND MembershipType = @MembershipType";

            // Connection string to your database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\UserDetails.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@MembershipType", membershipType);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private int GetNextUserId()
        {
            int nextUserId = 1; // Start from 1 by default

            string query = "SELECT MAX(id) FROM RoomsBooking";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Shahz\\OneDrive\\Documents\\UserDetails.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            nextUserId = Convert.ToInt32(result) + 1; // Increment the max UserId
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return nextUserId;
        }

        private void InsertMembershipDetails(string membershipType, decimal cost)
        {

            string query = "INSERT INTO MemberShip (UserName, Email, MembershipType, Cost, RegistrationDate) " +
               "VALUES (@UserName, @Email, @MembershipType, @Cost, @BookingTime)";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Shahz\\OneDrive\\Documents\\UserDetails.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@MembershipType", membershipType);
                    command.Parameters.AddWithValue("@Cost", cost);
                    command.Parameters.AddWithValue("@BookingTime", DateTime.Now);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }
        }

    }
}
