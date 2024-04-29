using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bResultado_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, num3, suma, mult;

                num1 = int.Parse(tNum1.Text);
                num2 = int.Parse(tNum2.Text);
                num3 = int.Parse(tNum3.Text);

                suma = num1 + num2 + num3;
                mult = num1 * num2 * num3;

                MessageBox.Show("El resultado de la suma es " + suma + " y el de la multiplicación es " + mult);
            }
            catch (FormatException excepcion)
            {
                MessageBox.Show("Se ha producido el error: " + excepcion.Message);
            }
            
        }
    }
}
