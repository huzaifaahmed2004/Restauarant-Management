namespace RestaurantManagementApp
{
    public partial class LoadingForm : Form
    {
        private int progressValue = 0;

        public LoadingForm()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // No need for handling if not required
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Handle if needed
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the progress value
            progressValue += 1;

            // Update ProgressBar value
            progressBar1.Value = progressValue;

            // Update Label text to show the percentage
            label1.Text = $"Loading...";

            // If progress reaches 100%, stop the timer and transition to the next form
            if (progressValue >= 100)
            {
                timer1.Stop();
                this.Hide();

                // Create and show the WalkInCustomerForm
                WalkInCustomerForm walkInForm = new WalkInCustomerForm(0);
                walkInForm.Show();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the ProgressBar style to Continuous
            progressBar1.Style = ProgressBarStyle.Continuous;

            // Set the max and min values of the ProgressBar
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            // Set the Timer interval to 40 ms for a smooth 4-second loading
            timer1.Interval = 1;
            timer1.Start();  // Start the timer to update progress
        }
    }
}
