using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_15_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void calcularCantidadDinero(ref double valorUsuario, double cantidad, ref string result)
        {
            int efectivo = (int) (valorUsuario / cantidad);
            if (efectivo >= 1)
            {
                if (cantidad >= 5)
                {
                    result = result + efectivo + " billetes de " + cantidad + " euros " +"\n";
                }
                if (cantidad >= 1 && cantidad <= 5)
                {
                    result = result + efectivo + " monedas de " + cantidad + " euros " + "\n";
                }
                if (cantidad < 1)
                {
                    result = result + efectivo + " moneda de " + (cantidad * 100) + " céntimos " + "\n";
                }
                valorUsuario = valorUsuario - efectivo * cantidad;
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double valorUsuario = double.Parse(txtAmount.Text);
            string result = "";
            if (valorUsuario > 0)
            {
                calcularCantidadDinero(ref valorUsuario, 500, ref result);
                calcularCantidadDinero(ref valorUsuario, 200, ref result);
                calcularCantidadDinero(ref valorUsuario, 100, ref result);
                calcularCantidadDinero(ref valorUsuario, 50, ref result);
                calcularCantidadDinero(ref valorUsuario, 20, ref result);
                calcularCantidadDinero(ref valorUsuario, 10, ref result);
                calcularCantidadDinero(ref valorUsuario, 5, ref result);
                calcularCantidadDinero(ref valorUsuario, 2, ref result);
                calcularCantidadDinero(ref valorUsuario, 1, ref result);
                calcularCantidadDinero(ref valorUsuario, 0.50, ref result);
                calcularCantidadDinero(ref valorUsuario, 0.20, ref result);
                calcularCantidadDinero(ref valorUsuario, 0.10, ref result);
                calcularCantidadDinero(ref valorUsuario, 0.05, ref result);
                calcularCantidadDinero(ref valorUsuario, 0.02, ref result);
                calcularCantidadDinero(ref valorUsuario, 0.01, ref result);
                lblMostrarEfectivo.Text = result;
            }
            else
            {
                MessageBox.Show("Error, la cantidad a ingresar debe ser mayor a 0");
            } 
        }
    }
}
