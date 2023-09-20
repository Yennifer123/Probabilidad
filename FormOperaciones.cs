using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probabilidad
{
    public partial class FormOperaciones : Form
    {
        private HashSet<string> conjuntoA = new HashSet<string>();
        private HashSet<string> conjuntoB = new HashSet<string>();
        private HashSet<string> unionAB = new HashSet<string>();
        private HashSet<string> interseccionAB = new HashSet<string>();

        FormOperaciones operaciones;
        public FormOperaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int numero1 = 0;
                int numero2 = 0;
                int temp1;
                int temp2;
                int i, j, sz = 1;
                int zs = 1;
                string resultado1 = "";
                string resultado2 = "";

                numero1 = int.Parse(textBox1.Text);
                numero2 = int.Parse(textBox2.Text);

                temp1 = numero1;
                temp2 = numero2;

                while (temp1 / 10 > 0)
                {
                    temp1 /= 10;
                    sz++;
                }

                while (temp2 / 10 > 0)
                {
                    temp2 /= 10;
                    zs++;
                }

                int[] elementos1 = new int[sz];
                int[] elementos2 = new int[zs];

                i = 0;

                while (numero1 > 0)
                {
                    elementos1[i] = numero1 % 10;
                    numero1 /= 10;
                    i++;

                }
                i = 0;

                while (numero2 > 0)
                {
                    elementos2[i] = numero2 % 10;
                    numero2 /= 10;
                    i++;

                }

                textBox3.Text = "";
                textBox4.Text = "";

                for (i = sz - 1; i >= 0; i--)
                {
                    resultado1 += elementos1[i].ToString() + "";
                }

                for (i = zs - 1; i >= 0; i--)
                {
                    resultado1 += elementos2[i].ToString() + "";
                }

                textBox3.Text = resultado1;

                for (i = sz - 1; i >= 0; i--)

                {
                    for (j = zs - 1; j >= 0; j--)
                    {
                        if (elementos2[j] == elementos1[i])
                        {
                            resultado2 += elementos2[j].ToString();
                        }
                    }
                }
                textBox4.Text = resultado2;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
    







