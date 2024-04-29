using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_05_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int SIZE = 5;
        double[] numbersA = new double[SIZE];
        double[] numbersB = new double[SIZE];
        double[] sum = new double[SIZE];
        void ReadNumbers(double[] array)
        {
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = double.Parse(Interaction.InputBox("Introduce elemento de la casilla " + i, "Ejercicio 05"));
            }
        }

        void SumNumbers(double[] numbersA, double[] numbersB, double[] sum)
        {
            for (int i = 0; i < SIZE; i++)
            {
                sum[i] = numbersA[i] + numbersB[i];
            }
        }

        string ShowSum(double[] array)
        {
            string sumRes = "";

            for (int i = 0; i < SIZE; i++)
            {
                sumRes = sumRes + array[i] + " | ";
            }
            return sumRes;
        }
        private void btnReadA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Introduce los elementos del primer array");
            ReadNumbers(numbersA);
            MessageBox.Show("Ahora introduce los elementos del segundo array");
            ReadNumbers(numbersB);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            SumNumbers(numbersA, numbersB, sum);
            string sumRes = ShowSum(sum);
            MessageBox.Show("Total suma arrays: " + sumRes);
        }
    }
}
