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
    public partial class fCirculo : Form
    {
        List<Figura> listaFiguras; //puntero 
        public fCirculo(List<Figura> listaFiguras)
        {
            InitializeComponent();
            this.listaFiguras = listaFiguras;
        }

        private void btnAnyadirCirculo_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            int radio = int.Parse(txtRadio.Text);
            string color = txtColor.Text;

            //TODO crear un círculo
            Circulo circulo = new Circulo(posX, posY, color, radio);

            //TODO agregar objeto a la lista de figuras
            listaFiguras.Add(circulo);
            MessageBox.Show("** Círculo agregado correctamente **");
            //TODO cerrar el formulario después de darle clic al botón
            DialogResult agregarMas;
            agregarMas = MessageBox.Show("Desea agregar otro círculo?", "", MessageBoxButtons.YesNo);
            if (agregarMas == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
