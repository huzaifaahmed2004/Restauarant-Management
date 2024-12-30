namespace RestaurantManagementApp
{
    partial class KitchenStaffForm
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
            panel2 = new Panel();
            button3 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            flowLayoutPanelOrders = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 41);
            panel2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(234, 0, 42);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(723, 9);
            button3.Name = "button3";
            button3.Size = new Size(74, 29);
            button3.TabIndex = 10;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(234, 0, 42);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(1322, 7);
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
            button1.Location = new Point(1215, 7);
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
            button2.Location = new Point(2007, 11);
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
            // flowLayoutPanelOrders
            // 
            flowLayoutPanelOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelOrders.AutoScroll = true;
            flowLayoutPanelOrders.BackColor = Color.Black;
            flowLayoutPanelOrders.Location = new Point(0, 42);
            flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            flowLayoutPanelOrders.Size = new Size(800, 413);
            flowLayoutPanelOrders.TabIndex = 8;
            // 
            // KitchenStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelOrders);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KitchenStaffForm";
            Text = "KitchenStaffForm";
            WindowState = FormWindowState.Maximized;
            Load += KitchenStaffForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button5;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanelOrders;
    }
}