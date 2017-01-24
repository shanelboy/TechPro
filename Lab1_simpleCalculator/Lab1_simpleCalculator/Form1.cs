using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_simpleCalculator
{
    /// <summary>
    /// Purpose:
    /// Input:
    /// Output:
    /// Author:
    /// Date:
    /// Updated by:
    /// Date:
    /// </summary>
    public partial class SimpleCalculator : Form
    {
        string input = string.Empty;
        string operand1, operand2;
        char operation;
        double result = 0;

        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(Calculator_KeyDown);
        }


        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                textBox_number.Text += "0";
            }
            if (e.KeyCode == Keys.D1)
            {
                textBox_number.Text += "1";
            }
            if (e.KeyCode == Keys.D2)
            {
                textBox_number.Text += "2";
            }
            if (e.KeyCode == Keys.D3)
            {
                textBox_number.Text += "3";
            }
            if (e.KeyCode == Keys.D4)
            {
                textBox_number.Text += "4";
            }
            if (e.KeyCode == Keys.D5)
            {
                textBox_number.Text += "5";
            }
            if (e.KeyCode == Keys.D6)
            {
                textBox_number.Text += "6";
            }
            if (e.KeyCode == Keys.D7)
            {
                textBox_number.Text += "7";
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                textBox_number.Text += "8";
            }
            if (e.KeyCode == Keys.D9)
            {
                textBox_number.Text += "9";
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                if (!(textBox_number.Text.Contains(".")))
                    textBox_number.Text += ".";
            }
            if (e.KeyCode == Keys.Back)
            {
                if (textBox_number.Text.Length > 0)
                {
                    textBox_number.Text = textBox_number.Text.Substring(0, textBox_number.Text.Length - 1);
                }
            }
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            if (buttonOn.Text == "ON")
            {
                buttonOn.Text = "OFF";
                panelNumbers.Visible = false;
            }
            else
            {
                buttonOn.Text = "ON";
                panelNumbers.Visible = true;
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            SendKeys.Send(".");
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text.Substring(0, 1) == "-")
            {
                textBox_number.Text = "+" + textBox_number.Text.Substring(1, textBox_number.Text.Length - 1);
            }
            else if (textBox_number.Text.Substring(0, 1) == "+")
            {
                textBox_number.Text = "-" + textBox_number.Text.Substring(1, textBox_number.Text.Length - 1);
            }
            else
            {
                textBox_number.Text = "-" + textBox_number.Text;
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            SendKeys.Send("/");
        }
        /// <summary>
        /// I couldn't figure out how to differentiate "*" with "8" when sending keys,
        /// so I decide to implement all the operator seperately without sending the keys to key event handler.
        /// -Bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMulti_Click(object sender, EventArgs e)
        {
            SendKeys.Send("*");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            SendKeys.Send("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            SendKeys.Send("-");
        }
    }
}
