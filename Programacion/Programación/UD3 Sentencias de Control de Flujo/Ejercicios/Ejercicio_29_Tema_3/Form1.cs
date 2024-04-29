using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_29_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double userNumber, number, result;
            number = 1;
            userNumber = double.Parse(txtUserNumber.Text);
            result = 0;

            if (userNumber > 0)
            {
                for (int i = 1; i <= userNumber; i++)
                {
                    if (i % 2 == 0)
                    {
                        result = result + (number / i);
                    }
                    else
                    {
                        result = result - (number / i);
                    }
                }
                MessageBox.Show("Result: " + result);
            }
            
        }
    }
}
