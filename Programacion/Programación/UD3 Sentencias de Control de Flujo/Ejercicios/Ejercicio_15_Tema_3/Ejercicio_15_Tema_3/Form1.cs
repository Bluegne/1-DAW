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

namespace Ejercicio_15_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMayMen_Click(object sender, EventArgs e)
        {
            int num, mayor, menor;
            num = int.Parse(Interaction.InputBox("Introduzca un número", "Ejercicio 15"));
            mayor = num;
            menor = num;

            if (num <= 0)
            {
                MessageBox.Show("Error, el número introducido no puede ser negativo");
            }
            else
            {
                while (num > 0)
                {
                    if (num > mayor)
                    {
                        mayor = num;
                    }
                    if (num < menor)
                    {
                        menor = num;
                    }
                    num = int.Parse(Interaction.InputBox("Introduzca un número", "Ejercicio 15"));
                }
                MessageBox.Show("El mayor es " + mayor + " y el menor es " + menor);
            }
           
        }
    }
}
