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

namespace Ejercicio_02_Tema_05
{
    public partial class Form1 : Form
    {
        const int SIZE = 10;       
        int [] array = new int[SIZE]; 
        void ReadArray (int[] array)
        {
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Introduce número " + i, "Ejercicio 02"));
            }
        }

        double CalcularMedia(int[] array)
        {
            double media = 0;
            int sum = 0;

            for (int i = 0; i < SIZE; i++)
            {
                sum += array[i];
            }
            media = (double) sum / SIZE;
            return media;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadArray(array);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double media = CalcularMedia(array);
            MessageBox.Show("La media es de: " + media);
        }
    }
}
