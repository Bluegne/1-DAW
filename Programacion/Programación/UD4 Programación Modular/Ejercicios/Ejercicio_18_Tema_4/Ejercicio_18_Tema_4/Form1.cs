using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_18_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int calcPotencia (int m, int n)
        {
            int potencia = 1;
            for (int i = 1; i <= n; i = i + 1)
            {
                potencia = potencia * m;
            }
            return potencia;
        }
        int calFactorial (int n)
        {
            int factorial = 1;
            for (int i = n; i >= 1; i = i - 1)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtNumM.Text);
            int n = int.Parse(txtNumN.Text);
            double division, sumaSerie;
            sumaSerie = 0;
            int potencia, factorial;

            for (int i = 1; i <= n; i = i + 1)
            {
                potencia = calcPotencia(m, i);
                factorial = calFactorial(i);
                division = (double) potencia / factorial;
                sumaSerie = sumaSerie + division;
            }
            MessageBox.Show("El resultado es: " + sumaSerie);
        }
    }
}
