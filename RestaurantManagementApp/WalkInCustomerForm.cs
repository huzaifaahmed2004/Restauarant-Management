using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementApp
{
    public partial class WalkInCustomerForm : Form
    {
        int uid;
        public WalkInCustomerForm(int UID)
        {
            InitializeComponent();
            uid = UID;
        }
        private void AddMenuItemsToPanel()
        {
            Database db = new Database();
            DataTable menuItems = db.GetMenuItems();

            // Clear any existing controls in the panel
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in menuItems.Rows)
            {
                TableLayoutPanel itemPanel = new TableLayoutPanel
                {
                    RowCount = 4,
                    ColumnCount = 1,
                    Size = new Size(200, 300),
                    AutoSize = false,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    BackColor = ColorTranslator.FromHtml("#1c1816") // light black for item background
                };
                string filePath = @"C:\Users\huzai\source\repos\RestaurantManagementApp\RestaurantManagementApp\";

                // Image setup (unchanged)
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(180, 180),
                    ImageLocation = Path.Combine(filePath, row["ImagePath"].ToString()),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Item Name (Soft Gold)
                Label itemNameLabel = new Label
                {
                    Text = row["ItemName"].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    ForeColor = ColorTranslator.FromHtml("#ffffff") // White
                };

                // Item Price (Soft Gold)
                Label itemPriceLabel = new Label
                {
                    Text = "$" + row["Price"].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    ForeColor = ColorTranslator.FromHtml("#ffffff") // Soft Gold
                };

                // Button setup (Soft Gold or Light Blue)
                Button addButton = new Button
                {
                    Text = "Add to Order",
                    Width = 180,
                    Height = 40,
                    BackColor = ColorTranslator.FromHtml("#ee2c2a"), // Red
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 11.25F, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = ColorTranslator.FromHtml("#ffffff")
                };

                addButton.Click += (sender, e) =>
                {
                    string quantityInput = InputDialog.ShowDialog("Enter quantity:", "Quantity");
                    int quantity;
                    if (int.TryParse(quantityInput, out quantity) && quantity > 0)
                    {
                        AddItemToOrder(row, quantity);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid quantity.");
                    }
                };

                // Add controls to the item panel (image, name, price, button)
                itemPanel.Controls.Add(pictureBox, 0, 0);
                itemPanel.Controls.Add(itemNameLabel, 0, 1);
                itemPanel.Controls.Add(itemPriceLabel, 0, 2);
                itemPanel.Controls.Add(addButton, 0, 3);

                // Add item panel to the main panel
                flowLayoutPanel1.Controls.Add(itemPanel);
            }
        }





        // Method to add the item to the order panel on the left
        // Method to add the item to the order panel on the left
        private void AddItemToOrder(DataRow itemRow, int quantity)
        {
            FlowLayoutPanel orderItemPanel = new FlowLayoutPanel
            {
                Size = new Size(200, 80),
                FlowDirection = FlowDirection.LeftToRight,
                Margin = new Padding(10)
            };

            // Labels with Soft Gold text
            Label itemNameLabel = new Label
            {
                Text = itemRow["ItemName"].ToString(),
                Width = 100,
                Font = new Font("Segoe UI", 11F),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = ColorTranslator.FromHtml("#ffffff") // Soft Gold
            };

            Label itemQuantityLabel = new Label
            {
                Text = "Qty: " + quantity.ToString(),
                Width = 50,
                Font = new Font("Segoe UI", 11F),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = ColorTranslator.FromHtml("#ffffff") // Soft Gold
            };

            Label itemPriceLabel = new Label
            {
                Text = "$" + (Convert.ToDecimal(itemRow["Price"]) * quantity).ToString("F2"),
                Width = 80,
                Font = new Font("Segoe UI", 11F),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = ColorTranslator.FromHtml("#ffffff") // Soft Gold
            };

            // Buttons with light blue color or Soft Gold
            Button increaseButton = new Button
            {
                Text = "↑",
                Width = 30,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = ColorTranslator.FromHtml("#ffffff"),
                BackColor = ColorTranslator.FromHtml("#ee2c2a")
            };
            Button decreaseButton = new Button
            {
                Text = "↓",
                Width = 30,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = ColorTranslator.FromHtml("#ffffff"),
                BackColor = ColorTranslator.FromHtml("#ee2c2a")
            };
            Button removeButton = new Button
            {
                Text = "Remove",
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 60,
                ForeColor = ColorTranslator.FromHtml("#ffffff"),
                BackColor = ColorTranslator.FromHtml("#ee2c2a")
            };

            increaseButton.Click += (sender, e) =>
            {
                quantity++;
                itemQuantityLabel.Text = "Qty: " + quantity.ToString();
                itemPriceLabel.Text = "$" + (Convert.ToDecimal(itemRow["Price"]) * quantity).ToString("F2");
                UpdateTotalQuantity();
            };

            decreaseButton.Click += (sender, e) =>
            {
                if (quantity > 1)
                {
                    quantity--;
                    itemQuantityLabel.Text = "Qty: " + quantity.ToString();
                    itemPriceLabel.Text = "$" + (Convert.ToDecimal(itemRow["Price"]) * quantity).ToString("F2");
                    UpdateTotalQuantity();
                }
            };

            removeButton.Click += (sender, e) =>
            {
                orderPanel.Controls.Remove(orderItemPanel);
                UpdateTotalQuantity();
            };

            // Add controls to the order item panel
            orderItemPanel.Controls.Add(itemNameLabel);
            orderItemPanel.Controls.Add(itemQuantityLabel);
            orderItemPanel.Controls.Add(itemPriceLabel);
            orderItemPanel.Controls.Add(increaseButton);
            orderItemPanel.Controls.Add(decreaseButton);
            orderItemPanel.Controls.Add(removeButton);

            // Add the order item panel to the order panel
            orderPanel.Controls.Add(orderItemPanel);

            // Update total quantity and price
            UpdateTotalQuantity();
        }


        // Method to update the total quantity and price
        private void UpdateTotalQuantity()
        {
            int totalQuantity = 0;
            decimal totalPrice = 0;

            foreach (Control control in orderPanel.Controls)
            {
                if (control is FlowLayoutPanel itemPanel)
                {
                    Label qtyLabel = itemPanel.Controls.OfType<Label>().FirstOrDefault(label => label.Text.StartsWith("Qty"));
                    Label priceLabel = itemPanel.Controls.OfType<Label>().FirstOrDefault(label => label.Text.StartsWith("$"));
                    if (qtyLabel != null && priceLabel != null)
                    {
                        int quantity = int.Parse(qtyLabel.Text.Substring(4));
                        decimal price = decimal.Parse(priceLabel.Text.Substring(1));
                        totalQuantity += quantity;
                        totalPrice += price;
                    }
                }
            }

            // Update total quantity and total price (this can be displayed at the bottom of the order panel)
            label2.Text = "Total Quantity: " + totalQuantity.ToString();
            label3.Text = "Total Price: $" + totalPrice.ToString("F2");
        }
        // Add total quantity and total price labels at the bottom of the order panel


        private void WalkInCustomerForm_Load(object sender, EventArgs e)
        {
            if (uid!= 0)
            {
                button2.Text = "Go Back";
            }
            AddMenuItemsToPanel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Insert order into the database
            int orderId = InsertOrderToDatabase();

            // Step 2: Check if order was inserted successfully
            if (orderId > 0)
            {
                 Database db= new Database();
                double amount = Double.Parse(label3.Text.Replace("Total Price: $", "").Trim());


                db.InsertPaymentToDatabase(orderId,amount);
                // Step 3: Generate and display the receipt
                GenerateReceipt(orderId);
                ClearOrderList();
                MessageBox.Show("Order placed successfully, and receipt generated!");
            }
            else
            {
                MessageBox.Show("Failed to place order. Please try again.");
            }
        }

        private int InsertOrderToDatabase()
        {
            Database db = new Database();

            try
            {
                // Insert into Orders table

                string orderTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string orderStatus = "Pending";

                int orderId = db.InsertOrder(orderTime, orderStatus);

                // Insert into OrderDetails table
                foreach (Control control in orderPanel.Controls)
                {
                    if (control is FlowLayoutPanel itemPanel)
                    {
                        Label qtyLabel = itemPanel.Controls.OfType<Label>().FirstOrDefault(label => label.Text.StartsWith("Qty"));
                        Label priceLabel = itemPanel.Controls.OfType<Label>().FirstOrDefault(label => label.Text.StartsWith("$"));
                        Label itemNameLabel = itemPanel.Controls.OfType<Label>().FirstOrDefault(label => !label.Text.StartsWith("Qty") && !label.Text.StartsWith("$"));

                        if (qtyLabel != null && priceLabel != null && itemNameLabel != null)
                        {
                            int quantity = int.Parse(qtyLabel.Text.Substring(4));
                            decimal price = decimal.Parse(priceLabel.Text.Substring(1));
                            string itemName = itemNameLabel.Text;

                            // Get item ID by item name (or include it directly in the UI for efficiency)
                            int itemId = db.GetItemIdByName(itemName);

                            // Insert into OrderDetails
                            db.InsertOrderDetails(orderId, itemId, quantity, price);
                        }
                    }
                }

                return orderId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }
        }

        private void GenerateReceipt(int orderId)
        {
            Database db = new Database();

            // Retrieve order details
            DataTable orderDetails = db.GetOrderByOrderId(orderId);

            // Generate receipt text
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("HF&S Flavors - Deliciously Crafted by Three");
            receipt.AppendLine("Order ID: " + orderId);
            receipt.AppendLine("Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            receipt.AppendLine("--------------------------------------------");
            decimal totalPrice = 0;

            foreach (DataRow row in orderDetails.Rows)
            {
                string itemName = row["ItemName"].ToString();
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal price = Convert.ToDecimal(row["Price"]);

                receipt.AppendLine($"{itemName} x{quantity} - ${price * quantity:F2}");
                totalPrice += price * quantity;
            }

            receipt.AppendLine("--------------------------------------------");
            receipt.AppendLine($"Total: ${totalPrice:F2}");
            receipt.AppendLine("Thank you for dining with us!");

            // Initialize the PrintDocument
            PrintDocument printDoc = new PrintDocument();

            // Set up the PrintPage event handler
            printDoc.PrintPage += (sender, e) =>
            {
                // Get the Graphics object for printing
                Graphics g = e.Graphics;

                // Set the font for printing
                Font font = new Font("Arial", 10);
                float yPosition = 10;

                // Loop through each line of receipt and print it
                foreach (string line in receipt.ToString().Split('\n'))
                {
                    g.DrawString(line, font, Brushes.Black, 10, yPosition);
                    yPosition += font.GetHeight(g);  // Move to the next line
                }
            };

            // Show the Print Dialog (optional)
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Print the document
                printDoc.Print();
            }
            else
            {
                MessageBox.Show("Printing was canceled.");
            }
        }
        // Method to clear the order panel after placing an order
        private void ClearOrderList()
        {
            // Remove all controls from the order panel
            orderPanel.Controls.Clear();

            // Reset total quantity and total price labels
            label2.Text = "Total Quantity: 0";
            label3.Text = "Total Price: $0.00";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (uid != 0)
            { 
                new CashierForm(uid).Show(); }
            else
            {
                
                new Login().Show();
            }
          
        }
    }
}
