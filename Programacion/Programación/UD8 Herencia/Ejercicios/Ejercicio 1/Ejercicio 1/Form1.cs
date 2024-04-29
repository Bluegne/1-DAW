using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo(7, 13, "morado", 5);
            MessageBox.Show(circulo.ToString());
            MessageBox.Show(circulo.QuienSoy());
            MessageBox.Show("El área es de: " +  circulo.Area());
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado cuadrado = new Cuadrado(5, 10, "verde", 5);
            MessageBox.Show(cuadrado.ToString());
            MessageBox.Show(cuadrado.QuienSoy());
            MessageBox.Show("El área es de: " +  cuadrado.Area());
        }
    }
}
