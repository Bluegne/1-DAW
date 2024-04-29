using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int calcMaxComunDivisor (int num1, int num2)
        {
            int division = 0;
            int result = 0;
            for (int i = 1; i <= num1; i = i + 1)
            {
                division = division + (num1 % i);
                if (division == 0)
                {

                }
                
            }
            return division;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int result = 0;
        }
    }
}
