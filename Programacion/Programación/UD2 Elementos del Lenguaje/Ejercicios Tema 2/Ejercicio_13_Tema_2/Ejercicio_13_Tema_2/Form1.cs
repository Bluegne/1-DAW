using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_13_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double RETENCION = 0.18;
        private void button1_Click(object sender, EventArgs e)
        {
       
           
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double PrecioHora, PrecioHoraExtra, numHora, numHoraExtra, subtotal, totalPagar, totalRetener;
            PrecioHora = 10;
            PrecioHoraExtra = PrecioHora * 2;

            numHora = Convert.ToDouble(tHora.Text);
            numHoraExtra = Convert.ToDouble(tHoraExtra.Text);

            subtotal = numHora * PrecioHora + numHoraExtra * PrecioHoraExtra;
            totalRetener = subtotal * RETENCION;
            totalPagar = subtotal - totalRetener;

            MessageBox.Show("El total de su nómina es de: " + totalPagar + "€");
        }
    }
}
