using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        String num1, num2;
        String op;
        String result;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = lblDisplay.Text;
            op = "+";
            lblDisplay.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Empty;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (num1 == string.Empty){
                num1 = lblDisplay.Text;
            }
            else
            {
                num2 = lblDisplay.Text;
            }
            Display();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = lblDisplay.Text;
            op = "/";
            lblDisplay.Text = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = lblDisplay.Text;
            op = "*";
            lblDisplay.Text = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = lblDisplay.Text;
            op = "-";
            lblDisplay.Text = string.Empty;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            num1 = lblDisplay.Text;
            result = Convert.ToString(Convert.ToDouble(num1) / 100);
            lblDisplay.Text = result;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "8";

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "9";
        }


        private void btnFour_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "6";
        }


        private void btnOne_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "3";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += ".";
        }


        void Display()
        {
            try
            {
                if (op == "+")
                {
                    result = Convert.ToString(Convert.ToDouble(num1) + Convert.ToDouble(num2));
                }


                if (op == "-")
                {
                    result = Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num2));
                }


                if (op == "/")
                {
                    result = Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num2));
                }


                if (op == "*")
                {
                    result = Convert.ToString(Convert.ToDouble(num1) * Convert.ToDouble(num2));
                }

                lblDisplay.Text = result;

            }
            catch (Exception)
            {
                lblDisplay.Text = string.Empty;
            }

        }
    }
}
