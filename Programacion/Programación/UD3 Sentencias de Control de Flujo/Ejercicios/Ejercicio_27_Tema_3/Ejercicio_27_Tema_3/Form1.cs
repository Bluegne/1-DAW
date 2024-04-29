using System;
using System.Windows.Forms;

namespace Ejercicio_27_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numUsuario = int.Parse(txtNumUsuario.Text);
            bool encontrado = false;
            
            if (numUsuario > 1)
            {
                for (int i = 2; i <= numUsuario / 2 && encontrado == false; i++)
                {
                    if (numUsuario % i == 0)
                    {
                        encontrado = true;
                    }
                    if (encontrado == false)
                    {
                        MessageBox.Show("Es primo");
                    }
                    else
                    {
                        MessageBox.Show("No es primo");
                    }
                }
            }
            else
            {
                MessageBox.Show("No es Primo");
            }
        }
    }
}
