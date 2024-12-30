namespace RestaurantManagementApp
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            imageList1 = new ImageList(components);
            Dashboard = new TabPage();
            label25 = new Label();
            pieChart2 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panel7 = new Panel();
            label24 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label23 = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panel6 = new Panel();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            Menu = new TabPage();
            textBox5 = new TextBox();
            label16 = new Label();
            panel8 = new Panel();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox5 = new PictureBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            User = new TabPage();
            textBox6 = new TextBox();
            label17 = new Label();
            panel9 = new Panel();
            button16 = new Button();
            textBox7 = new TextBox();
            label18 = new Label();
            comboBox1 = new ComboBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            label22 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            dataGridView2 = new DataGridView();
            Sale = new TabPage();
            label31 = new Label();
            dataGridView3 = new DataGridView();
            comboBoxStatus = new ComboBox();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            textBoxOrderID = new TextBox();
            label27 = new Label();
            label26 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            Dashboard.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            Menu.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            User.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Sale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 41);
            panel2.TabIndex = 8;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(234, 0, 42);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(920, 9);
            button4.Name = "button4";
            button4.Size = new Size(75, 29);
            button4.TabIndex = 11;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(234, 0, 42);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(1539, 9);
            button3.Name = "button3";
            button3.Size = new Size(66, 29);
            button3.TabIndex = 10;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(234, 0, 42);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(2130, 7);
            button5.Name = "button5";
            button5.Size = new Size(66, 29);
            button5.TabIndex = 9;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(234, 0, 42);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(2023, 7);
            button1.Name = "button1";
            button1.Size = new Size(95, 29);
            button1.TabIndex = 8;
            button1.Text = "Go To Menu";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(238, 44, 42);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(2815, 11);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(234, 0, 42);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 0;
            label1.Text = "HF&S Flavors";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(28, 24, 22);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(1, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 438);
            panel1.TabIndex = 9;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(234, 0, 42);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(11, 158);
            button9.Name = "button9";
            button9.Size = new Size(188, 41);
            button9.TabIndex = 3;
            button9.Text = "Sales/Reports";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(234, 0, 42);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(11, 111);
            button8.Name = "button8";
            button8.Size = new Size(188, 41);
            button8.TabIndex = 2;
            button8.Text = "User Management";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(234, 0, 42);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(11, 64);
            button7.Name = "button7";
            button7.Size = new Size(188, 41);
            button7.TabIndex = 1;
            button7.Text = "Menu Management";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(234, 0, 42);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(11, 17);
            button6.Name = "button6";
            button6.Size = new Size(188, 41);
            button6.TabIndex = 0;
            button6.Text = "Dashboard";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.Black;
            Dashboard.Controls.Add(label25);
            Dashboard.Controls.Add(pieChart2);
            Dashboard.Controls.Add(panel7);
            Dashboard.Controls.Add(label23);
            Dashboard.Controls.Add(pieChart1);
            Dashboard.Controls.Add(panel6);
            Dashboard.Controls.Add(panel5);
            Dashboard.Controls.Add(panel4);
            Dashboard.Controls.Add(panel3);
            Dashboard.Controls.Add(label3);
            Dashboard.Location = new Point(4, 24);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(3);
            Dashboard.Size = new Size(783, 410);
            Dashboard.TabIndex = 2;
            Dashboard.Text = "Dashboard";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(28, 24, 22);
            label25.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label25.ForeColor = Color.White;
            label25.Location = new Point(530, 176);
            label25.Name = "label25";
            label25.Size = new Size(139, 20);
            label25.TabIndex = 10;
            label25.Text = "Most Popular Food";
            // 
            // pieChart2
            // 
            pieChart2.BackColor = Color.FromArgb(28, 24, 22);
            pieChart2.ForeColor = SystemColors.ButtonFace;
            pieChart2.InitialRotation = 0D;
            pieChart2.IsClockwise = true;
            pieChart2.Location = new Point(512, 168);
            pieChart2.MaxAngle = 360D;
            pieChart2.MaxValue = null;
            pieChart2.MinValue = 0D;
            pieChart2.Name = "pieChart2";
            pieChart2.Size = new Size(215, 190);
            pieChart2.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(28, 24, 22);
            panel7.Controls.Add(label24);
            panel7.Controls.Add(cartesianChart1);
            panel7.Location = new Point(306, 168);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 221);
            panel7.TabIndex = 8;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label24.AutoSize = true;
            label24.BackColor = Color.FromArgb(28, 24, 22);
            label24.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label24.ForeColor = Color.White;
            label24.Location = new Point(110, 8);
            label24.Name = "label24";
            label24.Size = new Size(90, 20);
            label24.TabIndex = 9;
            label24.Text = "Order/Hour";
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.FromArgb(28, 24, 22);
            cartesianChart1.ForeColor = SystemColors.Control;
            cartesianChart1.Location = new Point(3, 31);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(198, 187);
            cartesianChart1.TabIndex = 7;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.BackColor = Color.FromArgb(28, 24, 22);
            label23.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label23.ForeColor = Color.White;
            label23.Location = new Point(70, 168);
            label23.Name = "label23";
            label23.Size = new Size(145, 20);
            label23.TabIndex = 6;
            label23.Text = "Most Crowded Days";
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.FromArgb(28, 24, 22);
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(35, 159);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(215, 190);
            pieChart1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.BackColor = Color.FromArgb(28, 24, 22);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(222, 28);
            panel6.Name = "panel6";
            panel6.Size = new Size(180, 113);
            panel6.TabIndex = 5;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(84, 40);
            label9.Name = "label9";
            label9.Size = new Size(51, 40);
            label9.TabIndex = 2;
            label9.Text = "00";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.Cancel_Order;
            pictureBox4.Location = new Point(10, 40);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(16, 12);
            label10.Name = "label10";
            label10.Size = new Size(141, 20);
            label10.TabIndex = 0;
            label10.Text = "Total Cancel Orders";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.AutoSize = true;
            panel5.BackColor = Color.FromArgb(28, 24, 22);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(592, 28);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 113);
            panel5.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(107, 40);
            label7.Name = "label7";
            label7.Size = new Size(51, 40);
            label7.TabIndex = 2;
            label7.Text = "00";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.Staff;
            pictureBox3.Location = new Point(33, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(33, 12);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 0;
            label8.Text = "Total Staff";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(28, 24, 22);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(405, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(203, 113);
            panel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(84, 40);
            label5.Name = "label5";
            label5.Size = new Size(51, 40);
            label5.TabIndex = 2;
            label5.Text = "00";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Earning;
            pictureBox2.Location = new Point(10, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 12);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 0;
            label6.Text = "Total Earnings";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.FromArgb(28, 24, 22);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(35, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 113);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(84, 40);
            label4.Name = "label4";
            label4.Size = new Size(51, 40);
            label4.TabIndex = 2;
            label4.Text = "00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TotalOrders;
            pictureBox1.Location = new Point(10, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 12);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 0;
            label2.Text = "Total Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 113);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Dashboard);
            tabControl1.Controls.Add(Menu);
            tabControl1.Controls.Add(User);
            tabControl1.Controls.Add(Sale);
            tabControl1.Location = new Point(218, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(791, 438);
            tabControl1.TabIndex = 10;
            // 
            // Menu
            // 
            Menu.BackColor = Color.Black;
            Menu.Controls.Add(textBox5);
            Menu.Controls.Add(label16);
            Menu.Controls.Add(panel8);
            Menu.Controls.Add(dataGridView1);
            Menu.Controls.Add(label11);
            Menu.Location = new Point(4, 24);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(3);
            Menu.Size = new Size(783, 410);
            Menu.TabIndex = 3;
            Menu.Text = "Menu Management";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.BackColor = Color.FromArgb(28, 24, 22);
            textBox5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(508, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyUp += textBox5_KeyUp;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(448, 8);
            label16.Name = "label16";
            label16.Size = new Size(54, 20);
            label16.TabIndex = 8;
            label16.Text = "Name:";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel8.Controls.Add(button12);
            panel8.Controls.Add(button11);
            panel8.Controls.Add(button10);
            panel8.Controls.Add(textBox4);
            panel8.Controls.Add(textBox3);
            panel8.Controls.Add(textBox2);
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label12);
            panel8.Location = new Point(0, 28);
            panel8.Name = "panel8";
            panel8.Size = new Size(398, 382);
            panel8.TabIndex = 2;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(234, 0, 42);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.Location = new Point(277, 316);
            button12.Name = "button12";
            button12.Size = new Size(75, 29);
            button12.TabIndex = 12;
            button12.Text = "Delete";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(234, 0, 42);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.Location = new Point(147, 316);
            button11.Name = "button11";
            button11.Size = new Size(75, 29);
            button11.TabIndex = 11;
            button11.Text = "Update";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(234, 0, 42);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Location = new Point(19, 316);
            button10.Name = "button10";
            button10.Size = new Size(75, 29);
            button10.TabIndex = 10;
            button10.Text = "Save";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(28, 24, 22);
            textBox4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(90, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(28, 24, 22);
            textBox3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(90, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(28, 24, 22);
            textBox2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(90, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(28, 24, 22);
            textBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(90, 166);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(127, 15);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(122, 132);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(37, 268);
            label15.Name = "label15";
            label15.Size = new Size(47, 20);
            label15.TabIndex = 4;
            label15.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(8, 235);
            label14.Name = "label14";
            label14.Size = new Size(76, 20);
            label14.TabIndex = 3;
            label14.Text = "Category:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(30, 202);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 2;
            label13.Text = "Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(22, 169);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 1;
            label12.Text = "Item ID:";
            label12.Click += label12_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(234, 0, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(234, 0, 42);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(404, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(234, 0, 42);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(383, 382);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(337, 0);
            label11.Name = "label11";
            label11.Size = new Size(187, 25);
            label11.TabIndex = 0;
            label11.Text = "Menu Management";
            // 
            // User
            // 
            User.BackColor = Color.Black;
            User.Controls.Add(textBox6);
            User.Controls.Add(label17);
            User.Controls.Add(panel9);
            User.Controls.Add(dataGridView2);
            User.Location = new Point(4, 24);
            User.Name = "User";
            User.Padding = new Padding(3);
            User.Size = new Size(783, 410);
            User.TabIndex = 4;
            User.Text = "User Management";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.BackColor = Color.FromArgb(28, 24, 22);
            textBox6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(506, 1);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(185, 27);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label17.ForeColor = Color.White;
            label17.Location = new Point(418, 5);
            label17.Name = "label17";
            label17.Size = new Size(82, 20);
            label17.TabIndex = 13;
            label17.Text = "Username:";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel9.Controls.Add(button16);
            panel9.Controls.Add(textBox7);
            panel9.Controls.Add(label18);
            panel9.Controls.Add(comboBox1);
            panel9.Controls.Add(button13);
            panel9.Controls.Add(button14);
            panel9.Controls.Add(button15);
            panel9.Controls.Add(label22);
            panel9.Controls.Add(textBox9);
            panel9.Controls.Add(textBox10);
            panel9.Controls.Add(label19);
            panel9.Controls.Add(label20);
            panel9.Controls.Add(label21);
            panel9.Location = new Point(-2, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(398, 407);
            panel9.TabIndex = 12;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(234, 0, 42);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button16.ForeColor = Color.White;
            button16.Location = new Point(254, 197);
            button16.Name = "button16";
            button16.Size = new Size(141, 29);
            button16.TabIndex = 16;
            button16.Text = "Change Password";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(28, 24, 22);
            textBox7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(119, 199);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(129, 27);
            textBox7.TabIndex = 15;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label18.ForeColor = Color.White;
            label18.Location = new Point(31, 202);
            label18.Name = "label18";
            label18.Size = new Size(77, 20);
            label18.TabIndex = 14;
            label18.Text = "Password:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(28, 24, 22);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kitchen Staff", "Cashier" });
            comboBox1.Location = new Point(119, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 23);
            comboBox1.TabIndex = 13;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(234, 0, 42);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button13.ForeColor = Color.White;
            button13.Location = new Point(277, 316);
            button13.Name = "button13";
            button13.Size = new Size(75, 29);
            button13.TabIndex = 12;
            button13.Text = "Delete";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(234, 0, 42);
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button14.ForeColor = Color.White;
            button14.Location = new Point(147, 316);
            button14.Name = "button14";
            button14.Size = new Size(75, 29);
            button14.TabIndex = 11;
            button14.Text = "Update";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(234, 0, 42);
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button15.ForeColor = Color.White;
            button15.Location = new Point(19, 316);
            button15.Name = "button15";
            button15.Size = new Size(75, 29);
            button15.TabIndex = 10;
            button15.Text = "Save";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(119, 12);
            label22.Name = "label22";
            label22.Size = new Size(175, 25);
            label22.TabIndex = 10;
            label22.Text = "User Management";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(28, 24, 22);
            textBox9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox9.ForeColor = Color.White;
            textBox9.Location = new Point(119, 155);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(185, 27);
            textBox9.TabIndex = 7;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(28, 24, 22);
            textBox10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox10.ForeColor = Color.White;
            textBox10.Location = new Point(119, 112);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(185, 27);
            textBox10.TabIndex = 6;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Location = new Point(70, 240);
            label19.Name = "label19";
            label19.Size = new Size(43, 20);
            label19.TabIndex = 3;
            label19.Text = "Role:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label20.ForeColor = Color.White;
            label20.Location = new Point(31, 158);
            label20.Name = "label20";
            label20.Size = new Size(82, 20);
            label20.TabIndex = 2;
            label20.Text = "Username:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(50, 115);
            label21.Name = "label21";
            label21.Size = new Size(63, 20);
            label21.TabIndex = 1;
            label21.Text = "User ID:";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(234, 0, 42);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.GridColor = SystemColors.InactiveBorder;
            dataGridView2.Location = new Point(402, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(383, 382);
            dataGridView2.TabIndex = 11;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Sale
            // 
            Sale.BackColor = Color.Black;
            Sale.Controls.Add(label31);
            Sale.Controls.Add(dataGridView3);
            Sale.Controls.Add(comboBoxStatus);
            Sale.Controls.Add(label30);
            Sale.Controls.Add(label29);
            Sale.Controls.Add(label28);
            Sale.Controls.Add(dateTimePickerEnd);
            Sale.Controls.Add(dateTimePickerStart);
            Sale.Controls.Add(textBoxOrderID);
            Sale.Controls.Add(label27);
            Sale.Controls.Add(label26);
            Sale.Location = new Point(4, 24);
            Sale.Name = "Sale";
            Sale.Padding = new Padding(3);
            Sale.Size = new Size(783, 410);
            Sale.TabIndex = 5;
            Sale.Text = "Sales";
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label31.ForeColor = Color.White;
            label31.Location = new Point(463, 49);
            label31.Name = "label31";
            label31.Size = new Size(100, 20);
            label31.TabIndex = 24;
            label31.Text = "Total Price : 0";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(234, 0, 42);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(28, 24, 22);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView3.GridColor = SystemColors.InactiveBorder;
            dataGridView3.Location = new Point(0, 134);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(783, 276);
            dataGridView3.TabIndex = 23;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(644, 102);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 22;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label30.ForeColor = Color.White;
            label30.Location = new Point(589, 103);
            label30.Name = "label30";
            label30.Size = new Size(49, 20);
            label30.TabIndex = 21;
            label30.Text = "Filter:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label29.ForeColor = Color.White;
            label29.Location = new Point(7, 104);
            label29.Name = "label29";
            label29.Size = new Size(81, 20);
            label29.TabIndex = 20;
            label29.Text = "Start Date:";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label28.ForeColor = Color.White;
            label28.Location = new Point(326, 103);
            label28.Name = "label28";
            label28.Size = new Size(75, 20);
            label28.TabIndex = 19;
            label28.Text = "End Date:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.Top;
            dateTimePickerEnd.Location = new Point(407, 101);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 18;
            dateTimePickerEnd.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(94, 100);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 17;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // textBoxOrderID
            // 
            textBoxOrderID.Anchor = AnchorStyles.Top;
            textBoxOrderID.BackColor = Color.FromArgb(28, 24, 22);
            textBoxOrderID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxOrderID.ForeColor = Color.White;
            textBoxOrderID.Location = new Point(94, 46);
            textBoxOrderID.Name = "textBoxOrderID";
            textBoxOrderID.Size = new Size(203, 27);
            textBoxOrderID.TabIndex = 16;
            textBoxOrderID.TextChanged += textBoxOrderID_TextChanged;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top;
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label27.ForeColor = Color.White;
            label27.Location = new Point(20, 49);
            label27.Name = "label27";
            label27.Size = new Size(68, 20);
            label27.TabIndex = 15;
            label27.Text = "OrderID:";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.White;
            label26.Location = new Point(326, 9);
            label26.Name = "label26";
            label26.Size = new Size(175, 25);
            label26.TabIndex = 11;
            label26.Text = "User Management";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1008, 478);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminForm";
            Text = "AdminForm";
            WindowState = FormWindowState.Maximized;
            Load += AdminForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            Dashboard.ResumeLayout(false);
            Dashboard.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            User.ResumeLayout(false);
            User.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Sale.ResumeLayout(false);
            Sale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button4;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private ImageList imageList1;
        private TabPage Dashboard;
        private Panel panel3;
        private Label label3;
        private TabControl tabControl1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label8;
        private Panel panel6;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label10;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TabPage Menu;
        private DataGridView dataGridView1;
        private Label label11;
        private Panel panel8;
        private PictureBox pictureBox5;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button button12;
        private Button button11;
        private Button button10;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label16;
        private TabPage User;
        private TextBox textBox6;
        private Label label17;
        private Panel panel9;
        private Button button13;
        private Button button14;
        private Button button15;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label19;
        private Label label20;
        private Label label21;
        private DataGridView dataGridView2;
        private Label label22;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private Label label18;
        private Button button16;
        private TabPage Sale;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label label23;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Panel panel7;
        private Label label24;
        private Label label25;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart2;
        private Label label26;
        private ComboBox comboBoxStatus;
        private Label label30;
        private Label label29;
        private Label label28;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private TextBox textBoxOrderID;
        private Label label27;
        private DataGridView dataGridView3;
        private Label label31;
    }
}