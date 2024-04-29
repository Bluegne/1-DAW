using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Ampliacion_2_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CalcularMenor (int num1, int num2, int num3)
        {
            int menor = 0;

            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }
            return menor;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            int menor = CalcularMenor(num1, num2, num3);
            MessageBox.Show("El número menor es " + menor);
             

        }
    }
}
