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
            this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (textBox_number.Text.Length > 0)
                {
                    textBox_number.Text = textBox_number.Text.Substring(0, textBox_number.Text.Length - 1);
                }
            }
        }

        /// <summary>
        /// check the operation
        /// </summary>
        /// <param name="e"></param>
        public void checkOperation(char e)
        {
            if (e == '+')
            {
                operand1 = textBox_number.Text;
                operation = '+';
                textBox_number.Text = string.Empty;
            }
            if (e == '-')
            {
                operand1 = textBox_number.Text;
                operation = '-';
                textBox_number.Text = string.Empty;
            }
            if (e == '*')
            {
                operand1 = textBox_number.Text;
                operation = '*';
                textBox_number.Text = string.Empty;
            }
            if (e == '/')
            {
                operand1 = textBox_number.Text;
                operation = '/';
                textBox_number.Text = string.Empty;
            }
            if (e == '=')
            {
                operand2 = textBox_number.Text;
                double num1, num2;
                double.TryParse(operand1, out num1);
                double.TryParse(operand2, out num2);

                if (operation == '+')
                {
                    result = num1 + num2;
                    textBox_number.Text = result.ToString();
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                    textBox_number.Text = result.ToString();
                }
                else if (operation == '*')
                {
                    result = num1 * num2;
                    textBox_number.Text = result.ToString();
                }
                else if (operation == '/')
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        textBox_number.Text = result.ToString();
                    }
                    else
                    {
                        textBox_number.Text = "DIV/Zero!";
                    }
                }
            }
        }

        /// <summary>
        /// Displays the button pressed onto the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                textBox_number.Text += "0";
                textBox_memory.Text += "0";
            }
            else if (e.KeyChar == '1')
            {
                textBox_number.Text += "1";
                textBox_memory.Text += "1";
            }
            else if (e.KeyChar == '2')
            {
                textBox_number.Text += "2";
                textBox_memory.Text += "2";
            }
            else if (e.KeyChar == '3')
            {
                textBox_number.Text += "3";
                textBox_memory.Text += "3";
            }
            else if (e.KeyChar == '4')
            {
                textBox_number.Text += "4";
                textBox_memory.Text += "4";
            }
            else if (e.KeyChar == '5')
            {
                textBox_number.Text += "5";
                textBox_memory.Text += "5";
            }
            else if (e.KeyChar == '6')
            {
                textBox_number.Text += "6";
                textBox_memory.Text += "6";
            }
            else if (e.KeyChar == '7')
            {
                textBox_number.Text += "7";
                textBox_memory.Text += "7";
            }
            else if (e.KeyChar == '8')
            {
                textBox_number.Text += "8";
                textBox_memory.Text += "8";
            }
            else if (e.KeyChar == '9')
            {
                textBox_number.Text += "9";
                textBox_memory.Text += "9";
            }
            else if (e.KeyChar == '+')
            {
                textBox_memory.Text += "+";
            }
            else if (e.KeyChar == '-')
            {
                textBox_memory.Text += "-";
            }
            else if (e.KeyChar == '*')
            {
                textBox_memory.Text += "*";
            }
            else if (e.KeyChar == '/')
            {
                textBox_memory.Text += "/";
            }
            else if (e.KeyChar == '.')
            {
                if (!(textBox_number.Text.Contains(".")))
                {
                    textBox_number.Text += ".";
                    textBox_memory.Text += ".";
                }
            }
            else
            {
                checkOperation(e.KeyChar);
            }


        }

        /// <summary>
        /// Turns the calculator on and off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOn_Click(object sender, EventArgs e)
        {
            if (buttonOn.Text == "ON")
            {
                buttonOn.Text = "OFF";
                textBox_memory.Clear();
                textBox_number.Clear();
                pictureBox1.Visible = false;
                panelNumbers.Visible = false;
            }
            else
            {
                buttonOn.Text = "ON";
                textBox_memory.Clear();
                textBox_number.Clear();
                pictureBox1.Visible = true;
                panelNumbers.Visible = true;
            }
        }

        /// <summary>
        /// button for number 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOne_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }
        /// <summary>
        /// button for number 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }
        /// <summary>
        /// button for number 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNine_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }
        /// <summary>
        /// button for number 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFour_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }
        /// <summary>
        /// button for number 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonThree_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }
        /// <summary>
        /// button for number 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEight_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }
        /// <summary>
        /// button for number 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFive_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }
        /// <summary>
        /// button for number 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }
        /// <summary>
        /// button for number 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSix_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }
        /// <summary>
        /// button for number 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZero_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }
        /// <summary>
        /// button for decimal point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDot_Click(object sender, EventArgs e)
        {
            SendKeys.Send(".");
        }

        /// <summary>
        /// button for the negative and positive sign
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text.Substring(0, 1) == "-")
            {
                textBox_number.Text = "+" + textBox_number.Text.Substring(1, textBox_number.Text.Length - 1);
                textBox_memory.Text = "+" + textBox_memory.Text.Substring(1, textBox_memory.Text.Length - 1);
            }
            else if (textBox_number.Text.Substring(0, 1) == "+")
            {
                textBox_number.Text = "-" + textBox_number.Text.Substring(1, textBox_number.Text.Length - 1);
                textBox_memory.Text = "-" + textBox_memory.Text.Substring(1, textBox_memory.Text.Length - 1);
            }
            else
            {
                textBox_number.Text = "-" + textBox_number.Text;
                textBox_memory.Text = "-" + textBox_memory.Text;
            }
        }
        /// <summary>
        /// button for minus operand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            SendKeys.Send("-");
            checkOperation('-');
        }
        /// <summary>
        /// button for divide operand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            SendKeys.Send("/");
            checkOperation('/');
        }
        /// <summary>
        /// button for multiplication operand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMulti_Click(object sender, EventArgs e)
        {
            SendKeys.Send("*");
            checkOperation('*');
        }
        /// <summary>
        /// button for equal operand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            checkOperation('=');
        }
        /// <summary>
        /// button for backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text.Length > 0)
            {
                textBox_number.Text = textBox_number.Text.Substring(0, textBox_number.Text.Length - 1);
            }
        }
        /// <summary>
        /// button for clear sign
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCE_Click_1(object sender, EventArgs e)
        {
            textBox_number.Text = string.Empty;
        }
        /// <summary>
        /// button for plus operand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlus_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("+");
            checkOperation('+');
        }
        /// <summary>
        /// button for clear all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox_number.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

    }
}