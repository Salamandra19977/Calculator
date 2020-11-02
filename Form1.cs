using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            inputTextBox.MaxLength = 12;
            arithmeticBlock.Enabled = false;
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            switch ((int)e.KeyChar)
            {
                case 43:
                    this.MappingInForm("+");
                    break;
                case 45:
                    this.MappingInForm("-");
                    break;
                case 42:
                    this.MappingInForm("*");
                    break;
                case 47:
                    this.MappingInForm("/");
                    break;
            }
        }
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length == 0)
                arithmeticBlock.Enabled = false;
            else
                arithmeticBlock.Enabled = true;

        }
        private void EquallyBtn_Click(object sender, EventArgs e)
        {
            this.MappingInForm(Calculate.Sign);
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            this.MappingInForm("+");
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (Parse.CheckDiff(inputTextBox.Text))
                inputTextBox.Text += "-";
            else {
                double outp;
                if (double.TryParse(inputTextBox.Text, out outp))
                    this.MappingInForm("-");
                else
                    MessageBox.Show("Введите число");
            }
        }

        private void SplitBtn_Click(object sender, EventArgs e)
        {
            this.MappingInForm("/");
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            this.MappingInForm("*");
        }

        private void MappingInForm(string sign)
        {
            if (Calculate.NumberOne.ToString() == "NaN")
            {
                Calculate.Sign = sign;
                Calculate.NumberOne = Convert.ToDouble(inputTextBox.Text);
                prewNumber.Text = Calculate.NumberOne.ToString() + sign;
                inputTextBox.Text = String.Empty;
            }
            else
            {
                Calculate.NumberTwo = Convert.ToDouble(inputTextBox.Text);
                try
                {
                    switch(sign)
                    {
                        case "+":
                            {
                                prewNumber.Text = Calculate.NumberOne.ToString() + " + " + Calculate.NumberTwo + " = " + Calculate.Sum().ToString();
                                HistoryList.OperationList.Add(Calculate.NumberOne.ToString() + Calculate.Sign + Calculate.NumberTwo.ToString() + "=" + Calculate.Sum().ToString());
                                inputTextBox.Text = Calculate.Sum().ToString();
                                break;
                            }
                        case "-":
                            {
                                prewNumber.Text = Calculate.NumberOne.ToString() + " - " + Calculate.NumberTwo + " = " + Calculate.Diff().ToString();
                                HistoryList.OperationList.Add(Calculate.NumberOne.ToString() + Calculate.Sign + Calculate.NumberTwo.ToString() + "=" + Calculate.Diff().ToString());
                                inputTextBox.Text = Calculate.Diff().ToString();
                                break;
                            }
                        case "/":
                            {
                                prewNumber.Text = Calculate.NumberOne.ToString() + " / " + Calculate.NumberTwo + " = " + Calculate.Share().ToString();
                                HistoryList.OperationList.Add(Calculate.NumberOne.ToString() + Calculate.Sign + Calculate.NumberTwo.ToString() + "=" + Calculate.Share().ToString());
                                inputTextBox.Text = Calculate.Share().ToString();
                                break;
                            }
                        case "*":
                            {
                                prewNumber.Text = Calculate.NumberOne.ToString() + " * " + Calculate.NumberTwo + " = " + Calculate.Multiply().ToString();
                                HistoryList.OperationList.Add(Calculate.NumberOne.ToString() + Calculate.Sign + Calculate.NumberTwo.ToString() + "=" + Calculate.Multiply().ToString());
                                inputTextBox.Text = Calculate.Multiply().ToString();
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.Beep();
                }
                Calculate.Clear();
            }
        }
        private void NumberOneBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 1;
        }

        private void NumberTwoBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 2;
        }

        private void NumberThreeBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 3;
        }

        private void NumberFourBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 4;
        }

        private void NumberFiveBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 5;
        }

        private void NumberSixBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 6;
        }

        private void NumberSevenBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 7;
        }

        private void NumberEightBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 8;
        }

        private void NumberNineBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 9;
        }

        private void NuberNilBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text += 0;
        }

        private void SeparatorBtn_Click(object sender, EventArgs e)
        {
            if (Parse.CheckSeparator(inputTextBox.Text))
            inputTextBox.Text += ",";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text != string.Empty)
                inputTextBox.Text = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1);
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            prewNumber.Text = String.Empty;
            Calculate.Clear();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            History obj = new History();
            obj.Show();
        }
    }
}
