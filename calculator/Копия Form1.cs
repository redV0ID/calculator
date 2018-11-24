using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a, b;
        int count;
        bool znak = true;
        bool readytoclear = false;
        double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void clear()
        {
            if (readytoclear == true)
            {
                window.Clear();
                readytoclear = false;
            }
        }

        private void clicked(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + ((Button)sender).Text;
        }

        private void запятая_Click(object sender, EventArgs e)
        {
            clear();
            if (window.Text.IndexOf(',') == -1)
            {
            window.Text += ',';
            }
        }

        private void ноль_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 0;
                
        }

        private void один_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 1;
        }

        private void два_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 2;
        }

        private void три_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 3;
        }

        private void четыре_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 4;
        }

        private void пять_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 5;
        }

        private void шесть_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 6;
        }

        private void семь_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 7;
        }

        private void восемь_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 8;
        }

        private void девять_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = window.Text + 9;
        }

        private void удалитьсимвол_Click(object sender, EventArgs e)
        {
            int lenght = window.Text.Length - 1;
            string text = window.Text;
            window.Clear();
            for (int i = 0; i < lenght; i++)
            {
                window.Text = window.Text + text[i];
            }
        }

        private void очистить_Click(object sender, EventArgs e)
        {
            window.Text = "";
        }

        private void процент_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                float s;
                s = float.Parse(window.Text);
                s = s / 100;
                window.Text = s.ToString();
            }
        }

        private void равно_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                switch (count)
                {
                    case 1:
                        b = a + float.Parse(window.Text);
                        window.Text = b.ToString();
                        break;
                    case 2:
                        b = a - float.Parse(window.Text);
                        window.Text = b.ToString();
                        break;
                    case 3:
                        b = a * float.Parse(window.Text);
                        window.Text = b.ToString();
                        break;
                    case 4:
                        string s = "делить на ноль нельзя!";
                        if (float.Parse(window.Text) == 0)
                        {
                            window.Text = s;
                        }
                        else
                        {
                            b = a / float.Parse(window.Text);
                            window.Text = b.ToString();
                        }
                        break;
                    case 5:
                        {
                            if (double.Parse(window.Text) == 0) window.Text = b.ToString("1");
                            else
                            {
                                b = Math.Pow(a, double.Parse(window.Text));
                                window.Text = b.ToString();
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            readytoclear = true;
        }

        private void плюс_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                a = float.Parse(window.Text);
                count = 1;
                readytoclear = true;
                znak = true;
            }
        }

        private void минус_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                a = float.Parse(window.Text);      
                count = 2;
                readytoclear = true;
                znak = true;
            }
        }

        private void умножение_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                a = float.Parse(window.Text);
                count = 3;
                readytoclear = true;
                znak = true;
            }
        }

        private void деление_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                a = float.Parse(window.Text);
                count = 4;
                readytoclear = true;
                znak = true;
            }
        }

        private void знак_Click(object sender, EventArgs e)
        {
            clear();
            if (znak == true)
            {
                window.Text = "-" + window.Text;
                znak = false;
            }
            else
            {
                window.Text = window.Text.Replace("-", "");
                znak = true;
            }
        }

        private void мсохранить_Click(object sender, EventArgs e)
        {
            memory = double.Parse(window.Text);
            readytoclear = true;
        }

        private void выводзначения_Click(object sender, EventArgs e)
        {
            clear();
            window.Text = memory.ToString();
            readytoclear = true;
        }

        private void мочистить_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void мплюс_Click(object sender, EventArgs e)
        {
            memory = memory + double.Parse(window.Text);
        }

        private void мминус_Click(object sender, EventArgs e)
        {
            memory = memory - double.Parse(window.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            window.Text = Math.PI.ToString();
            readytoclear = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                float x;
                x = float.Parse(window.Text);
                x = x * x;
                window.Text = x.ToString();
                readytoclear = true;
            }
        }

        private void корень_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                double x;
                x = double.Parse(window.Text);
                x = Math.Sqrt(x);
                window.Text = x.ToString();
                readytoclear = true;
            }
        }

        private void степень_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                a = double.Parse(window.Text);
                count = 5;
                readytoclear = true;
                znak = true;
            }
        }

        private void косинус_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                double x;
                x = double.Parse(window.Text);
                x =  x * (Math.PI / 180);
                x = Math.Sin(x);
                window.Text = x.ToString();
                readytoclear = true;
            }
        }

        private void косинус1_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                double x;
                x = double.Parse(window.Text);
                x = x * (Math.PI / 180);
                x = Math.Cos(x);
                window.Text = x.ToString();
                readytoclear = true;
            }
        }

        private void тангенс_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                double x;
                x = double.Parse(window.Text);
                x = x * (Math.PI / 180);
                x = Math.Tan(x);
                window.Text = x.ToString();
                readytoclear = true;
            }
        }

        private void катангенс_Click(object sender, EventArgs e)
        {
            if (window.Text != "")
            {
                double x;
                x = double.Parse(window.Text);
                x = x * (Math.PI / 180);
                x = Math.Cos(x) / Math.Sin(x);
                window.Text = x.ToString();
                readytoclear = true;
            }
        }
    }
}
