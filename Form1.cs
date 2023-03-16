using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        char operation;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            string number = (sender as Button).Text; 
            if (number == "." && lblScreen.Text.Contains("."))
            {
                lblScreen.Text += "";
            }
            else
            {
                lblScreen.Text += number;
            }
            
        }

        private void optClicked(object sender, EventArgs e) 
        {
            string opt = (sender as Button).Text;
            num1 = double.Parse(lblScreen.Text);
            operation = char.Parse(opt);
            clearScreen();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(lblScreen.Text);
            double result=0;
            if (operation == '+') result = num1 + num2;
            if (operation == '-') result = num1 - num2;
            if (operation == 'x') result = num1 * num2;
            if (operation == '/') result = num1 / num2;

            lblScreen.Text = result.ToString();
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            clearScreen();
            
        }

        private void clearScreen()
        {
            lblScreen.Text = "";
        }

        
    }
}
