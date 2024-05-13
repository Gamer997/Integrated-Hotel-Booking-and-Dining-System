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
using System.Xml.Linq;

namespace Hotel_Management_System_New
{
    public partial class RoomBooking : Form
    {
        public int TotalAmount { get; set; }
        public string RoomType { get; set; }
        
        private string email;

        private string username;
        public RoomBooking()
        {
            InitializeComponent();
            label4.Text = "0";

        }
        private void RoomBooking_Load(object sender, EventArgs e)
        {
            // Set the label text to display the total amount
            label4.Text = TotalAmount.ToString();
            label9.Text = RoomType;

        }

        private void UpdateLabel()
        {
            // Get the start and end dates from the DateTimePickers
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            // Calculate the number of days between the start and end dates
            int totalDays = (endDate - startDate).Days;

            // Calculate the total amount based on the number of days
            int totalAmount = totalDays * TotalAmount;

            // Update the label with the total amount
            label4.Text = totalAmount.ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate that name and email are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter both name and email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string to your database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\UserDetails.mdf;Integrated Security=True;Connect Timeout=30";

            // SQL query to check if the user already exists
            string query = "SELECT id FROM RoomsBooking WHERE email = @Email AND username = @Username";

            // SQL query to insert or update data based on whether the user already exists
            string insertOrUpdateQuery = @"
        IF EXISTS(SELECT id FROM RoomsBooking WHERE email = @Email AND username = @Username)
        BEGIN
            UPDATE RoomsBooking 
            SET total_cost = @TotalCost, check_in_date = @CheckInDate, check_out_date = @CheckOutDate, Type = @Type
            WHERE email = @Email AND username = @Username
        END
        ELSE
        BEGIN
            INSERT INTO RoomsBooking (email, username, total_cost, check_in_date, check_out_date, Type) 
            VALUES (@Email, @Username, @TotalCost, @CheckInDate, @CheckOutDate, @Type)
        END";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Username", username);
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    int id = result == null ? -1 : (int)result;

                    using (SqlCommand insertOrUpdateCmd = new SqlCommand(insertOrUpdateQuery, connection))
                    {
                        insertOrUpdateCmd.Parameters.AddWithValue("@Email", email);
                        insertOrUpdateCmd.Parameters.AddWithValue("@Username", username);
                        insertOrUpdateCmd.Parameters.AddWithValue("@TotalCost", label4.Text);
                        insertOrUpdateCmd.Parameters.AddWithValue("@CheckInDate", dateTimePicker1.Value);
                        insertOrUpdateCmd.Parameters.AddWithValue("@CheckOutDate", dateTimePicker2.Value);
                        insertOrUpdateCmd.Parameters.AddWithValue("@Type", label9.Text);

                        insertOrUpdateCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Room Booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void aloneTextBox1_TextChanged(object sender, EventArgs e)
        {
            username = aloneTextBox1.Text;
        }

        private void aloneTextBox2_TextChanged(object sender, EventArgs e)
        {
            email = aloneTextBox2.Text;
        }
    }
}
