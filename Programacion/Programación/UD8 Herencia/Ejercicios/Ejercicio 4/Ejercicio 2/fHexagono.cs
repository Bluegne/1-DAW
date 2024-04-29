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
    public partial class fHexagono : Form
    {
        List<Figura> listaFiguras;
        public fHexagono(List<Figura> listaFiguras)
        {
            InitializeComponent();
            this.listaFiguras = listaFiguras;
        }

        private void btnCrearHexagono_Click(object sender, EventArgs e)
        {
            double posX = double.Parse(txtPosX.Text);
            double posY = double.Parse(txtPosY.Text);
            double lado = double.Parse(txtLado.Text);
            string color = txtColor.Text;

            Hexagono hexagono = new Hexagono(posX, posY, color, lado);

            listaFiguras.Add(hexagono);
            MessageBox.Show("** Hexágono agregado correctamente **");

            DialogResult agregarMas;
            agregarMas = MessageBox.Show("Desea agregar otro hexágono?", "", MessageBoxButtons.YesNo);

            if (agregarMas == DialogResult.No)
            {

                this.Close();
            }
            else
            {
                txtPosX.Clear();
                txtPosY.Clear();
                txtLado.Clear();
                txtColor.Clear();
            }
        }
    }
}
