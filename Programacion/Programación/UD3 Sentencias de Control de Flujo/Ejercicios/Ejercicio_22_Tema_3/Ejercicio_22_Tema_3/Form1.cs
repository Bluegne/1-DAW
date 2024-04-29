using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_22_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int numSerie = int.Parse(txtNumSerie.Text);

            if (numSerie >= 14681 && numSerie <= 15681 || numSerie >= 70001 && numSerie <= 79999 || numSerie >= 88888 && numSerie <= 111111)
            {
                MessageBox.Show("El artículo esta defectuoso");
            }
            else
            {
                MessageBox.Show("El artículo funciona correctamente");
            }
           
                //OPCION 2
                
                
            if (numSerie > 0 && numSerie <= 14680)
            {
                MessageBox.Show("El artículo funciona correctamente");
            }
            else if (numSerie >= 14681 && numSerie <= 15681)
            {
                MessageBox.Show("El artículo esta defectuoso");
            }
            else if (numSerie >= 15682 && numSerie <= 70001)
            {
                MessageBox.Show("El artículo funciona correctamente");
            }
            else if (numSerie >= 70001 && numSerie <= 79999)
            {
                MessageBox.Show("El artículo esta defectuoso");
            }
            else if (numSerie >= 80000 && numSerie <= 88887)
            {
                MessageBox.Show("El artículo funciona correctamente");
            }
            else if (numSerie >= 88888 && numSerie <= 111111)
            {
                MessageBox.Show("El artículo esta defectuoso");
            }
            else if (numSerie >= 111112)
            {
                MessageBox.Show("El artículo funciona correctamente");
            }
        }
    }
}
