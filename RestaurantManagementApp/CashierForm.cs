using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantManagementApp
{
    public partial class CashierForm : Form
    {
        private Database db;
        int UID;

        public CashierForm(int UserID)
        {
            InitializeComponent();
            db = new Database();
            UID = UserID;
        }
        private void AdjustDataGridViewColumns(DataGridView dg)
        {
            // Set AutoSizeMode for each column
            foreach (DataGridViewColumn column in dg.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // This will make the columns fill the available space
            }
        }

        // Method to load pending orders from the database
        private void LoadPendingOrders()
        {
            try
            {
                DataTable pendingOrders = db.GetPendingOrders(); // Get orders from database
                dataGridView1.DataSource = pendingOrders; // Bind to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pending orders: {ex.Message}");
            }
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();
            AdjustDataGridViewColumns(dataGridView1);

        }

        // Handle search functionality on key press in the search box
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string orderId = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(orderId))
            {
                LoadPendingOrders();
            }
            else
            {
                try
                {
                    DataTable filteredOrders = db.GetPendingOrdersByOrderId(orderId);
                    dataGridView1.DataSource = filteredOrders;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering orders: {ex.Message}");
                }
            }
        }

        // Handle click on a pending order in the DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Get the OrderID from the selected row
                    int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                    // Get order details by OrderID
                    DataTable orderDetails = db.GetOrderDetailsByOrderId(orderId);

                    // Set the data for order details in dataGridView2
                    dataGridView2.DataSource = orderDetails;
                    AdjustDataGridViewColumns(dataGridView2);

                    // Calculate the total price for the order
                    decimal totalPrice = orderDetails.AsEnumerable()
                        .Sum(row => row.Field<decimal>("Price"));

                    // Update total price label
                    label4.Text = $"Total: ${totalPrice:F2}";

                    // Update the OrderID label
                    label3.Text = $"Order ID: {orderId}";
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the process
                    MessageBox.Show($"Error loading order details: {ex.Message}");
                }
            }
        }

        // Handle the "Confirm Order" button click
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(label3.Text.Replace("Order ID: ", ""));

                // Update the payment status in the database
                db.UpdatePaymentStatus(orderId, "Completed");

                // Clear data in dataGridView2 (order details)
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();

                // Reset labels for Order ID and Total Price
                label3.Text = "Order ID: N/A";
                label4.Text = "Total: $0.00";

                // Show a confirmation message
                MessageBox.Show("Order confirmed and payment marked as completed.");

                // Reload the pending orders
                LoadPendingOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error confirming order: {ex.Message}");
            }
        }

        // Handle the "Cancel Order" button click
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(label3.Text.Replace("Order ID: ", ""));

                // Update the order and payment status to "Canceled" in the database
                db.UpdateOrderStatus(orderId, "Cancelled");
                db.UpdatePaymentStatus(orderId, "Cancelled");

                // Clear data in dataGridView2 (order details)
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();

                // Reset labels for Order ID and Total Price
                label3.Text = "Order ID: ";
                label4.Text = "Total: $0.00";

                // Show a confirmation message
                MessageBox.Show("Order and payment have been canceled.");

                // Reload the pending orders
                LoadPendingOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error canceling order: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WalkInCustomerForm(UID).Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
