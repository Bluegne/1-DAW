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

namespace Ejercicio_09_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arrayA = new int[10];
        int[] arrayB = new int[10];
        void ReadArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Introduce elemento de la posición" + i, "Ejercicio 09"));
            }
        }

        void InvertArray(int[]result, int[]arrayOrig)
        {
            for(int i = 0; i < arrayA.Length; i++)
            {
                arrayB[arrayA.Length - 1 - i] = arrayA[i];
            }
        }

        string ShowResult(int[]array)
        {
            string msg = "";
            InvertArray(arrayA, arrayB);
            for(int i = 0; i < arrayA.Length; i++)
            {
                msg += arrayB[i] + " | ";
            }
            return msg;
        }
        private void btnReadArray_Click(object sender, EventArgs e)
        {
            ReadArray(arrayA);
        }

        private void btnChangeArray_Click(object sender, EventArgs e)
        {
            string msg = ShowResult(arrayB);
            MessageBox.Show(msg);
        }
    }
}
