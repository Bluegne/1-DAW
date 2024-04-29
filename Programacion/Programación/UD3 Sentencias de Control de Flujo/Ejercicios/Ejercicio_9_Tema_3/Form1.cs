using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            int valorUsuario, billetes, monedas;
            valorUsuario = int.Parse(txtValor.Text);

            if (valorUsuario >= 10000)
            {
                billetes = valorUsuario / 10000;
                lblMostrar.Text = billetes + " billetes de 10.000" + "\n";
                //OTRA SOLUCION: lblMostrar.Text = lblMostrar.Text + billetes + " billetes de 10.000" + "\n"; 
                valorUsuario = valorUsuario - billetes * 10000;
                //OTRA SOLUCION: valorUsuario = valorUsuario % 10000;
            }
            if (valorUsuario >= 5000)
            {
                billetes = valorUsuario / 5000;
                lblMostrar.Text = lblMostrar.Text + billetes + " billete de 5.000" + "\n";
                valorUsuario = valorUsuario - billetes * 5000;
            }
            if (valorUsuario >= 2000)
            {
                billetes = valorUsuario / 2000;
                lblMostrar.Text = lblMostrar.Text + billetes + " billetes de 2.000" + "\n";
                valorUsuario = valorUsuario - billetes * 2000;
            }
            if (valorUsuario >= 1000)
            {
                billetes = valorUsuario / 1000;
                lblMostrar.Text = lblMostrar.Text + billetes + " billetes de 1.000" + "\n";
                valorUsuario = valorUsuario - billetes * 1000;
            }
            if (valorUsuario >= 100)
            {
                billetes = valorUsuario / 100;
                lblMostrar.Text = lblMostrar.Text + billetes + " billetes de 100" + "\n";
                valorUsuario = valorUsuario - billetes * 100;
            }
            if (valorUsuario >= 25)
            {
                monedas = valorUsuario / 25;
                lblMostrar.Text = lblMostrar.Text + monedas + " monedas de 25" + "\n";
                valorUsuario = valorUsuario - monedas * 25;
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
