﻿using System;
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
            OperatorTextBox.Text = ((Button)sender).Text; //cast sender as button so we can change the text
            global = Factor2TextBox; //add correct operator and move to next factor
        }

        private void clearClicked(object sender, EventArgs e)
        {
            Factor1TextBox.Clear();//clear factor 1 of all text
            Factor2TextBox.Clear(); //clear factor 2 of all text
            OperatorTextBox.Clear(); //remove the operator
            textResultBox.Clear(); //clear any leftover result
            global = Factor1TextBox;//reset global to the first text box
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
            global.Text += ((Button)sender).Text;//cast sender as button to interact
        }
        private void numpad_MouseMove(object sender, MouseEventArgs e)//troll feature
        {
            Button button = (Button) sender;//cast button
            Random random = new Random();
            int rndX = random.Next(-5,6), rndY = random.Next(-5,6);//generate 2 random numbers
            button.Location = new Point(button.Location.X+rndX, button.Location.Y+rndY);//change location accordingly
        }
    }
}
