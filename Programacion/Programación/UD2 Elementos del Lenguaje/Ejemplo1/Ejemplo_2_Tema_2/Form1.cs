using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tNumeroRecogido_TextChanged(object sender, EventArgs e)
        {

        }

        private void bMostrarEntero_Click(object sender, EventArgs e)
        {
            //TODO declarar variable tipo entero
            int numero;

            //TODO darle valor a variable tipo entero
            numero = 125;

            //TODO mostrar número en pantalla
            MessageBox.Show(numero.ToString());
        }

        private void bMostrarReal_Click(object sender, EventArgs e)
        {
            ////TODO declarar variables
            //double numeroDouble;

            ////TODO dar valor a variables
            //numeroDouble = 223.25;

            ////TODO mostrar por pantalla
            //MessageBox.Show(numeroDouble.ToString());

            double numeroDoble;

            numeroDoble = double.Parse(tNumeroRecogido.Text);

            MessageBox.Show(numeroDoble.ToString());
        }

        private void bMostrarFloat_Click(object sender, EventArgs e)
        {
            //TODO declarar variables
            float numeroFloat;

            //TODO dar valor a variables
            numeroFloat = 3.1416F;

            //TODO mostrar por pantalla
            MessageBox.Show(numeroFloat.ToString());
        }

        private void bValor_Click(object sender, EventArgs e)
        {
            //TODO declarar variable
            int numero;

            //TODO llenar variable y convertir a int usando parse
            numero = int.Parse(tNumeroRecogido.Text);

            //TODO mostrar número
            MessageBox.Show(numero.ToString());
        }
    }
}
