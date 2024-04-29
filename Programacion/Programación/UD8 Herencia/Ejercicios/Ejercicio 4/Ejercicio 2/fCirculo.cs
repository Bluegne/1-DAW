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
            double posX = double.Parse(txtPosX.Text);
            double posY = double.Parse(txtPosY.Text);
            double radio = double.Parse(txtRadio.Text);
            string color = txtColor.Text;

            //TODO crear un círculo
            Circulo circulo = new Circulo(posX, posY, color, radio);

            //TODO agregar objeto a la lista de figuras
            listaFiguras.Add(circulo);
            MessageBox.Show("** Círculo agregado correctamente **");

            DialogResult agregarMas;
            agregarMas = MessageBox.Show("Desea agregar otro círculo?", "", MessageBoxButtons.YesNo);

            if (agregarMas == DialogResult.No)
            {
                //TODO cerrar el formulario si la respuesta es NO
                this.Close();
            }
            else
            {
                //TODO de lo contrario, limpiar los textBox
                txtPosX.Clear();
                txtPosY.Clear();
                txtRadio.Clear();
                txtColor.Clear();
            }
        }
    }
}
