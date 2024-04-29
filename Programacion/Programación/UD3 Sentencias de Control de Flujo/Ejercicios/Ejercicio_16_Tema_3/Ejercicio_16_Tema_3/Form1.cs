using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_16_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarSuma_Click(object sender, EventArgs e)
        {
            double num, suma;
            suma = 0;
            num = double.Parse(Interaction.InputBox("Introduzca un número, Ejercicio 16"));

            while (num >= 0 && num <= 9)
            {
                suma = suma + num;
                num = double.Parse(Interaction.InputBox("Introduzca un número, Ejercicio 16"));
            }
            MessageBox.Show("La suma es de " + suma);
        }
    }
}
