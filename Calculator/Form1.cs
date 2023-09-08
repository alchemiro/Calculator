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
    public partial class Form1 : Form
    {
        TextBox global;
        public Form1()
        {
            InitializeComponent();
            global = Factor1TextBox;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void operatorClicked(object sender, EventArgs e)
        {
            OperatorTextBox.Text = ((Button)sender).Text;
            global = Factor2TextBox;
        }

        private void clearClicked(object sender, EventArgs e)
        {
            Factor1TextBox.Clear();
            Factor2TextBox.Clear();
            OperatorTextBox.Clear();
            textResultBox.Clear();
            global = Factor1TextBox;
        }

        private void getResult(object sender, EventArgs e)
        {
            switch (OperatorTextBox.Text)
            {
                case "+":
                    textResultBox.Text = (double.Parse(Factor1TextBox.Text) + double.Parse(Factor2TextBox.Text)).ToString();
                    break;
                case "-":
                    textResultBox.Text = (double.Parse(Factor1TextBox.Text) - double.Parse(Factor2TextBox.Text)).ToString();
                    break;
                case "*":
                    textResultBox.Text = (double.Parse(Factor1TextBox.Text) * double.Parse(Factor2TextBox.Text)).ToString();
                    break;
                case "/":
                    textResultBox.Text = (double.Parse(Factor1TextBox.Text) / double.Parse(Factor2TextBox.Text)).ToString();
                    break;
                case "%":
                    textResultBox.Text = (double.Parse(Factor1TextBox.Text) % double.Parse(Factor2TextBox.Text)).ToString();
                    break;
                case "^":
                    textResultBox.Text = (Math.Pow(double.Parse(Factor1TextBox.Text),double.Parse(Factor2TextBox.Text))).ToString();
                    break;
                default:
                    break;
            }
        }

        private void numpadClick(object sender, EventArgs e)
        {
            global.Text += ((Button)sender).Text;
        }
        private void numpad_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = (Button) sender;
            Random random = new Random();
            int rndX = random.Next(-5,6), rndY = random.Next(-5,6);
            button.Location = new Point(button.Location.X+rndX, button.Location.Y+rndY);
        }
    }
}
