using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_21_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarFor_Click(object sender, EventArgs e)
        {
            int numUsuario;
            string texto = "";

            numUsuario = int.Parse(txtNumUsuario.Text);

            if (numUsuario > 0 && numUsuario <= 15)
            {
                for (int i = 1; i <= numUsuario; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        texto += j + ", ";
                    }
                    texto += "\n";
                }
                MessageBox.Show(texto);
            }
            else 
            {
                MessageBox.Show("Error");
            }
        }

        private void btnMostrarWhile_Click(object sender, EventArgs e)
        {
            int i, j, numUsuario;
            i = 1;
            j = 1;
            string texto = "";

            numUsuario = int.Parse(txtNumUsuario.Text);

            if (numUsuario > 0 && numUsuario <= 15)
            {
                while (i <= numUsuario)
                {
                    j = 1;
                    while (j <= 10)
                    {
                        texto += j + ", ";
                        j++;
                    }
                    texto += "\n";
                    i++;
                }
                MessageBox.Show(texto);
            }
        }
    }
}
