using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bResultado_Click(object sender, EventArgs e)
        {
            //TODO Realizar un programa que lea la altura en cms de
            //un individuo y muestre, en un label, cuántos metros y cms tiene.
            //(185 -> 1 metro, 85 cms. 205-> 2 metros 5 cms.).
            //Utilizar try – catch para la introducción del número.

            try
            {
                int altura, metros, centimetros;
                altura = int.Parse(tAltura.Text);

                metros = altura / 100;
                centimetros = altura % 100;

                lMuestraAltura.Text = "Su altura es de " + metros + " metros " + centimetros + " centimetros";
            }
            catch (FormatException fFE)
            {
;                MessageBox.Show("Se ha producido el error " + fFE.Message);
            }
        }
    }
}
