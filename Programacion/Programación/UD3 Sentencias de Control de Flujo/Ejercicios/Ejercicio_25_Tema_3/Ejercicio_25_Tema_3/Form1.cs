using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_25_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            //TODO crear programa que muestre las tablas de multiplicar del 1 al 10 
            int result;
            result = 0;
            string text = "";

            //TODO recoger numero a multiplicar (i)
            for(int i = 1; i <= 10; i++)
            {
                //TODO recoger numero multiplicador (j)
                for(int j = 1; j <= 10; j++)
                {
                    //TODO recoger resultado de i * j
                    result = i * j;
                    text += + i + " * " + j + " = " + result + "\n";
                }
                //TODO mostrar resultado en message box usando variable text
                MessageBox.Show(text);
                //TODO vaciar variable text para mostrar siguiente resultado en otro message box 
                text = "";
            }
        }
    }
}
