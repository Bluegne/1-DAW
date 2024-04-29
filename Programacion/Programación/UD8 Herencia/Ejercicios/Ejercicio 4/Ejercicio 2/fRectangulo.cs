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
    public partial class fRectangulo : Form
    {
        List<Figura> listaFiguras; //puntero que apunta a la listaFiguras que creamos en el formulario inicial

        //TODO constructor del formulario
        public fRectangulo(List<Figura> listaFiguras)
        {
            InitializeComponent();
            this.listaFiguras = listaFiguras;
        }

        private void btnCrearRectangulo_Click(object sender, EventArgs e)
        {
            double posX = double.Parse(txtPosX.Text);
            double posY = double.Parse(txtPosY.Text);
            double altura = double.Parse(txtLadoB.Text);   
            double longitud = double.Parse(txtLadoA.Text);
            string color = txtColor.Text;

            Rectangulo rectangulo = new Rectangulo(posX, posY, color, longitud, altura);
            listaFiguras.Add(rectangulo);

            MessageBox.Show("** Rectángulo agregado correctamente **");

            DialogResult agregarMas;
            agregarMas = MessageBox.Show("Desea agregar otro rectángulo?", "", MessageBoxButtons.YesNo);

            if (agregarMas == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                txtPosX.Clear();
                txtPosY.Clear();
                txtLadoB.Clear();
                txtLadoA.Clear();
                txtColor.Clear();
            }
        }
    }
}
