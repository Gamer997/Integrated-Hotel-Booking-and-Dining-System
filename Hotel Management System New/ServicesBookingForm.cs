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

namespace Hotel_Management_System_New
{
    public partial class ServicesBookingForm : Form
    {

        public string Type { get; set; }
        public string Total_Type { get; set; }
        public int Total_amount { get; set; }
        private int Fixed_amount;
        private int counter;
        public ServicesBookingForm()
        {

        InitializeComponent();

        }
        private void UpdateLabel_increment()
        {
            counter++;
            Total_amount = Fixed_amount * counter;
            label4.Text = Total_amount.ToString();
        }

        private void UpdateLabel_decrement()
        {

            if (Total_amount > 0)
            {
                counter--;
                Total_amount = Fixed_amount * counter;
            }
            label4.Text = Total_amount.ToString();
        }
        private void aloneTextBox1_TextChanged(object sender, EventArgs e)
        {
            //UserName

        }

        private void aloneTextBox2_TextChanged(object sender, EventArgs e)
        {
            //Usermail
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Booking Date
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(label11.Text);
            UpdateLabel_increment();
            label11.Text = (currentValue + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(label11.Text);
            if (currentValue > 0)
            {
                UpdateLabel_decrement();
                label11.Text = (currentValue - 1).ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Label telling total 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Cost Label 
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //Label Telling Type of service 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = aloneTextBox1.Text;
            string userEmail = aloneTextBox2.Text;
            string serviceUsed = label9.Text;
            int cost = int.Parse(label4.Text);
            DateTime bookingTime = DateTime.Now;

            // Store booking details in the database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\ServicesDataBase.mdf;Integrated Security=True;Connect Timeout=30";
            string query = @"INSERT INTO ServicesUsed (UserName, Email, ServiceUsed, Cost, BookingTime) VALUES (@UserName, @Email, @ServiceUsed, @Cost, @BookingTime)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Email", userEmail);
                        command.Parameters.AddWithValue("@ServiceUsed", serviceUsed);
                        command.Parameters.AddWithValue("@Cost", cost);
                        command.Parameters.AddWithValue("@BookingTime", bookingTime);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Service Booking Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save booking details to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServicesBookingForm_Load(object sender, EventArgs e)
        {
            label2.Text = Total_Type;
            label4.Text = Total_amount.ToString();
            label9.Text = Type;
            label11.Text = "1";
            Fixed_amount = Total_amount;
            counter = 1;
        }
    }
}
