using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_12_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double IVA = 0.21;
        private void bCalcular_Click(object sender, EventArgs e)
        {

            double prod1, prod2, prod3, sumProd, retencion, totalPagar;

            prod1 = Convert.ToDouble(tProd1.Text);
            prod2 = Convert.ToDouble(tProd2.Text);
            prod3 = Convert.ToDouble(tProd3.Text);
            sumProd = prod1 + prod2 + prod3;
            retencion = sumProd * IVA;
            totalPagar = sumProd + retencion;

            MessageBox.Show("Subtotal " + sumProd + "$" + " + IVA 21%, Total: " + totalPagar + "$");

        }
    }
}
