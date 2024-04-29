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

namespace Ejercicio_12_Tema_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array = new int[24];

        void ReadTemperature(int[] temp)
        {
            for (int i = 0; i < temp.Length; i++) 
            {
                temp[i] = int.Parse(Interaction.InputBox("Ingrese temperatura", "Ejercicio 12"));
            }
        }

        void CalcTempMaxMinMed(int[] temp, out int min, out int max, out double med)
        {
            min = temp[0];
            max = temp[0];
            int counter = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < min)
                {
                    min = temp[i];
                }
                if (temp[i] > max)
                {
                    max = temp[i];
                }
                counter += temp[i];
            }
            med = (double)counter/ temp.Length;
        }
        private void button1_Click(object sender, EventArgs e) // Aquí no me fije que no cambie el nombre del botón, debería llamarse btnRead
        {
            ReadTemperature(array);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int min, max;
            double med;
            CalcTempMaxMinMed(array, out min, out max, out med);
            MessageBox.Show("Temperatura mínima: " + min  + "º" + "\n" + "Temperatura máxima: " + max + "º" + "\n" + "Temperatura media: " + med + "º");
        }
    }
}
