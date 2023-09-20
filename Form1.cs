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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conjuntoAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cONJUNTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fACTORIALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cALCULOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Lienzo = new FormCalculoFactorial();
            Lienzo.Show();
        }

        

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Lienzo1 = new FormOperaciones();
            Lienzo1.Show();
        }
    }
}
