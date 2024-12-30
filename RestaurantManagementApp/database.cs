using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
namespace RestaurantManagementApp
{
    public class Database
    {
        // Connection string (replace with your own credentials)
        private string connectionString = "Server=127.0.0.1;Database=restaurantdb;User ID=root;Password=H1u2Z3a4I5.;";

        // Method to get the connection
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Method to open a connection to the database
        private MySqlConnection OpenConnection()
        {
            MySqlConnection conn = GetConnection();
            conn.Open();
            return conn;
        }

        // Method to fetch menu items from the database
        public DataTable GetMenuItems()
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = @"
            SELECT ItemID, ItemName, Price, Category, ImagePath 
            FROM Menu 
            WHERE IsActive = TRUE";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);
                return menuTable;
            }
        }
        public DataTable SearchUsersByName(string name)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT UserID, Username, Role, DateCreated FROM Users WHERE Username LIKE @Name AND Role IN ('Kitchen Staff', 'Cashier')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", $"%{name}%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable usersTable = new DataTable();
                adapter.Fill(usersTable);

                return usersTable;
            }
        }
        public DataTable GetFilteredOrders(DateTime startDate, DateTime endDate, string status, string orderId = null)
        {
            string query = @"
    SELECT 
        o.OrderID, 
        o.OrderTime, 
        o.OrderStatus, 
        p.PaymentAmount AS TotalAmount
    FROM Orders o
    INNER JOIN Payments p ON o.OrderID = p.OrderID
    WHERE o.OrderTime BETWEEN @startDate AND @endDate";

            // Add status filter if provided
            if (!string.IsNullOrEmpty(status))
            {
                query += " AND o.OrderStatus = @status";
            }

            // Add OrderID search filter if provided
            if (!string.IsNullOrEmpty(orderId))
            {
                query += " AND o.OrderID = @orderId";
            }

            query += " ORDER BY o.OrderTime DESC";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                if (!string.IsNullOrEmpty(status))
                {
                    command.Parameters.AddWithValue("@status", status);
                }

                if (!string.IsNullOrEmpty(orderId))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }



        public DataTable GetMenuItemNoPic()
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = @"
            SELECT ItemID AS ItemID, ItemName AS Name, Price, Category 
            FROM Menu 
            WHERE IsActive = TRUE";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable menuTable = new DataTable();
                adapter.Fill(menuTable);
                return menuTable;
            }
        }

        // Method to insert an order
        public int InsertOrder(string orderTime, string orderStatus)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "INSERT INTO Orders (OrderTime, OrderStatus) VALUES (@OrderTime, @OrderStatus); SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderTime", orderTime);
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Method to get pending orders
        public DataTable GetPendingOrders()
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT O.OrderID, O.OrderTime, " +
                               "(SELECT SUM(Quantity) FROM OrderDetails WHERE OrderID = O.OrderID) AS Quantity, " +
                               "(SELECT SUM(Price) FROM OrderDetails WHERE OrderID = O.OrderID) AS TotalPrice " +
                               "FROM Orders O " +
                               "JOIN Payments P ON O.OrderID = P.OrderID " +
                               "WHERE P.PaymentStatus = 'Pending'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable ordersTable = new DataTable();
                adapter.Fill(ordersTable);
                return ordersTable;
            }
        }
        public DataTable GetOrderDetailsByOrderIdWithImage(int orderId)
        {
            string query = @"
 SELECT 
od.OrderDetailID,
     od.ItemID,
     m.ItemName,
     m.ImagePath,
     od.Quantity
 FROM 
     OrderDetails od
 INNER JOIN 
     Menu m ON od.ItemID = m.ItemID
 WHERE 
     od.OrderID = @OrderID";

            using (var connection = GetConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@OrderID", orderId);
                connection.Open();

                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        // Method to get order details by OrderID
        public DataTable GetOrderDetailsByOrderId(int orderId)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT M.ItemName, OD.Quantity, OD.Price " +
                               "FROM OrderDetails OD " +
                               "JOIN Menu M ON OD.ItemID = M.ItemID " +
                               "WHERE OD.OrderID = @OrderID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable orderDetailsTable = new DataTable();
                adapter.Fill(orderDetailsTable);
                return orderDetailsTable;
            }
        }

        // Method to update order status
        public void UpdateOrderStatus(int orderId, string newStatus)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "UPDATE Orders SET OrderStatus = @NewStatus WHERE OrderID = @OrderID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.ExecuteNonQuery();
            }
        }

        // Method to update payment status
        public void UpdatePaymentStatus(int orderId, string paymentStatus)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "UPDATE Payments SET PaymentStatus = @PaymentStatus WHERE OrderID = @OrderID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.ExecuteNonQuery();
            }
        }

        // Method to check login credentials (Username, Password, and Role)
        public int CheckLoginCredentials(string username, string password, string role)
        {
            int UID = 0;
            try
            {
                using (MySqlConnection conn = OpenConnection())
                {
                    // Hash the input password
                    string hashedPassword = HashPassword(password);

                    // Query to check if the provided credentials (username, hashed password, role) match
                    string query = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword); // Use the hashed password
                    cmd.Parameters.AddWithValue("@Role", role);

                    // Execute the query and get the count
                     UID = Convert.ToInt32(cmd.ExecuteScalar());

                    // If the count is 1, that means credentials are correct
                    return UID ;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the login process
                Console.WriteLine($"Error during login: {ex.Message}");
                return 0;
            }
        }

        // Password hashing method
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        // Method to get ItemID by item name
        public int GetItemIdByName(string itemName)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT ItemID FROM Menu WHERE ItemName = @ItemName AND IsActive = TRUE";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemName", itemName);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        public void AddMenuItem(string itemName, decimal price, string category, string imagePath)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "INSERT INTO Menu (ItemName, Price, Category, ImagePath) VALUES (@ItemName, @Price, @Category, @ImagePath)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                cmd.ExecuteNonQuery();
            }
        }

        // Edit an existing menu item
        public void EditMenuItem(int itemId, string itemName, decimal price, string category, string imagePath)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "UPDATE Menu SET ItemName = @ItemName, Price = @Price, Category = @Category, ImagePath = @ImagePath WHERE ItemID = @ItemID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemID", itemId);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                cmd.ExecuteNonQuery();
            }
        }

        // Delete a menu item by ItemID
        public void DeleteMenuItem(int itemId)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "UPDATE Menu SET IsActive = FALSE WHERE ItemID = @ItemID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemID", itemId);

                cmd.ExecuteNonQuery();
            }
        }


        // Get all menu items


        // Get a specific menu item by ItemID
        public DataRow GetMenuItemByIdNoPic(int itemId)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT ItemID as ItemID, ItemName as Name , Price, Category FROM Menu WHERE ItemID = @ItemID AND IsActive = TRUE";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemID", itemId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        public DataRow GetMenuItemById(int itemId)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT ItemID as ItemID, ItemName as Name , Price, Category,ImagePath FROM Menu WHERE ItemID = @ItemID AND IsActive = TRUE";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemID", itemId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        // Method to insert order details
        public void InsertOrderDetails(int orderId, int itemId, int quantity, decimal price)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "INSERT INTO OrderDetails (OrderID, ItemID, Quantity, Price) VALUES (@OrderID, @ItemID, @Quantity, @Price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.Parameters.AddWithValue("@ItemID", itemId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.ExecuteNonQuery();
            }
        }

        // Method to retrieve an order by OrderID
        public DataTable GetOrderByOrderId(int orderId)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = @"
                SELECT 
                    o.OrderID, o.OrderTime, o.OrderStatus, 
                    od.ItemID, m.ItemName, od.Quantity, od.Price 
                FROM 
                    Orders o
                INNER JOIN 
                    OrderDetails od ON o.OrderID = od.OrderID
                INNER JOIN 
                    Menu m ON od.ItemID = m.ItemID
                WHERE 
                    o.OrderID = @OrderID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable orderDetails = new DataTable();
                adapter.Fill(orderDetails);
                return orderDetails;
            }
        }
        public DataTable GetMostCrowdedDayData()
        {
            string query = @"
    SELECT 
        DAYOFWEEK(OrderTime) AS DayOfWeek, 
        COUNT(*) AS OrderCount
    FROM 
        Orders
    WHERE 
        OrderStatus = 'Completed'
    GROUP BY 
        DAYOFWEEK(OrderTime)
    ORDER BY 
        DAYOFWEEK(OrderTime) Limit 
5";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Add a new column for Day Name
                dataTable.Columns.Add("DayName", typeof(string));

                // Convert DayOfWeek numeric values to actual day names (Sunday, Monday, etc.)
                foreach (DataRow row in dataTable.Rows)
                {
                    int dayOfWeek = (int)row["DayOfWeek"];
                    string dayName = GetDayName(dayOfWeek);
                    row["DayName"] = dayName; // Add the day name to the new column
                }

                return dataTable;
            }
        }
        public DataTable GetMostPopularFoodData()
        {
            string query = @"SELECT 
    m.ItemName, 
    COUNT(od.ItemID) AS OrderCount
FROM 
    OrderDetails od
INNER JOIN 
    Menu m ON od.ItemID = m.ItemID
INNER JOIN 
    Orders o ON od.OrderID = o.OrderID
WHERE 
    o.OrderStatus = 'Completed'
GROUP BY 
    m.ItemName
ORDER BY 
    OrderCount DESC
LIMIT 5;
";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public void SetTotalOrdersLabel(Label totalOrdersLabel)
        {
            string query = "SELECT COUNT(*) AS TotalOrders FROM Orders WHERE OrderStatus = 'Completed'";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                int totalOrders = Convert.ToInt32(command.ExecuteScalar());
                totalOrdersLabel.Text = $"{totalOrders}";
            }
        }
        public void SetTotalCancelledOrdersLabel(Label totalCancelledOrdersLabel)
        {
            string query = "SELECT COUNT(*) AS TotalCancelled FROM Orders WHERE OrderStatus = 'Canceled' or OrderStatus = 'Cancelled'";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                int totalCancelled = Convert.ToInt32(command.ExecuteScalar());
                totalCancelledOrdersLabel.Text = $"{totalCancelled}";
            }
        }
        public void SetTotalEarningsLabel(Label totalEarningsLabel)
        {
            string query = @"
    SELECT SUM(p.PaymentAmount) AS TotalEarnings
    FROM Payments p
    INNER JOIN Orders o ON p.OrderID = o.OrderID
    WHERE o.OrderStatus = 'Completed'";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                int totalEarnings = Convert.ToInt32(command.ExecuteScalar());
                totalEarningsLabel.Text = $"{totalEarnings}";
            }
        }
        public void SetTotalStaffLabel(Label totalStaffLabel)
        {
            string query = "SELECT COUNT(*) AS TotalStaff FROM Users WHERE Role != 'Admin'";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                int totalStaff = Convert.ToInt32(command.ExecuteScalar());
                totalStaffLabel.Text = $"{totalStaff}";
            }
        }

        public DataTable GetMostCrowdedTimeData()
        {
            string query = @"
    SELECT 
        HOUR(OrderTime) AS HourOfDay, 
        COUNT(*) AS OrderCount
    FROM 
        Orders
    WHERE 
        OrderStatus = 'Completed'
    GROUP BY 
        HOUR(OrderTime)
    ORDER BY 
        HOUR(OrderTime)";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private string GetDayName(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 1: return "Sunday";
                case 2: return "Monday";
                case 3: return "Tuesday";
                case 4: return "Wednesday";
                case 5: return "Thursday";
                case 6: return "Friday";
                case 7: return "Saturday";
                default: return "";
            }
        }




        public DataTable GetPendingOrdersByOrderStatus(string orderStatus)
{
    string query = @"
    SELECT 
        o.OrderID,
        o.OrderTime,
        o.OrderStatus
    FROM 
        Orders o
    JOIN 
        Payments p ON o.OrderID = p.OrderID
    WHERE 
        o.OrderStatus = @OrderStatus
        AND p.PaymentStatus = 'Completed'"; // Ensure payment is confirmed

    using (var connection = GetConnection())
    using (var command = new MySqlCommand(query, connection))
    {
        command.Parameters.AddWithValue("@OrderStatus", orderStatus);

        connection.Open();
        using (var adapter = new MySqlDataAdapter(command))
        {
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}


        // Get pending orders by specific Order ID
        public DataTable GetPendingOrdersByOrderId(String orderId)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                // Modified query to specifically fetch pending orders by OrderID
                string query = @"
            SELECT O.OrderID, O.OrderTime, 
                (SELECT SUM(Quantity) FROM OrderDetails WHERE OrderID = O.OrderID) AS Quantity, 
                (SELECT SUM(Price * Quantity) FROM OrderDetails WHERE OrderID = O.OrderID) AS TotalPrice
            FROM Orders O
            JOIN Payments P ON O.OrderID = P.OrderID
            WHERE P.PaymentStatus = 'Pending' AND O.OrderID =@OrderID"; // Filter by specific OrderID

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId); // Use the orderId parameter

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable orderTable = new DataTable();
                adapter.Fill(orderTable);
                return orderTable;
            }
        }
        public void InsertPaymentToDatabase(int orderId, double paymentAmount)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Payments (OrderID, PaymentAmount, PaymentStatus) VALUES (@OrderID, @PaymentAmount, @PaymentStatus)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                    cmd.Parameters.AddWithValue("@PaymentStatus", "Pending");

                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Add User
        public void AddUser(string username, string password, string role)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "INSERT INTO Users (Username, Password, Role, DateCreated) VALUES (@Username, @Password, @Role, NOW())";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.ExecuteNonQuery();
            }
        }

        // Update User
        public void UpdateUser(int userId, string username, string password, string role)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role WHERE UserID = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateUserWithoutPass(int userId, string username, string role)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "UPDATE Users SET Username = @Username, Role = @Role WHERE UserID = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.ExecuteNonQuery();
            }
        }
        // Delete User
        public void DeleteUser(int userId)
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                cmd.ExecuteNonQuery();
            }
        }

        // Get All Users (Kitchen Staff and Cashiers)
        public DataTable GetUsers()
        {
            using (MySqlConnection conn = OpenConnection())
            {
                string query = "SELECT UserID, Username, Role, DateCreated FROM Users WHERE Role IN ('Kitchen Staff', 'Cashier')";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable usersTable = new DataTable();
                adapter.Fill(usersTable);

                return usersTable;
            }
        }




    }
}
