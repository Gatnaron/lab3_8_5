using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numericUpDown1.Value);
            double sum = 1;
            double currentNumber = 1;
            for (int i = 2; i <= num; i++)
            {
                currentNumber *= i;
                sum += currentNumber;
            }
            textBox1.Text = String.Format("{0}", sum);
        }
    }
}
