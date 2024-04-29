using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_13_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarWhile_Click(object sender, EventArgs e)
        {
           int numUsuario = int.Parse(txtNumUsuario.Text);
           int i = 2;
           string texto = "";

            while(i < numUsuario)
            {
                i = i + 2;
                if (i < numUsuario)
                {
                    texto = texto + i + ", ";
                }
                else 
                {
                    texto = texto + i + ".";
                }
            }
            MessageBox.Show("Los números pares son: " + texto);
        }

        private void btnMostrarDoWhile_Click(object sender, EventArgs e)
        {
            int numUsuario = int.Parse(txtNumUsuario.Text);
            int i = 2;
            string texto = "";

            do
            {
                i = i + 2;
                if (i < numUsuario)
                {
                    texto = texto + i + ", ";
                }
                else
                {
                    texto = texto + i + ".";
                }
            }
            while (i < numUsuario);

            MessageBox.Show("Los números pares son: " + texto);
        }

        private void btnMostrarFor_Click(object sender, EventArgs e)
        {
            int numUsuario = int.Parse(txtNumUsuario.Text);
            string texto = "";

            for(int i = 2; i <= numUsuario; i = i + 2)
            {
                if (i < numUsuario)
                {
                    texto = texto + i + ", ";
                }
                else
                {
                    texto = texto + i + ".";
                }
            }
            MessageBox.Show("Los números pares son: " + texto);
        } 
    }
}
