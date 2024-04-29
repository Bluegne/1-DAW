using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaEmpleados empresa = new ListaEmpleados();

        private void bNuevo_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad;

            nombre = Interaction.InputBox("Introduzca el nombre.");
            edad = int.Parse(Interaction.InputBox("Introduzca la edad."));

            empresa.AnyadirEmpleado(nombre, edad);
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            string texto;

            texto = empresa.MostrarListaEmpleados();

            MessageBox.Show(texto);
        }

        private void bAnyadir_Click(object sender, EventArgs e)
        {
            string nombre;
            double venta;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre.");
            venta = double.Parse(Interaction.InputBox("Introduzca la venta."));

            correcto = empresa.AnyadirVenta(nombre, venta);
            if (correcto)
                MessageBox.Show("Se ha añadido correctamente la venta.");
            else
                MessageBox.Show("No se ha encontrado el empleado.");
        }

        private void bCumpleaños_Click(object sender, EventArgs e)
        {
            string nombre;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre.");

            correcto = empresa.Cumpleanyos(nombre);

            if (!correcto)
                MessageBox.Show("No se ha encontrado el empleado.");
        }
    }
}
