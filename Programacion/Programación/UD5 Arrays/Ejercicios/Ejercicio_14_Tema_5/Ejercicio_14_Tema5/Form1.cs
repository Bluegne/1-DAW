using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_14_Tema5
{ 
    public partial class Form1 : Form
    {   //revisar y arreglar ejercicio
        public Form1()
        {
            InitializeComponent();
        }
        const int SIZE = 10;
        int[] array = new int[10];

        void ReadTemperature(int[] temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = int.Parse(Interaction.InputBox("Introduzca temperatura del elemento " + i , "Ejercicio 14"));
            }
        }

        double CalcTempMedia(int[] temp)
        {
            double counter = 0;
            double media = 0;
            for(int i =  0; i < temp.Length; i++)
            {
                counter += temp[i];
            }
            return media = (double)counter / SIZE; ;
        }

        string ShowTempMayIgMed(int[] temp, double media)
        {
            string msg = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] >= media)
                {
                    if (temp[i] < SIZE - 1)
                    {
                        msg+= temp[i] + " | ";
                    }
                    else
                    {
                        msg+= temp[i] + " | ";
                    }
                }
            }
            return msg;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadTemperature(array);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double tempMed = CalcTempMedia(array);
            string msg = ShowTempMayIgMed(array, tempMed);
            MessageBox.Show("Temperatura media: " + tempMed + "º" + "\n" + "Temperaturas iguales o mayores que la media: " + msg);       
        }
    }
}
