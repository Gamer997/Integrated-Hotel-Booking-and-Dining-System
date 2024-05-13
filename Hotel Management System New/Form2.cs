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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            RoomBooking roomBookingForm = new RoomBooking();

            // Pass the total amount as a parameter
            roomBookingForm.TotalAmount = 40;

            roomBookingForm.RoomType = "Family";

            // Show the RoomBooking form
            roomBookingForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the RoomBooking form
            RoomBooking roomBookingForm = new RoomBooking();

            // Pass the total amount as a parameter
            roomBookingForm.TotalAmount = 21;

            roomBookingForm.RoomType = "Studio";

            // Show the RoomBooking form
            roomBookingForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomBooking roomBookingForm = new RoomBooking();

            // Pass the total amount as a parameter
            roomBookingForm.TotalAmount = 66;

            roomBookingForm.RoomType = "Luxury";


            // Show the RoomBooking form
            roomBookingForm.Show();
        }
    }
}
