using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool divisible(int num1, int num2)
        {
            bool result;
            if (num1 % num2 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool result;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            result = divisible(num1, num2);

            if (result == true)
            {
                MessageBox.Show("El número " + num1 + " es divisible por el número " + num2);
            }
            else
            {
                MessageBox.Show("El número " + num1 + " no es divisible por el número " + num2);
            }
        }
    }
}
