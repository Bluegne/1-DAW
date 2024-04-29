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

namespace Ejercicio_13_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array = new int[10];

        void ReadNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Interaction.InputBox("Introduzca 10 números", "Ejercicio 13"));
            }
        }
        bool DataExistInArray(int[] numbers)
        {
            bool existInArray = false;
            int userNumbers = int.Parse(Interaction.InputBox("Introduzca números", "Ejercicio 13"));
            for (int i = 0; i < numbers.Length && !existInArray; i++)
            {
                if (userNumbers == numbers[i])
                {
                    existInArray = true;
                }
            }
            return existInArray;
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadNumbers(array);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bool numExists = DataExistInArray(array);
            if (!numExists) 
            {
                MessageBox.Show("El dato introducido no existe");
            }
            else
            {
                MessageBox.Show("El dato introducido si existe");
            }
        }
    }
}
