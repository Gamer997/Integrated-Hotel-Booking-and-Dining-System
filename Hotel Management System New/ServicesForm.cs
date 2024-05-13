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
    public partial class ServicesForm : Form
    {

        private int carWashCost = 10;
        private int laundryCost = 5;
        private int massageCost = 20;
        private int cityTourCost = 30;
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Car Wash button
            ServicesBookingForm serviceBookingForm = new ServicesBookingForm();
            serviceBookingForm.Total_Type = "Total Cars";
            serviceBookingForm.Total_amount = 9;
            serviceBookingForm.Type = "CarWash";
            serviceBookingForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicesBookingForm serviceBookingForm = new ServicesBookingForm();
            serviceBookingForm.Total_Type = "Total Pieces";
            serviceBookingForm.Total_amount = 3;
            serviceBookingForm.Type = "Laundary";
            serviceBookingForm.Show();

            //Laundary Button
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Massage Button

            ServicesBookingForm serviceBookingForm = new ServicesBookingForm ();
            serviceBookingForm.Total_Type = "Total Persons";
            serviceBookingForm.Total_amount = 14;
            serviceBookingForm.Type = "Masssage";
            serviceBookingForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServicesBookingForm serviceBookingForm = new ServicesBookingForm();
            //City Tour Button
            serviceBookingForm.Total_Type = "Total Tourists";
            serviceBookingForm.Total_amount = 10;
            serviceBookingForm.Type = "City Tour";
            serviceBookingForm.Show();
        }
    }
}
