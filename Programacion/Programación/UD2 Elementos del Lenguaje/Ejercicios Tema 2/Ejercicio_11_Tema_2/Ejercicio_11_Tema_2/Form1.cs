using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double ingreso, interes, totalInteres, totalPagar;
            totalPagar = 0;

            ingreso = Convert.ToDouble(tIngreso.Text);
            interes = Convert.ToDouble(tInteres.Text) / 100; 
            totalInteres = ingreso * interes;
            totalPagar = ingreso + totalInteres;

            tCapital.Text = totalPagar.ToString();

        }
    }
}
