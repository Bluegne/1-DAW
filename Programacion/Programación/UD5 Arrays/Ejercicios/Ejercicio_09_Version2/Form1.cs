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

namespace Ejercicio_09_Version2
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
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Introduce elemento de la posición" + i, "Ejercicio 09"));
            }
        }

        void InvertArray(int[] array)
        {
            int aux = 0;
            for (int i = 0; i < array.Length; i++)
            {

            }
        }

        string ShowResult(int[] array)
        {
            string msg = "";
            InvertArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                msg += array[i] + " | ";
            }
            return msg;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadArray(array);
        }

        private void btnShowRes_Click(object sender, EventArgs e)
        {
            string msg = ShowResult(array);
            MessageBox.Show(msg);
        }
    }
    
}
