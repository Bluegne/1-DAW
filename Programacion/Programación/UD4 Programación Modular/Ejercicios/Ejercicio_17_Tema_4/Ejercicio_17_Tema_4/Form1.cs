using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_17_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CalcDivEntera(int num1, int num2)
        {
            int contador = 0;
            while (num1 > 0 && num2 < num1)
            { 
                num1 = num1 - num2;
                contador++;
            }
            return contador;
        }
        private void btnCalcDivEntera_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int contador = CalcDivEntera(num1,num2);
            MessageBox.Show(contador.ToString());
        }
    }
}
