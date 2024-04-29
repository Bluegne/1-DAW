using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class fCuadrado : Form
    {
        List<Figura> listaFiguras; //puntero que apunta a la listaFiguras que creamos en el formulario inicial

        //TODO constructor del formulario
        public fCuadrado(List<Figura> listaFiguras)
        {
            InitializeComponent();
            this.listaFiguras = listaFiguras;
        }
        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            int lado = int.Parse(txtLado.Text);
            string color = txtColor.Text;

            //TODO crear un cuadrado
            Cuadrado cuadrado = new Cuadrado(posX, posY, color, lado);

            //TODO agregar objeto a la lista de figuras
            listaFiguras.Add(cuadrado);
            MessageBox.Show("** Cuadrado agregado correctamente **");

            DialogResult agregarMas;
            agregarMas = MessageBox.Show("Desea agregar otro cuadrado?", "", MessageBoxButtons.YesNo);
            if (agregarMas == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
