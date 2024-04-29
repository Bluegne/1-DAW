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

namespace Ejercicio_07_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numbers = new int[10];
        void ReadArray(int[] numbers)
        {
            int aux = 0;
            int i = 1;
            numbers[0] = int.Parse(Interaction.InputBox("Introduce elemento de la posición " + i, "Ejercicio 07"));
            while (i < numbers.Length)
            {
                aux = int.Parse(Interaction.InputBox("Introduce elemento de la posición " + i, "Ejercicio 07"));
                if (aux <= numbers[i - 1])
                {
                    MessageBox.Show("El número introducido debe ser mayor al anterior");
                }
                else
                {
                    numbers[i] = aux;
                    i++;
                }
            }
        }

        string ShowArray(int[] numbers)
        {
            string msg = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                msg += numbers[i] + " | ";
            }
            return msg;
        }
        private void btnReadNum_Click(object sender, EventArgs e)
        {
            ReadArray(numbers);
        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            string msg = ShowArray(numbers);
            MessageBox.Show("Los elementos del array son: " + msg);
        }
    }
}
