using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_14_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void calculateBills (ref int valorUsuario,int billMoneda, ref string result)
        {
            int totalBillete = valorUsuario / billMoneda;
            if (totalBillete >= 1)
            {
                if (totalBillete >= 1000)
                {
                    result = result + totalBillete + " billetes de " + billMoneda + "\n";
                }
                else
                {
                    result = result + totalBillete + " monedas de " + billMoneda + "\n";
                }
            }
            valorUsuario = valorUsuario - totalBillete * billMoneda;
        }
        private void btnCalcularPesetas_Click(object sender, EventArgs e)
        {

            int valorUsuario = int.Parse(txtValor.Text);
            string result = "";

            calculateBills(ref valorUsuario, 10000, ref result);
            calculateBills(ref valorUsuario, 5000, ref result);
            calculateBills(ref valorUsuario, 2000, ref result);
            calculateBills(ref valorUsuario, 1000, ref result);
            calculateBills(ref valorUsuario, 100, ref result);
            calculateBills(ref valorUsuario, 25, ref result);
            MessageBox.Show(result);
        }
    }
}
