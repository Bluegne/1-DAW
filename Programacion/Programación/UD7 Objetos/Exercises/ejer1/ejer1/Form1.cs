using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int SIZE = 20;
        string[] arrayPalabras = new string[SIZE];
        string[] arrayRepetidos = { "pepe", "juan", "juan", "marta", "marta", "marta", "paloma"};
        string[] arrayPalabrasRepetidas = new string[SIZE];
        private void button1_Click(object sender, EventArgs e)
        {
            //TODO copiar a arrayPa
            string[] ComprobarPalRepetidas(string[] arrayRepetidos, string[] arrayPalabrasRepetidas)
            {
                int i = 0;
                while (i < SIZE)
                {
                    string palabra = arrayRepetidos[i];
                    while (palabra == arrayRepetidos[i])
                    {
                        if(palabra == arrayRepetidos[i])
                        {
                            arrayPalabrasRepetidas 
                        }
                    }
                }
                return arrayPalabrasRepetidas;
            }
        }
    }
}
