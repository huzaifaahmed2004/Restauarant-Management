namespace RestaurantManagementApp
{
    partial class WalkInCustomerForm:Form
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            orderPanel = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            label4 = new Label();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Location = new Point(231, 47);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(657, 493);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // orderPanel
            // 
            orderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            orderPanel.AutoScroll = true;
            orderPanel.BackColor = Color.Black;
            orderPanel.FlowDirection = FlowDirection.TopDown;
            orderPanel.Location = new Point(-3, 47);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(228, 434);
            orderPanel.TabIndex = 3;
            orderPanel.WrapContents = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(-3, 11);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 5;
            label2.Text = "Total Quantity =0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 36);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 6;
            label3.Text = "Total Price =0";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(238, 44, 42);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(127, 11);
            button1.Name = "button1";
            button1.Size = new Size(95, 50);
            button1.TabIndex = 7;
            button1.Text = "Confirm Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 476);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 64);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(885, 41);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(238, 44, 42);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(801, 8);
            button2.Name = "button2";
            button2.Size = new Size(81, 30);
            button2.TabIndex = 7;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(188, 9);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 6;
            label4.Text = "Welcome";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 44, 42);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 0;
            label1.Text = "HF&S Flavors";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // WalkInCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(885, 540);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(orderPanel);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WalkInCustomerForm";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += WalkInCustomerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel orderPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Label label4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}