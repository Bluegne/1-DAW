using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Ampliacion_1_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool FindNoPrimeNumber (int num)
        {
            bool esNoPrimo = false;
            for (int i = 2; i < num && esNoPrimo == false; i++)
            {
                if (num % i == 0)
                {
                    esNoPrimo = true;
                }
            }
            return esNoPrimo;
        }

        string ShowPrimeNumbers(int num, string result)
        {
            for (int i = 2; i < num; i = i + 1)
            {
                bool isPrime = FindNoPrimeNumber(i);
                if (isPrime == true)
                {
                    result = result + i;
                    result = result + " , ";
                }
            }
            return result;
        }
        private void btnCalculatePrimeNumber_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumber.Text);    
            bool validNoPrime = FindNoPrimeNumber(num);

            if (validNoPrime == true)
            {
                MessageBox.Show("No es primo");
            }
            else
            {
                MessageBox.Show("Es primo");
            }
        }
    }
}
