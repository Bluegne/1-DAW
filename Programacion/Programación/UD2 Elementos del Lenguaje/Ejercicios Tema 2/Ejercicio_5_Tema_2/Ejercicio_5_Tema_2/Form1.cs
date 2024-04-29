using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSuma_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;
            //TODO rellenar variables con respuesta usuario y convertir a entero usando .Parse
            try
            {
                num1 = int.Parse(tNumero1.Text);
                num2 = int.Parse(tNumero2.Text);
                suma = num1 + num2;

                //TODO mostrar resultado suma en caja de resultado conviertiendo a string
                tResultado.Text = suma.ToString();
            }
            catch (FormatException fEX)
            {
                MessageBox.Show("Se ha producido el error: " + fEX.Message);
            }

        }

        private void bResta_Click(object sender, EventArgs e)
        {
            int num1, num2, resta;
            //TODO rellenar variables con respuesta usuario y convertir a entero usando .Parse
            try
            {
                num1 = int.Parse(tNumero1.Text);
                num2 = int.Parse(tNumero2.Text);
                resta = num1 - num2;
            
            //TODO mostrar resultado resta en caja de resultado conviertiendo a string
            tResultado.Text = resta.ToString();
            }
            catch (FormatException fEX)
            {
                MessageBox.Show ("Se ha producido el error: " + fEX.Message);
            }
        }
    }
}
