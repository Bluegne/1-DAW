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

namespace Ejercicio_06_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int SIZE = 10;
        int[] numbersA = new int[SIZE];
        int[] numbersB = new int[SIZE];

        void ReadNumbers(int[] array)
        {
            for (int i = 0; i < SIZE; i++) 
            {
                array[i] = int.Parse(Interaction.InputBox("Introduce el número de la posición " + i, "Ejercicio 06"));
            }
        }

        bool CompareNumbers(int[] numbersA, int[] numbersB)
        {
            bool equalNum = true;
            for (int i = 0; i < SIZE && equalNum; i++)
            {
                if (numbersA[i] != numbersB[i])
                    equalNum = false;
            }
            return equalNum;
        }

        private void btnReadNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Introduce los elementos del array 1");
            ReadNumbers(numbersA);
            MessageBox.Show("Introduce los elementos del array 2");
            ReadNumbers(numbersB);
        }

        private void btnShowRes_Click(object sender, EventArgs e)
        {
            bool equalNum = CompareNumbers(numbersA, numbersB);
            if (equalNum ==  false)
                MessageBox.Show("Los elementos son distintos");
            else
                MessageBox.Show("Los elementos son iguales");

        }
    }
}
