using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Sum(double num1, double num2)
        {
            double res = num1 + num2;
            return res;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double res = Sum(num1, num2);

            MessageBox.Show("La suma de " + num1 + " y " + num2 + " es igual a " + res);
        }
    }
}
