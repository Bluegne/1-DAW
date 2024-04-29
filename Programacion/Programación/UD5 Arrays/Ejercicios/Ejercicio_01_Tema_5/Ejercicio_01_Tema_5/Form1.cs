using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int SIZE = 10;
        int[] array = new int[SIZE];

        void ReadArray(int[] array)
        {
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Introduzca número: " + i));
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
        private void btnLeer_Click(object sender, EventArgs e)
        {
            ReadArray(array);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string text = ShowArray(array);
            MessageBox.Show(text);
        }
    }
}
