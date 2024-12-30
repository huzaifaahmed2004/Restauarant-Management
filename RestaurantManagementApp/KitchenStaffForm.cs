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
    public partial class KitchenStaffForm : Form
    {
        Database db;
        public KitchenStaffForm()
        {
            InitializeComponent();
            db = new Database();
        }
        private void LoadPendingOrders()
        {
            // Fetch pending orders from the database
            DataTable pendingOrders = db.GetPendingOrdersByOrderStatus("Pending");

            flowLayoutPanelOrders.Controls.Clear();

            // Loop through each order
            foreach (DataRow orderRow in pendingOrders.Rows)
            {
                int orderId = Convert.ToInt32(orderRow["OrderID"]);
                string orderTime = orderRow["OrderTime"].ToString();

                // Get items for this order
                DataTable orderDetails = db.GetOrderDetailsByOrderIdWithImage(orderId);

                // Create an order panel
                Panel orderPanel = CreateOrderPanel(orderId, orderTime, orderDetails);
                flowLayoutPanelOrders.Controls.Add(orderPanel);
            }
        }

        // Dictionary to store checkboxes specific to each order
        private Dictionary<int, List<CheckBox>> orderCheckboxes = new Dictionary<int, List<CheckBox>>();

        private Panel CreateOrderPanel(int orderId, string orderTime, DataTable orderDetails)
        {
            // Create the main panel for the order
            Panel panel = new Panel
            {
                BackColor = ColorTranslator.FromHtml("#1c1816"),
                Size = new Size(flowLayoutPanelOrders.Width - 40, 100), // Default size
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Order title label
            Label lblOrderId = new Label
            {
                Text = $"Order ID: {orderId} | Time: {orderTime}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#ffffff"),
                Dock = DockStyle.Top,
                Padding = new Padding(5),
                AutoSize = false, // Disable AutoSize to control height explicitly
                Height = 30 // Set height to accommodate the text
            };
            panel.Controls.Add(lblOrderId);

            string filePath = @"C:\Users\huzai\source\repos\RestaurantManagementApp\RestaurantManagementApp\";

            // Create a list to store checkboxes for this specific order
            List<CheckBox> checkboxesForThisOrder = new List<CheckBox>();

            // Add each item dynamically
            int yOffset = lblOrderId.Bottom + 20;
            foreach (DataRow itemRow in orderDetails.Rows)
            {
                // Create item details
                string itemName = itemRow["ItemName"].ToString();
                int quantity = Convert.ToInt32(itemRow["Quantity"]);
                string imagePath = Path.Combine(filePath, itemRow["ImagePath"].ToString());

                // Item Panel for each order item
                Panel itemPanel = new Panel
                {
                    Size = new Size(panel.Width - 20, 80), // Horizontal size
                    Location = new Point(10, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = ColorTranslator.FromHtml("#1c1816")
                };

                // Checkbox for selecting the item
                CheckBox chkSelect = new CheckBox
                {
                    AutoSize = true,
                    Location = new Point(10, 10) // Placed at the top-left corner of the item panel
                };

                // Add checkbox to the list for this specific order
                checkboxesForThisOrder.Add(chkSelect);

                // Item Image
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(60, 60),
                    Location = new Point(35, 10),
                    Image = Image.FromFile(imagePath),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Item Name
                Label lblItemName = new Label
                {
                    Text = $"{itemName} (x{quantity})",
                    Font = new Font("Arial", 10),
                    Location = new Point(100, 25),
                    AutoSize = true,
                    ForeColor = Color.White
                };

                // Add controls to item panel
                itemPanel.Controls.Add(chkSelect);
                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(lblItemName);

                // Add the item panel to the main panel
                panel.Controls.Add(itemPanel);

                // Adjust Y-offset for the next item
                yOffset += itemPanel.Height + 10;
            }

            // Store the list of checkboxes for this order
            orderCheckboxes[orderId] = checkboxesForThisOrder;

            // Adjust the panel size based on the number of items
            panel.Size = new Size(panel.Width, yOffset + 50);

            // Add action button to mark order as complete
            Button btnMarkComplete = new Button
            {
                Text = "Mark as Complete",
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#ea002a"),
                ForeColor = Color.White,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btnMarkComplete.Click += (s, e) => MarkOrderComplete(orderId);
            panel.Controls.Add(btnMarkComplete);

            return panel;
        }

        private void MarkOrderComplete(int orderId)
        {
            bool allChecked = true;

            // Check if all checkboxes for the specific order are checked
            if (orderCheckboxes.ContainsKey(orderId))
            {
                foreach (var checkbox in orderCheckboxes[orderId])
                {
                    if (!checkbox.Checked)
                    {
                        allChecked = false;
                        break;
                    }
                }
            }

            // If all items are selected, update the order status
            if (allChecked)
            {
                db.UpdateOrderStatus(orderId, "Completed");
                MessageBox.Show($"Order {orderId} marked as completed.");
                LoadPendingOrders(); // Reload orders
            }
            else
            {
                MessageBox.Show("Please check all items before marking the order as complete.");
            }
        }


        private void KitchenStaffForm_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
