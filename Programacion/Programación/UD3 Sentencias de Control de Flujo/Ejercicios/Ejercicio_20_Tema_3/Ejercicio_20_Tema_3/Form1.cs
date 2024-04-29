using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_20_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPotencia_Click(object sender, EventArgs e)
        {
            int exponenteUsuario = int.Parse(txtNumUsuario.Text);
            int baseUsuario = int.Parse(txtBaseUsuario.Text);
            int resultado = 1;

            for (int i = 1; i <= exponenteUsuario; i++)
            {
                resultado = resultado * baseUsuario;
            }
            MessageBox.Show(resultado.ToString());

        }
    }
}
