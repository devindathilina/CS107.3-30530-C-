using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Question1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);

            // Calculate the sum
            double sum = num1 + num2;

            // Update the label text with the sum
            SumLabel.Text = "Sum: " + sum.ToString();
            SumLabel.Text = $"Addition: {sum}";
        }
    }
}
