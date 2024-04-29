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

namespace Ejercicio_17_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arrayNums = new int[10];

        void ReadArray(int[] arrayNums) 
        {
            for(int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = int.Parse(Interaction.InputBox("Introduce elemento " + i, "Ejercicio 17"));
            }
        }

        int SearchValueFirstPosition(int[] arrayNums, int userAnswer) 
        {
            int valuefirstPosition = -1;
            bool found = false;
            for (int i = 0; i < arrayNums.Length && !found; i++)
            {
                if (arrayNums[i] == userAnswer)
                {
                    valuefirstPosition = i;
                    found = true;
                }
            }
            return valuefirstPosition;
        }

        void ArrangeValueInDescendingOrder(int[] arrayNums)
        {
            int aux = 0;
            for (int i = 0; i < arrayNums.Length - 1; i++)
            {
                for (int j = i+1; i < arrayNums.Length; i++)
                {
                    if (arrayNums[j] > arrayNums[i])
                    {

                    }
                }
            }

        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadArray(arrayNums);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int userAnswer = int.Parse(Interaction.InputBox("Que elemento quieres buscar?"));
            int valuePosition = SearchValueFirstPosition(arrayNums, userAnswer);
            if (valuePosition != -1)
            {
                MessageBox.Show("El elemento indicado ha sido encontrado en la posición " + valuePosition + " del array");
            }
            else
            {
                MessageBox.Show("El elemento indicado no existe dentro del array");
            }
        }


        private void btnOrganize_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
             
        }
    }
}
