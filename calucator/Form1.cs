using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calucator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BackColor = Color.Violet;
            
        }

        // number 1 button
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;

        }

        // number 2 button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        // number 3 button
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        // number 4 button
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        // number 5 button
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        // number 6 button
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        // number 7 button
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        // number 8 button
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        // number 9 button
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        // number 0 button
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        // momayez button
        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text = textBox1.Text + '.';
            else 
                MessageBox.Show("بیشتر از یک ممیز وارد کرده اید !!!!!!!!! ");
        }

        double a ;
        string c;
        // جمع
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                c = button12.Text;
                textBox1.Text = "";
            }
        }

        // تفریق
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                c = button13.Text;
                textBox1.Text = "";
            }
        }

        // ضرب
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                c = button15.Text;
                textBox1.Text = "";
            }
        }

        // تقسیم
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                c = button14.Text;
                textBox1.Text = "";
            }
        }

        // جذر
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(a));
            }
        }

       // توان
        private void button20_Click(object sender, EventArgs e)
        {
          

            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                c = button20.Text;
                textBox1.Text = "";
            }
        }

        
        // فاکتوریل
        private void button18_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکرده اید ");
            else 
            {
                a = int.Parse(textBox1.Text);
                int number = 1;
                for (int i = 1; i <= a; i++)
                    number = number * i;
                textBox1.Text = Convert.ToString(Convert.ToString(number));
            }
        }

        // مد (باقیمانده
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                c = button21.Text;
                textBox1.Text = "";
            }
        }

        // or تابع
        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = Int64.Parse(textBox1.Text);
                c = button23.Text;
                textBox1.Text = "";
            }
        }

        // and تابع
        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = Int64.Parse(textBox1.Text);
                c = button24.Text;
                textBox1.Text = "";
            }
        }

        //برای تبدیل عدد به باینری mode تابع
        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                Int64 s = 0, m, r;
                double i = 0;
                double h;
                h = Int64.Parse(textBox1.Text);

                while (h != 0)
                {
                    m = Convert.ToInt64(h) / 2;
                    r = Convert.ToInt64(h) % 2;
                    s = s + r * Convert.ToInt64(Math.Pow(10.00, i));
                    i += 1;
                    h = m;
                }
                textBox1.Text = Convert.ToString(s);
            }
        }

        // معکوس
        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(-1 * a);
            }
        }


        // مساوی
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                if (c == "+")
                {

                    a = (a + Convert.ToDouble(textBox1.Text));
                    textBox1.Text = a.ToString();

                }

                else if (c == "-")
                {

                    textBox1.Text = (a - Convert.ToDouble(textBox1.Text)).ToString();

                }

                else if (c == "/")
                {

                    textBox1.Text = (a / Convert.ToDouble(textBox1.Text)).ToString();

                }

                else if (c == "*")
                {

                    textBox1.Text = (a * Convert.ToDouble(textBox1.Text)).ToString();

                }

                else if (c == "%")
                {

                    textBox1.Text = (a % Convert.ToDouble(textBox1.Text)).ToString();

                }

                else if (c == "pow")
                {
                    double h = double.Parse(textBox1.Text);
                    textBox1.Text = Convert.ToString(Math.Pow(a, h));
                }

                // or 
                else if (c == "or")
                {
                    Int64 h, total = 0;
                    h = Convert.ToInt64(textBox1.Text);
                    if (a > h)
                    {
                        for (int i = 0; a != 0; i++)
                        {
                            int qw, rt;
                            qw = Convert.ToInt32(a % 10);
                            rt = Convert.ToInt32(h % 10);
                            if ((qw + rt) > 0)
                                total = Convert.ToInt64(total + 1 * Math.Pow(10, i));

                            a /= 10;
                            h /= 10;
                        }
                        textBox1.Text = Convert.ToString(total);
                    }
                    else
                    {
                        {
                            for (int i = 0; h != 0; i++)
                            {
                                int qw, rt;
                                qw = Convert.ToInt32(a % 10);
                                rt = Convert.ToInt32(h % 10);
                                if ((qw + rt) > 0)
                                    total = Convert.ToInt64(total + 1 * Math.Pow(10, i));

                                a /= 10;
                                h /= 10;
                            }
                            textBox1.Text = Convert.ToString(total);
                        }
                    }
                }

                // and 
                else if (c == "and")
                {
                    Int64 h, total = 0;
                    h = Convert.ToInt64(textBox1.Text);
                    if (a > h)
                    {
                        for (int i = 0; a != 0; i++)
                        {
                            int qw, rt;
                            qw = Convert.ToInt32(a % 10);
                            rt = Convert.ToInt32(h % 10);
                            if ((qw + rt) > 1)
                                total = Convert.ToInt64(total + 1 * Math.Pow(10, i));

                            a /= 10;
                            h /= 10;
                        }
                        textBox1.Text = Convert.ToString(total);
                    }
                    else
                    {
                        {
                            for (int i = 0; h != 0; i++)
                            {
                                int qw, rt;
                                qw = Convert.ToInt32(a % 10);
                                rt = Convert.ToInt32(h % 10);
                                if ((qw + rt) > 1)
                                    total = Convert.ToInt64(total + 1 * Math.Pow(10, i));

                                a /= 10;
                                h /= 10;
                            }
                            textBox1.Text = Convert.ToString(total);
                        }
                    }
                }
            }
        }

        
        
        // پاک کردن ( clear )
        private void button17_Click(object sender, EventArgs e)
        {
        textBox1.Text = "";
        a = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }

        // sin دکمه
        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sin(a * Math.PI / 180));
            }
        }

        // cos دکمه
        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Cos(a * Math.PI / 180));
            }
        }

        // tan دکمه
        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Tan(a * Math.PI / 180));
            }
        }
        // cot دکمه
        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show(" عدد وارد نکردید ");
            else
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(1 / Math.Tan(a * Math.PI / 180));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        
        
        }
    }

