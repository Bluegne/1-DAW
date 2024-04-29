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

namespace Ejercicio_08_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array = new int[10];

        void ReadArray(int[] array)
        {
            int i = 0;
            int aux = 0;
            while (i < array.Length)
            {
                aux = int.Parse(Interaction.InputBox("Introduce el elemento de la posición " + i, "Ejercicio 08"));
                if (aux > 0)
                {
                    array[i] = aux; 
                    i++;
                }
                else
                {
                    MessageBox.Show("El número introducido debe ser positivo");
                }
            }
        }

        void ChangeArray(int[] array, out int acum) 
        {
            acum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != -1)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            array[j] = -1;
                            acum++;
                        }
                    }
                }
            }
        }

        string ShowArray(int[] array)
        {
            string msg = "";
            for (int i = 0; i < array.Length; i++)
            {
                msg += array[i] + " | ";
            }
            return msg;
        }

        private void btnReadArray_Click(object sender, EventArgs e)
        {
            ReadArray(array);
        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            ChangeArray(array, out int acum);
            string msg = ShowArray(array);
            MessageBox.Show(msg + "\n" + "La cantidad de valores modificados es de " + acum);
        }
    }
}
