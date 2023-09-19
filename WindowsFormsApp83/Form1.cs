using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp83
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int x = int.Parse(textBox2.Text);
            mydelegate t = new mydelegate(Factorial);
            Tarkib sample = new Tarkib();
            sample.n = n;
            sample.x = x;
            listBox1.Items.Add(sample.Composition(t));
        }

        private double Factorial(int x)
        {
            double s = 1;
            for (int temp = x; temp >= 1; temp--)
                s = s * temp;

            return s;
        }
    }
}

