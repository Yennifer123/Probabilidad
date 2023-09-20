using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probabilidad
{
    public partial class FormCalculoFactorial : Form
    {
        public FormCalculoFactorial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double factorial = 1;
            int number = Convert.ToInt32(textBox1.Text);

          
            for(int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            textBox2.Text = factorial.ToString();
        }
    }
}
