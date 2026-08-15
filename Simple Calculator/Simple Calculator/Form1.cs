using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(num1TextBox.Text) || string.IsNullOrEmpty(num2TextBox.Text) ) 
            {
                MessageBox.Show("All feilds are required");
            }
            else
            {
                int num1 = int.Parse(num1TextBox.Text);
                int num2 = int.Parse(num2TextBox.Text);

                int result = num1 + num2;

                resultLabel.Text = $"The summition is {result}";

                clearForm();

            }
        }

        private void clearForm()
        {
            num1TextBox.Text = "";
            num2TextBox.Text = "";
        }

    }
}
