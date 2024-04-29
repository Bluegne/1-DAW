using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isDivisible(int num1, int num2)
        {
            bool res;
            if (num1 % num2 == 0) 
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            bool res = isDivisible(num1, num2);

            if (res == true)
            {
                MessageBox.Show("Number " + num1 + " is divisible by number " + num2);
            }
            else
            {
                MessageBox.Show("Number " + num1 + " is not divisible by number " + num2);
            }
        }
    }
}
