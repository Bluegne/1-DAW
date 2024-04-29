using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_14_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {

            int resultadoSuma = 0;

            for (int i = 1; i <= 10; i++)
            {
                resultadoSuma = resultadoSuma + i;
            }
            MessageBox.Show("El resultado de la suma es: " + resultadoSuma);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 1;
            int resultadoSuma = 0;

            while (i <= 10)
            {
                resultadoSuma = resultadoSuma + i;
                i++;
            }
            MessageBox.Show("El resultado de la suma es: " + resultadoSuma);
        }
    }
}
