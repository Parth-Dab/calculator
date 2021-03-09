using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowsform
{
    public partial class Form1 : Form
    {
        static int count = 0;
        double firstnum, secondnum;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text += "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "2";
            }
            else
            {
                textBox2.Text += "2";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text += "5";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text += "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text += "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "0";
            }
            else
            {
                textBox2.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                textBox2.Text += ".";
                count = 1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                int txtlength = textBox2.Text.Length;
                if (txtlength != 1)
                {
                    textBox2.Text = textBox2.Text.Remove(txtlength - 1);
                }
                else
                {
                    textBox2.Text = "".ToString();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "-")
            {
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text = firstnum.ToString();
                textBox3.Text = "-";
                textBox2.Text = "0";
            }
            
            if (textBox3.Text == "-" && textBox2.TextLength > 0)
            {
                secondnum = Convert.ToDouble(textBox2.Text);
                firstnum = firstnum - secondnum;
                textBox1.Text = firstnum.ToString();
                textBox2.Text = "0";
                if (count == 1)
                {
                    count = 0;
                }
                
            }
            
          


        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "*")
            {
                
                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text = firstnum.ToString();
                textBox3.Text = "*";
                textBox2.Text = "1";

            }

            if (textBox3.Text == "*" && textBox2.TextLength > 0)
            { 
                    secondnum = Convert.ToDouble(textBox2.Text);
                    firstnum = (firstnum * secondnum);
                    textBox1.Text = firstnum.ToString();
                    textBox2.Text = "0";
                if (count == 1)
                {
                    count = 0;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
                if (textBox3.Text != "+")
                {
                    firstnum = Convert.ToDouble(textBox2.Text);
                    textBox1.Text = firstnum.ToString();
                    textBox3.Text = "+";
                    textBox2.Text = "0";
                }
                
                if (textBox3.Text == "+" && textBox2.TextLength > 0)
                {
                        secondnum = Convert.ToDouble(textBox2.Text);
                        firstnum = firstnum + secondnum;
                        textBox1.Text = firstnum.ToString();
                        textBox2.Text = "0";
                        if (count == 1)
                        {
                            count = 0;
                        }
                }
                
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "/")
            {

                firstnum = Convert.ToDouble(textBox2.Text);
                textBox1.Text = firstnum.ToString();
                textBox3.Text = "/";
                textBox2.Text = "1";

            }

            if (textBox3.Text == "/" && textBox2.TextLength > 0)
            {
                int c = 0;
                string cm;
                secondnum = Convert.ToDouble(textBox2.Text);
                if (secondnum < firstnum)
                {
                    firstnum = (firstnum / secondnum);
                }
                else
                {
                    c = 1;
                }

                if (c == 1)
                {
                    cm = "wrong input";
                    textBox2.Text = cm;
                }
                else
                {
                    textBox1.Text = firstnum.ToString();
                    textBox2.Text = "0";
                    if (count == 1)
                    {
                        count = 0;
                    }
                }
                
              
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "+")
            {
                secondnum = Convert.ToDouble(textBox2.Text);
                firstnum = firstnum + secondnum;
                textBox1.Text = firstnum.ToString();
                textBox2.Text = "0";
                textBox3.Text = "+";
                if (count == 1)
                {
                    count = 0;
                }
            }
            else if (textBox3.Text == "-")
            {
                secondnum = Convert.ToDouble(textBox2.Text);
                firstnum = firstnum - secondnum;
                textBox1.Text = firstnum.ToString();
                textBox2.Text = "0";
                textBox3.Text = "-";
                if (count == 1)
                {
                    count = 0;
                }
            }
            else if (textBox3.Text == "*")
            {
                secondnum = Convert.ToDouble(textBox2.Text);
                firstnum = (firstnum * secondnum);
                textBox1.Text = firstnum.ToString();
                textBox2.Text = "0";
                if (count == 1)
                {
                    count = 0;
                }
            }
            else if (textBox3.Text == "/")
            {
                int c = 0;
                string cm;
                secondnum = Convert.ToDouble(textBox2.Text);
                if (secondnum < firstnum)
                {
                    firstnum = (firstnum / secondnum);
                }
                else
                {
                    c = 1;
                }

                if (c == 1)
                {
                    cm = "wrong input";
                    textBox2.Text = cm;
                }
                else
                {
                    textBox1.Text = firstnum.ToString();
                    textBox2.Text = "0";
                    if (count == 1)
                    {
                        count = 0;
                    }
                }

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
