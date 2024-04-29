using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int result, num1, num2, i;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            result = 0;
            i = 1;

            if (num1 > 0)
            {
                for (i = 1; i <= num1; i++)
                {
                    result = result + num2;
                }
            }
            else 
            {
                for (i = -1; i >= num1 ; i--)
                {
                    result = result - num2;
                }
            }
            MessageBox.Show("El resultado es " + result);
        }
    }
}
