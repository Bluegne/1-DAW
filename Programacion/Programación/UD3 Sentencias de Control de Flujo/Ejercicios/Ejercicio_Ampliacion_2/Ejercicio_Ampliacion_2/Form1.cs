using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Ampliacion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPrimeNumbers_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            result = 0;

            if (num1 > 0)
            {
                if (num1 > num2) 
                {
                    MessageBox.Show("Error, number 1 must be less that number 2");
                }
            else
                {
                    for (int i = 1; i <= num2; i++)
                    {
                        result = result +  
                    }
                }
            } MessageBox.Show("The prime numbers between" + num1 + "and " + num2 + "are: " + result);
        }
    }
}
