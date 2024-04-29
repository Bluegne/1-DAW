using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int calcularPotencia(int numBase, int exponente)
        {
            int result = 1;
            for (int i = 1; i <= exponente; i++)
            {
                result = result * numBase;
            }
            return result;
        }
        private void btnShowResult_Click(object sender, EventArgs e)
        {
            int pot2, pot5, pot7;
            int num = int.Parse(txtNumber.Text);
            pot2 = calcularPotencia(num, 2);
            pot5 = calcularPotencia(num, 5);
            pot7 = calcularPotencia(num, 7);
            MessageBox.Show("El resultado de " + num + "elevado a 2 es: " + pot2 + "\n" //FALTA AGREGAR LAS OTRAS RESPUESTAS );
        }
    }
}
