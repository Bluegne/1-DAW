using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_12_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarWhile_Click(object sender, EventArgs e)
        {
            int i, numUsuario;
            numUsuario = int.Parse(txtNumUsuario.Text);
            string texto;

            texto = ""; 

            i = 1;
            while (i <= numUsuario)
            {
                if (i < numUsuario)
                {
                    texto = texto + i++ + ", ";
                }
                else
                {
                    texto = texto + i++ + ".";
                }
            }
            MessageBox.Show("Los números introducidos son: " + texto);
        }

        private void btnMostrarDoWhile_Click(object sender, EventArgs e)
        {
            int i, numUsuario;
            numUsuario = int.Parse(txtNumUsuario.Text);
            string texto;

            texto = "";
            i = 1;

            do
            {
                if (i < numUsuario)
                {
                    texto = texto + i++ + ", ";
                }
                else
                {
                    texto = texto + i++ + ".";
                }
            }
            while (i <= numUsuario);
            MessageBox.Show("Los números introducidos son: " + texto);
        }

        private void btnMostrarFor_Click(object sender, EventArgs e)
        {
            int numUsuario;
            numUsuario = int.Parse(txtNumUsuario.Text);
            string texto;

            texto = "";

            for (int i = 1; i <= numUsuario; i++)
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
            MessageBox.Show("Los números introducidos son: " + texto);
        }
    }
}
