using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementApp
{
    internal class InputDialog
    {
        public static string ShowDialog(string prompt, string title)
        {
            Form promptForm = new Form()
            {
                Width = 350,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor=Color.Black
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = prompt, Width = 300,ForeColor=Color.White };
            TextBox inputBox = new TextBox() { Left = 20, BackColor = Color.Black, ForeColor = Color.White, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "OK", ForeColor = Color.White,BackColor=Color.Red, Left = 120, Width = 100, Top = 90, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(inputBox);
            promptForm.Controls.Add(confirmation);

            promptForm.AcceptButton = confirmation;

            return promptForm.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
        }
    }
}
