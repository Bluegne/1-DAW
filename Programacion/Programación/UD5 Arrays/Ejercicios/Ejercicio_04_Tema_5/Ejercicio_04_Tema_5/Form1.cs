using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_04_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int SIZE = 5;
        int []array = new int[SIZE];    
        void ReadNum(int []array)
        {
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Introduce 10 números", "Ejercicio 04"));
            }
        }

        int cambiarValor(int[] array)
        {
            int acum = 0;
            for (int i = 0; i < SIZE; i++)
            {
                if (array[i] < 0)
                    acum++;
                else
                    array[i] = 0;
            }
            return acum;
        }

        string MostrarArray (int[]array)
        {
            string res = "";
            for (int i = 0; i < SIZE; i++)
            {
                res = res + array[i] + ", ";
            }
            return res;
        }
        private void btnReadNum_Click(object sender, EventArgs e)
        {
            ReadNum(array);
        }

        private void btnNegativeNum_Click(object sender, EventArgs e)
        {
            string res = MostrarArray(array);
            int total = cambiarValor(array);

            MessageBox.Show("El número de negativos es de " + total);
            MessageBox.Show("El array quedaría de la siguiente manera: " + res);
        }

    }
}
