using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_16_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CalcularFactorial(int valorUsuario)
        {
            int factorial = 1;
            for (int i = valorUsuario; i >= 1; i--)
            {
                //Para calcular factorial multiplicar num introducido por los números debajo de el hasta llegar a 1
                factorial = factorial * i;
            }
            return factorial;
        }
        private void btbCalcFactorial_Click(object sender, EventArgs e)
        {
            int factorial;
            int valorUsuario = int.Parse(txtUserNumber.Text); 
            factorial = CalcularFactorial(valorUsuario);
            MessageBox.Show("El factorial es de " + factorial);
        }
    }
}
