using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;  // Assuming you have a TextBox for username
            string password = textBox2.Text;  // Assuming you have a TextBox for password

            string role = null;
            if (radioButton1.Checked)
            {
                role = "Admin";
            }
            else if (radioButton2.Checked) { role = "Cashier"; } else if (radioButton3.Checked) { role = "Kitchen Staff"; }
            // Create an instance of the database class
            Database db = new Database();

            // Check if the login credentials (username, password, and role) are correct
            int UID = db.CheckLoginCredentials(username, password, role);

            if (UID!=0)
            {
                MessageBox.Show("Login successful!");

                // Role-based redirection or handling
                if (role == "Admin")
                {
                    // Redirect to Admin Form
                    new AdminForm().Show();
                }
                else if (role == "Cashier")
                {
                    // Redirect to Cashier Form
                    new CashierForm(UID).Show();
                }
                else if (role == "Kitchen Staff")
                {
                    // Redirect to Kitchen Form
                    new KitchenStaffForm().Show();
                }

                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WalkInCustomerForm(0).Show();
        }
    }
}
