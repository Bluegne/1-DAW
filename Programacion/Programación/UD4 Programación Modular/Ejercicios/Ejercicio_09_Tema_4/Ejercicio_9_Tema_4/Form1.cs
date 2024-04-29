using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CalcularPotencia(int numBase, int numExp)
        {
            int potencia = 1; 
            for (int i = 1; i <= numExp; i++)
            {
                //Para sacar potencia: multiplicar numBase por si mismo la cantidad de veces de numExp
                potencia = potencia * numBase;
            }
            return potencia;
        }

        private void btnCalcularPotencia_Click(object sender, EventArgs e)
        {
            int numBase = int.Parse(txtNumBase.Text);
            int numExp = int.Parse(txtNumExp.Text);
            int res = CalcularPotencia(numBase, numExp);
            MessageBox.Show("La potencia es de " + res);
        }
    }
}
