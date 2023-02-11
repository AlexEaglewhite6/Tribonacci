using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tribonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            string output = string.Empty;
            UInt64 first = 1, second = 1, third = 1, fourth = 0;
            if (n <= 3)
            {
                output += String.Concat(Enumerable.Repeat("1 ", n));
            }
            else output += "1 1 1 ";
            for (int i = 3; i < n; i++)
            {
                fourth = first + second + third;
                output += $"{fourth} ";
                first = second;
                second = third;
                third = fourth;
            }
            textBox2.Text = output;
        }
    }
}
