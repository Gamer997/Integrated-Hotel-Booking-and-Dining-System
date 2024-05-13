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
    public partial class FoodFormItems : Form
    {
        public string username;
        public string email;
        public int cost_value;
        public SqlConnection connection;
        public static FoodFormItems instance;
        
        public FoodFormItems(string username_, string email_)
        {
            InitializeComponent();

            // Initialize username, email, and database connection
            this.username = username_;
            this.email = email_;
            cost_value = 0;
            instance = this;
            // Initialize the connection using the provided connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\FoodOrder.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);

        }
        private void AddItemToTotalPanel(string itemName, decimal itemCost)
        {
            // Create a new panel to hold the item and delete button
            Panel itemPanel = new Panel();
            itemPanel.Size = new Size(200, 40); // Set the size of the panel

            // Calculate the vertical position of the new item panel based on the number of existing controls
            int yOffset = TotalPanel.Controls.Count * (itemPanel.Height + 5);

            // Set the location of the new item panel
            itemPanel.Location = new Point(0, yOffset);

            // Create a new label to display the item name and cost
            Label itemLabel = new Label();
            itemLabel.Text = itemName + " - $" + itemCost.ToString("0.00"); // Format the cost to display two decimal places
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(5, 5); // Set the location of the label within the panel

            // Create a new button to delete the item
            Button deleteButton = new Button();
            deleteButton.Text = "DEL";
            deleteButton.Size = new Size(48, 23);
            deleteButton.Location = new Point(155, 3); // Set the location of the button within the panel
            deleteButton.Click += (sender, e) => TotalPanel.Controls.Remove(itemPanel); // Event handler to remove the itemPanel when delete button is clicked

            // Add the label and delete button to the itemPanel
            itemPanel.Controls.Add(itemLabel);
            itemPanel.Controls.Add(deleteButton);

            // Add the itemPanel to the TotalPanel
            TotalPanel.Controls.Add(itemPanel);
        }

        // Event handler for button clicks (assuming each button represents a menu item)
        private void MenuItemButton_Click(object sender, EventArgs e)
        {
            // Get the button that was clicked
            Button menuItemButton = (Button)sender;

            // Extract the item name and cost from the button's Tag property (assuming you've set the Tag property of each button to store this information)
            string itemName = menuItemButton.Text; // You can change this to fetch the name from the database or another source if needed
            decimal itemCost = Convert.ToDecimal(menuItemButton.Tag); // You can change this to fetch the cost from the database or another source if needed

            // Add the item to the TotalPanel
            AddItemToTotalPanel(itemName, itemCost);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FoodFormItems_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Chow-Men", 6);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

                // Add "Chicken Karahi" with price $8 to the TotalPanel
                AddItemToTotalPanel("KarahiChick", 11);
            
        }

        private void TotalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Shahi Daal", 12);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Birayni", 7);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Beef Nihari", 6);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Mix Sabzi", 3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Seekh Kebab", 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Arabic Mandi", 22);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Shashlik Stick", 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Italian Steak", 13);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Mexican Tacos", 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Pan Cakes", 2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Zinger Burger", 4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Chicken Piece", 2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Crown-Crust", 17);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Creamy Pasta", 5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("ShawarmaArbi", 3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("French Fries", 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("PlatterLarge", 40);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Chapati", 2);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Roti/Naan", 3);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Coffee", 1);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Smoothie", 2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            AddItemToTotalPanel("Margarita", 2);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {

            bool hasMembership = UserHasMembership();

            bool hasItems = false;
            foreach (Control control in TotalPanel.Controls)
            {
                if (control is Panel itemPanel)
                {
                    hasItems = true;
                    break;
                }
            }

            if (!hasItems)
            {
                MessageBox.Show("Please order something before confirming your order.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate total cost
            decimal totalCost = 0;
            foreach (Control control in TotalPanel.Controls)
            {
                if (control is Panel itemPanel)
                {
                    Label itemLabel = (Label)itemPanel.Controls[0];
                    string[] itemInfo = itemLabel.Text.Split(new string[] { " - $" }, StringSplitOptions.RemoveEmptyEntries);
                    decimal itemCost = Convert.ToDecimal(itemInfo[1]);

                    // Apply discount if the user has a membership
                    if (hasMembership)
                    {
                        itemCost *= 0.8m; // Apply 20% discount
                    }

                    totalCost += itemCost;
                }
            }

            // Prepare the SQL query
            string query = "INSERT INTO FoodOrders (Username, Email, OrderedItem, ItemCost) VALUES (@Username, @Email, @OrderedItem, @ItemCost)";

            try
            {
                // Open the database connection
                connection.Open();

                // Insert each item into the database
                foreach (Control control in TotalPanel.Controls)
                {
                    if (control is Panel itemPanel)
                    {
                        Label itemLabel = (Label)itemPanel.Controls[0];
                        string[] itemInfo = itemLabel.Text.Split(new string[] { " - $" }, StringSplitOptions.RemoveEmptyEntries);
                        string itemName = itemInfo[0];
                        decimal itemCost = Convert.ToDecimal(itemInfo[1]);

                        // Apply discount if the user has a membership
                        if (hasMembership)
                        {
                            itemCost *= 0.8m; // Apply 20% discount
                        }

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the command
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@OrderedItem", itemName);
                            command.Parameters.AddWithValue("@ItemCost", itemCost);

                            // Execute the command
                            command.ExecuteNonQuery();
                        }
                    }
                }

                // Show a success message with the total cost
                this.Close();
                MessageBox.Show($"Food ordered successfully! Your total cost for this meal is ${totalCost}.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show($"Error storing order in database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }


        }

        private bool UserHasMembership()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahz\OneDrive\Documents\UserDetails.mdf;Integrated Security=True;Connect Timeout=30";

            // SQL query to check if the user has purchased a membership
            string query = "SELECT COUNT(*) FROM MemberShip WHERE Email = @Email";

            try
            {
                // Open connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show($"Error checking membership status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
