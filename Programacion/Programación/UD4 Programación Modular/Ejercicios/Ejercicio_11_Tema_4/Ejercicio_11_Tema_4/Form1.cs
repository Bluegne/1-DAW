using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool calcularAnyoBisiesto (int anyo)
        {
            bool bisiesto = false;
            if (anyo % 4 == 0)
            {
                bisiesto = true;
                if (anyo % 100 == 0 && anyo % 400 != 0)
                {
                    bisiesto = false;
                }
            }
            return bisiesto;
        }
        private void btnCalcBisiesto_Click(object sender, EventArgs e)
        {
            int anyo = int.Parse(txtAnyo.Text);
            bool bisiesto = calcularAnyoBisiesto(anyo);

            if (bisiesto == true)
            {
                MessageBox.Show("El año " + anyo + " es bisiesto");
            }
            else
            {
                bisiesto = false;
                MessageBox.Show("El año " + anyo + " no es bisiesto");
            }
        }
    }
}
