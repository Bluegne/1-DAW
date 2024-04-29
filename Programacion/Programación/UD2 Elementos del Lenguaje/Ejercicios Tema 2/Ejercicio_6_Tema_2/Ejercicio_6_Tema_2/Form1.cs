using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //TODO Realizar un programa que lea el valor de dos variables de
        //tipo entero y muestre por pantalla con un MessageBox el
        //valor de la división entera y del resto de la división entera.

        private void tNum1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tNum2_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void bMostrarResultado_Click(object sender, EventArgs e)
        {
            int num1, num2, resDivision, resRestante;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);
            resDivision = num1 / num2;
            resRestante = num1 % num2;

            MessageBox.Show("El resultado de la división es: " + resDivision.ToString() + " y el resto es: " + resRestante.ToString());
        }
    }
}
