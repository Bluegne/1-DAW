using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool validarNota (double notaA, double notaB, double notaC)
        {
            bool valid = false;
            if (notaA <= 10 && notaB <= 10 && notaC <= 10 && notaA > 0 && notaB > 0 && notaC > 0)
            {
                valid = true;
            }
            return valid;
        }
        double calcNotaMedia (double notaA, double notaB, double notaC)
        {
            double sumaNotas = notaA + notaB + notaC;
            double notaMedia = sumaNotas / 3;
            return notaMedia;
        } 
        private void btnCalcMedia_Click(object sender, EventArgs e)
        {
            double notaA, notaB, notaC, notaMedia;
            bool valid;
            notaA = double.Parse(txtNotaA.Text);
            notaB = double.Parse(txtNotaB.Text);
            notaC = double.Parse(txtNotaC.Text);
            notaMedia = 0;

            if (valid = validarNota(notaA, notaB, notaC)) 
            {
                notaMedia = calcNotaMedia(notaA, notaB, notaC);
                MessageBox.Show("La nota media es: " + notaMedia);
            }
            else
            {
                MessageBox.Show("Error, las datos introducidos no son válidos");
            }
        }
    }
}
