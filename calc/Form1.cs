using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double add(double a, double b) { return a + b; }
        public double dif(double a, double b) { return a - b; }
        public double mult(double a, double b) { return a * b; }
        public double div(double a, double b) { return a / b; }

        public double calc(double a, string op, double b)
        {
            if (op == "+") { return add(a, b); }
            else if (op == "-") { return dif(a, b); }
            else if (op == "*") { return mult(a, b); }
            else if (op == "/")
            {
                if (a != 0 && b != 0)
                {
                    return div(a, b);
                }
                else
                {
                    return -1;
                }

            }
            else { return -1; }
        }

        

            private void Form1_Load(object sender, EventArgs e)
        {
            Text += "  ;  ";
            Text += calc(10, "+", 9);
            Text += "  ;  ";
            Text += calc(10, "-", 9);
            Text += "  ;  ";
            Text += calc(10, "*", 9);
            Text += "  ;  ";
            Text += calc(10, "/", 9);
            Text += "  ;  ";
        }
    }
}
