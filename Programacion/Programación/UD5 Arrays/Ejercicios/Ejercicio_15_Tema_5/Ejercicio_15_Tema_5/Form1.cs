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

namespace Ejercicio_15_Tema_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[20];
        void Read(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Interaction.InputBox("Introduce el elemento " + i , "Ejercicio 15"));
            }
        }

        void CalcMinMax(int[] num, out int min, out int max, out int countMin, out int countMax)
        {
            min = max = num[0];
            countMin = countMax = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }

                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] == min)
                {
                    countMin++;
                }
                else if (num[i] == max)
                {
                    countMax++;
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Read(num);
        }

        private void btnShowRes_Click(object sender, EventArgs e)
        {
            int min, max, countMin, countMax;
            CalcMinMax(num, out min, out max, out countMin, out countMax);
            MessageBox.Show("El mínimo es " + min + " y se repite " + countMin + " veces" + "\n" + "El máximo es " + max + " y se repite " + countMax + " veces");
        }
    }
}
