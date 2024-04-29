using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bSuma_Click_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;
            num1 = 5; num2 = 3;
            suma = num1 + num2;

            MessageBox.Show(suma.ToString());
        }
    }
}
