using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double nota;
            nota = Convert.ToDouble(txtNota.Text);

            // TODO Realizar escriba si el resultado es muy deficiente(2.5), insuficiente(4.5),
            // suficiente, bien, notable o sobresaliente.

            if (nota <= 3.5)
            {
                MessageBox.Show("Muy deficiente");
            }
            else if (nota > 3.5 && nota <= 4.7)
            {
                MessageBox.Show("Insuficiente");
            }
            else if (nota > 4.7 && nota <= 5.9)
            {
                MessageBox.Show("Suficiente");
            }
            else if (nota > 5.9 && nota <= 7.9)
            {
                MessageBox.Show("Bien");
            }
            else if (nota > 7.9 && nota <= 9.5)
            {
                MessageBox.Show("Notable");
            }
            else if (nota > 9.5 && nota <= 10)
            {
                MessageBox.Show("Sobresaliente");
            }
            else
                MessageBox.Show("La nota no puede ser mayor que 10");
        }
    }
}
