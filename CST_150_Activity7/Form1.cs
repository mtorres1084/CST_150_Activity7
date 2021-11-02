using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int counter;
            double pi = 1;
            int terms = int.Parse(termsTB.Text);
            double sum = 0;

            for(counter = 1; counter <= terms; counter++)
            {
                if((counter % 2) == 1)
                {
                    sum = sum + 1.0 / ((2.0 * (double)counter) - 1.0);
                }
                else
                {
                    sum = sum - 1.0 / ((2.0 * (double)counter) - 1.0);
                }
                pi = 4 * sum;
            }
            approxLabel.Text = "Approximate value of pi after " + terms + " terms";
            resultLabel.Text = pi.ToString();
        }

        private void termsTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
