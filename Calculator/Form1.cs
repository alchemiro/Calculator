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
            global = Factor1TextBox;//start global in factor 1
        }

        private void operatorClicked(object sender, EventArgs e)
        {
            OperatorTextBox.Text = ((Button)sender).Text;
            global = Factor2TextBox; //add correct operator and move to next factor
        }

        private void clearClicked(object sender, EventArgs e)
        {
            Factor1TextBox.Clear();
            Factor2TextBox.Clear();
            OperatorTextBox.Clear();
            textResultBox.Clear();
            global = Factor1TextBox;//clear everything and reset global to the first text box
        }

        private void getResult(object sender, EventArgs e)
        {
            switch (OperatorTextBox.Text)//switch case for which operator you chose
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

        private void numpadClick(object sender, EventArgs e)//every numpad (number) click event adds the text value to the global factor
        {
            global.Text += ((Button)sender).Text;
        }
        private void numpad_MouseMove(object sender, MouseEventArgs e)//troll feature
        {
            Button button = (Button)sender;
            Random random = new Random();
            if (trollBox.Checked)
            {
                int rndX = random.Next(-5, 6), rndY = random.Next(-5, 6);
                button.Location = new Point(button.Location.X + rndX, button.Location.Y + rndY);
            }            
            
        }

        private void changeTrollMode(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox) sender;
            if (!check.Checked)
            {
                Numpad0.Location = new Point(73, 377);
                numpadDot.Location = new Point(263, 377);
                Numpad1.Location = new Point(73, 308);
                Numpad2.Location = new Point(166, 308);
                Numpad3.Location = new Point(263, 308);
                Numpad4.Location = new Point(73, 233);
                Numpad5.Location = new Point(166, 233);
                Numpad6.Location = new Point(263, 233);
                Numpad7.Location = new Point(73, 164);
                Numpad8.Location = new Point(166, 164);
                Numpad9.Location = new Point(263, 164);

                NumpadPlus.Location = new Point(430, 164);
                NumpadMinus.Location = new Point(430, 263);
                NumpadMultiply.Location = new Point(430, 308);
                NumpadDivide.Location = new Point(520, 164);
                clearButton.Location = new Point(610, 164);
                NumpadRemainder.Location = new Point(520, 233);
                NumpadEquals.Location = new Point(610, 233);
                NumpadExponent.Location = new Point(520, 308);

            }
        }
    }
}
