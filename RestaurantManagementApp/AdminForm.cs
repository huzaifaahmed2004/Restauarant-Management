
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LiveChartsCore.Measure;
namespace RestaurantManagementApp
{
    public partial class AdminForm : Form
    {
        Database db;
        bool pass = false;
        String ImagePath;
        string filePath = @"C:\Users\huzai\source\repos\RestaurantManagementApp\RestaurantManagementApp\";

        public AdminForm()
        {
            db = new Database();

            InitializeComponent();
            tabControl1.ItemSize = new Size(0, 1); // Hide tab header
            tabControl1.SizeMode = TabSizeMode.Fixed; // Ensures the tabs won't show up even when selected
                                                      // Assuming you have a TabPage object called tabPage1
            tabControl1.SelectedTab = Dashboard;
            panel3.Location = new Point(70, 28);
            panel6.Location = new Point(170, 28);
            panel4.Location = new Point(450, 28);
            panel5.Location = new Point(710, 28);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Login().Show();
        }


        private void AdjustDataGridViewColumns(DataGridView dg)
        {
            // Set AutoSizeMode for each column
            foreach (DataGridViewColumn column in dg.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // This will make the columns fill the available space
            }
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            db.SetTotalOrdersLabel(label4);
            db.SetTotalEarningsLabel(label5);
            db.SetTotalStaffLabel(label7);
            db.SetTotalCancelledOrdersLabel(label9);
            LoadMostCrowdedDayChart();
            LoadMostCrowdedTimeChart();
            LoadMostPopularFoodChart();


            comboBoxStatus.Items.Add("Completed");
            comboBoxStatus.Items.Add("Pending");
            comboBoxStatus.Items.Add("Cancelled");
            comboBoxStatus.SelectedIndex = 0; // Default selection

            // Set default date range (optional, based on your requirements)
            dateTimePickerStart.Value = DateTime.Now.AddMonths(-1); // 1 month ago
            dateTimePickerEnd.Value = DateTime.Now; // Today
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the image in the PictureBox and store the image path in the text box
                pictureBox5.Image = Image.FromFile(openFileDialog.FileName);
                ImagePath = Path.Combine("Images", Path.GetFileName(openFileDialog.FileName));

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        public void DisplayMenuItems()
        {
            // Get all menu items from the database
            DataTable dt = db.GetMenuItemNoPic();

            // Bind data to DataGridView
            dataGridView1.DataSource = dt;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Menu;
            DisplayMenuItems();
            AdjustDataGridViewColumns(dataGridView1);
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Get the input values from the textboxes
            string itemName = textBox2.Text.Trim();
            string category = textBox3.Text.Trim();

            // Validate item name
            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Item name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate price (make sure it's a valid decimal)
            decimal price;
            if (!decimal.TryParse(textBox4.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate category
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Category cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate image path (ensure image is selected)
            if (string.IsNullOrEmpty(ImagePath)) // Ensure the image path is not empty and the file exists
            {
                MessageBox.Show("Please select a valid image for the menu item!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // If all validations pass, add the menu item to the database
            AddMenuItem(itemName, price, category, ImagePath);

            // Refresh the menu items
            DisplayMenuItems();

            // Clear input fields (optional)
            textBox4.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            pictureBox5.Image = null; // Reset picturebox image
        }
        public void EditMenuItem(int itemId, string itemName, decimal price, string category, string imagePath)
        {
            // Validation checks for editing
            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Item name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Please enter a valid price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Category cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(imagePath)) // Ensure image path is valid
            {
                MessageBox.Show("Please select a valid image for the menu item!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If all validations pass, proceed to edit the item in the database
            db.EditMenuItem(itemId, itemName, price, category, imagePath);

            // Refresh the menu items list after successful update
            DisplayMenuItems(); // Assuming you're calling this from the form
        }

        // Delete a menu item (called when the admin clicks "Delete Menu Item" button)
        public void DeleteMenuItem(int itemId)
        {
            // Validation check to ensure item ID is valid
            if (itemId <= 0)
            {
                MessageBox.Show("Invalid item selected for deletion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm delete action
            DialogResult result = MessageBox.Show("Are you sure you want to delete this menu item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Proceed to delete the item from the database
                db.DeleteMenuItem(itemId);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                pictureBox5.Image = null;
                // Refresh the menu items list after successful deletion
                DisplayMenuItems(); // Assuming you're calling this from the form
            }
        }

        // Get ItemID by ItemName (used when editing or deleting items)
        public int GetItemIdByName(string itemName)
        {
            return db.GetItemIdByName(itemName);
        }
        public void AddMenuItem(string itemName, decimal price, string category, string imagePath)
        {
            // Add the item to the database
            db.AddMenuItem(itemName, price, category, imagePath);

            MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Ensure that the ItemID is populated in textBox1 and a menu item is selected
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select a menu item to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve the values from the text boxes
            int selectedItemId = int.Parse(textBox1.Text.Trim());  // ItemID from textBox1
            string itemName = textBox2.Text.Trim();  // ItemName from textBox2
            string category = textBox3.Text.Trim();  // Category from textBox3

            // Validate inputs
            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Item name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Category cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal price;
            if (!decimal.TryParse(textBox4.Text.Trim(), out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Call EditMenuItem method from Admin class to update the item in the database
            EditMenuItem(selectedItemId, itemName, price, category, ImagePath);

            // Refresh the DataGridView to show the updated data
            DisplayMenuItems();

            // Optionally, clear the textboxes after successful edit
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            pictureBox5.Image = null;

            MessageBox.Show("Menu item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void DisplayMenuItemDetails(int itemId)
        {
            // Call GetMenuItemById from the database class
            DataRow itemDetails = db.GetMenuItemById(itemId);

            if (itemDetails != null)
            {
                // Populate the text boxes with the retrieved details
                textBox1.Text = itemDetails["ItemID"].ToString();
                textBox2.Text = itemDetails["Name"].ToString();
                textBox3.Text = itemDetails["Category"].ToString();
                textBox4.Text = Convert.ToDecimal(itemDetails["Price"]).ToString("F2");

                // Load the image into the PictureBox
                ImagePath = itemDetails["ImagePath"]?.ToString();
                if (!string.IsNullOrEmpty(ImagePath))
                {
                    string fullImagePath = Path.Combine(filePath, ImagePath);
                    if (File.Exists(fullImagePath))
                    {
                        pictureBox5.Image = Image.FromFile(fullImagePath);
                    }
                    else
                    {
                        pictureBox5.Image = null; // Clear PictureBox if image not found
                        MessageBox.Show("Image file not found at the specified path.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    pictureBox5.Image = null; // Clear PictureBox if no image path is provided
                }
            }
            else
            {
                MessageBox.Show("No details found for the selected item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the ItemID of the selected row
                int selectedItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value); // Assuming ItemID is in the first column

                // Fetch the full details of the selected menu item
                DisplayMenuItemDetails(selectedItemId);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox1.Text);

            DeleteMenuItem(ID);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string itemName = textBox5.Text.Trim();

            if (!string.IsNullOrEmpty(itemName))
            {
                int id = db.GetItemIdByName(itemName);

                if (id > 0)
                {
                    DataRow dt = db.GetMenuItemByIdNoPic(id);

                    if (dt != null)
                    {
                        // Create a DataTable and add the DataRow to it
                        DataTable dataTable = dt.Table.Clone(); // Clone the structure of the original table
                        dataTable.ImportRow(dt);

                        // Bind data to DataGridView
                        dataGridView1.DataSource = dataTable;
                        AdjustDataGridViewColumns(dataGridView1);
                    }
                    else
                    {
                        dataGridView1.DataSource = null; // Clear the DataGridView if no item is found
                    }
                }
                else
                {
                    dataGridView1.DataSource = null; // Clear the DataGridView if no ID is found
                }
            }
            else
            {
                DisplayMenuItems();
                AdjustDataGridViewColumns(dataGridView1);// Clear the DataGridView if search text is empty
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Dashboard;
            LoadMostCrowdedDayChart();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = User;
            RefreshUsersGrid();
            AdjustDataGridViewColumns(dataGridView2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string username = textBox9.Text.Trim();
            string password = textBox7.Text.Trim();
            string role = comboBox1.SelectedItem?.ToString();

            // Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Hash the password
            string hashedPassword = db.HashPassword(password);

            // Add User
            db.AddUser(username, hashedPassword, role);
            RefreshUsersGrid();
            ClearUserInputs();
            MessageBox.Show("User added successfully.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text) || !int.TryParse(textBox10.Text.Trim(), out int userId))
            {
                MessageBox.Show("Please select a valid user to update.");
                return;
            }

            string username = textBox9.Text.Trim();
            string role = comboBox1.SelectedItem?.ToString();

            // Validate username and role fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields except the password if not changing.");
                return;
            }

            // Check if the password should be updated
            if (pass)
            {
                string password = textBox7.Text.Trim();
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter a password.");
                    return;
                }

                string hashedPassword = db.HashPassword(password);
                db.UpdateUser(userId, username, hashedPassword, role);
            }
            else
            {
                db.UpdateUserWithoutPass(userId, username, role);
            }

            RefreshUsersGrid();
            ClearUserInputs();
            MessageBox.Show("User updated successfully.");
            pass = false; // Reset the flag
        }


        private void button13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text) || !int.TryParse(textBox10.Text.Trim(), out int userId))
            {
                MessageBox.Show("Please select a valid user to delete.");
                return;
            }

            // Delete User
            db.DeleteUser(userId);
            RefreshUsersGrid();
            ClearUserInputs();
            MessageBox.Show("User deleted successfully.");
        }
        private void ClearUserInputs()
        {
            textBox10.Clear();
            textBox9.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = -1;
        }
        private void RefreshUsersGrid()
        {
            dataGridView2.DataSource = db.GetUsers(); // Example for Cashier, adjust as needed
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox6.Text.Trim();
            dataGridView2.DataSource = db.SearchUsersByName(searchText);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBox10.Text = row.Cells["UserID"].Value.ToString();
                textBox9.Text = row.Cells["Username"].Value.ToString();
                textBox7.Text = "*****";
                comboBox1.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pass = true;
            // Prompt for the password using InputDialog
            string enteredPassword = InputDialog.ShowDialog("Enter the Password:", "Password Input");

            // Check if a password was entered
            if (!string.IsNullOrWhiteSpace(enteredPassword))
            {
                textBox7.Text = enteredPassword; // Display the password in the TextBox
            }
            else
            {
                MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadMostCrowdedDayChart()
        {
            // Fetch data from the database
            DataTable dataTable = db.GetMostCrowdedDayData(); // Assuming 'db' is your database object

            // Parse data into lists for days and order counts
            var days = new List<string>();
            var customerCounts = new List<int>();

            foreach (DataRow row in dataTable.Rows)
            {
                // Get the day name (e.g., Sunday, Monday, etc.)
                days.Add(row["DayName"].ToString());

                // Get the order count (number of completed orders for each day)
                customerCounts.Add(Convert.ToInt32(row["OrderCount"]));
            }
            pieChart1.Width = 300;
            pieChart1.Height = 300;
            pieChart1.Location = new Point(30, 230);
            label23.Location = new Point(95, 240);

            // Create PieSeries for each day
            var pieSeries = days.Select((day, index) => new PieSeries<int>
            {

                Name = day, // Use the day name (Sunday, Monday, etc.)
                Values = new[] { customerCounts[index] }, // The corresponding order count
                DataLabelsPaint = new SolidColorPaint(SKColors.White), // White labels
                DataLabelsSize = 16, // Label font size
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle, // Position of the labels
            }).ToArray();

            // Set the PieSeries to the chart
            pieChart1.Series = pieSeries;

            // Customize chart appearance
            pieChart1.LegendTextPaint = new SolidColorPaint(SKColors.White); // Set legend text color
            pieChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right; // Set legend position
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Sale;
           
            LoadSalesData();
            AdjustDataGridViewColumns(dataGridView3);

        }
        public void LoadMostCrowdedTimeChart()
        {
            // Fetch data from the database using your method
            DataTable dataTable = db.GetMostCrowdedTimeData();

            // Create lists for hours and order counts
            var hours = new List<int>();
            var orderCounts = new List<int>();

            // Populate the lists with data from the database
            foreach (DataRow row in dataTable.Rows)
            {
                hours.Add(Convert.ToInt32(row["HourOfDay"]));
                orderCounts.Add(Convert.ToInt32(row["OrderCount"]));
            }

            // Create series for CartesianChart
            var lineSeries = new LineSeries<int>
            {
                DataLabelsSize = 16,
                DataLabelsPaint = new SolidColorPaint(SKColors.White),
                Values = (orderCounts), // Data for the line chart
                Fill = null, // Optional, remove fill under the line
                Stroke = new SolidColorPaint(SKColors.White), // Line color (white)
                GeometrySize = 5, // Size of the points on the line
                GeometryFill = new SolidColorPaint(SKColors.White), // Data points color (white)
                LineSmoothness = 0.5f // Smoothness of the line
            };

            // Create X-axis (hours) and Y-axis (order counts)
            var xAxis = new Axis
            {
                Labels = hours.Select(h => h.ToString()).ToArray(), // Labels for X-axis (hours)
                LabelsPaint = new SolidColorPaint(SKColors.White),
            };

            var yAxis = new Axis
            {
                Labeler = value => value.ToString(), // Display values on Y-axis
                LabelsPaint = new SolidColorPaint(SKColors.White),
            };

            // Set the series and axes on the chart
            cartesianChart1.Series = new ISeries[] { lineSeries }; // Adding the line series
            cartesianChart1.XAxes = new Axis[] { xAxis }; // Adding the X-axis

            cartesianChart1.YAxes = new Axis[] { yAxis }; // Adding the Y-axis
            panel7.Size = new Size(300, 340);
            cartesianChart1.Width = 300;
            cartesianChart1.Height = 300;

            panel7.Location = new Point(400, 230);
            //cartesianChart1.ForeColor = Color.White;
            //label24.Location = new Point(600, 240);
            // Customize chart appearance
        }
        public void LoadMostPopularFoodChart()
        {
            // Fetch data from database
            DataTable dataTable = db.GetMostPopularFoodData();

            // Create lists to store chart data
            var foodNames = new List<string>();
            var orderCounts = new List<int>();

            foreach (DataRow row in dataTable.Rows)
            {
                foodNames.Add(row["ItemName"].ToString());
                orderCounts.Add(Convert.ToInt32(row["OrderCount"]));
            }

            // Create series for the pie chart
            var pieSeries = foodNames.Select((food, index) => new PieSeries<int>
            {
                Name = food,
                Values = new[] { orderCounts[index] },
                DataLabelsPaint = new SolidColorPaint(SKColors.White),
                DataLabelsSize = 16,
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
            }).ToArray();

            // Set series to the pie chart
            pieChart2.Series = pieSeries;

            // Chart appearance customization
            pieChart2.LegendTextPaint = new SolidColorPaint(SKColors.White);
            pieChart2.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            pieChart2.Location = new Point(770, 230);
            pieChart2.Size = new Size(330, 300);
            label25.Location = new Point(890, 240);
        }
        public void LoadSalesData()
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date.AddDays(1).AddTicks(-1); // End of the selected day

            string status = comboBoxStatus.SelectedItem?.ToString(); // Get selected status
            string orderId = textBoxOrderID.Text.Trim(); // Get Order ID search input

            // Check if DatePickers are set to the default date (i.e., the user didn't select anything)
            if (startDate == DateTime.MinValue || endDate == DateTime.MinValue)
            {
                // If no date is selected, load all orders
                startDate = DateTime.MinValue;
                endDate = DateTime.MaxValue;
            }

            // Check if the status filter is empty (i.e., user didn't select a status)
            if (string.IsNullOrEmpty(status))
            {
                status = null; // Treat as no filter for status
            }

            // Call method to get filtered orders
            DataTable salesData = db.GetFilteredOrders(startDate, endDate, status, orderId);

            // Bind data to DataGridView
            dataGridView3.DataSource = salesData;

            // Calculate and display total price
            decimal totalPrice = salesData.AsEnumerable()
                                          .Sum(row => row.Field<decimal>("TotalAmount"));

            label31.Text = $"Total Price: {totalPrice:C}"; // Display the total price in a label
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesData();
            AdjustDataGridViewColumns(dataGridView3);
        }

        private void textBoxOrderID_TextChanged(object sender, EventArgs e)
        {
            LoadSalesData();
            AdjustDataGridViewColumns(dataGridView3);
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesData();
            AdjustDataGridViewColumns(dataGridView3);
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSalesData();
            AdjustDataGridViewColumns(dataGridView3);
        }
    }
}
