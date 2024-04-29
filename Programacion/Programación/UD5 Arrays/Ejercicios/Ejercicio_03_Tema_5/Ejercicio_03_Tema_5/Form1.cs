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
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio_03_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int SIZE = 5;
        // cuando se declara un array, se debe declarar tambien el tamaño para poder utilizarla
        int[] array = new int[SIZE];

        void ReadArray(int[] array)
        {
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Introduce números ", "Ejercicio 03"));
            }
        }

        string ShowArray(int[] array)
        {
            string text = "Los números son: ";
            for (int i = 0; i < SIZE; i++)
            {
                text = text + array[i] + ", ";
            }
            return text;
        }

        int CalcularMenor(int[]array)
        {
            // menor = núm colocado en la posición 0 del array porque consideramos que sera el menor la primera vez
            int menor = array[0]; 
            for (int i = 1; i < SIZE; i++)
            {
                // al inicio del bucle, núm colocado en la posición [1] --> (i) del array es <  núm de la posición [0]? 
                if (array[i] < menor) 
                {
                    menor = array[i];
                }
            }
            return menor;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadArray(array);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string text = ShowArray(array);
            MessageBox.Show("Los números son: " + text);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int menor = CalcularMenor(array);
            MessageBox.Show("El número menor es " +  menor);
        }
    }
}
