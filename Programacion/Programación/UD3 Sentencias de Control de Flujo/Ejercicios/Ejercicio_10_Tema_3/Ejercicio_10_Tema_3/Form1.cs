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

        private void bCalcular_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "";
            double valorUsuario;
            int billete, monedasEntero, centimosDecimal;
            valorUsuario = double.Parse(txtValorUsuario.Text);

            billete = (int)valorUsuario;
            //centimosDecimal = (int)(valorUsuario * 100 - billete * 100);
            //centimosDecimal = (int)(valorUsuario - billete) * 100;
            
            if (valorUsuario >= 500)
            {
                billete = (int)valorUsuario / 500;
                lblMostrar.Text = lblMostrar.Text + billete + " billetes de 500€" + "\n";
                valorUsuario = valorUsuario % 500;
            }
            if (valorUsuario >= 200)
            {
                billete = (int)valorUsuario / 200;
                lblMostrar.Text = lblMostrar.Text + billete + " billetes de 200€" + "\n";
                valorUsuario = valorUsuario % 200;
            }
            if (valorUsuario >= 100)
            {
                billete = (int)valorUsuario / 100;
                lblMostrar.Text = lblMostrar.Text + billete + " billetes de 100€" + "\n";
                valorUsuario = valorUsuario % 100;
            }
            if (valorUsuario >= 50)
            {
                billete = (int)valorUsuario / 50;
                lblMostrar.Text = lblMostrar.Text + billete + " billetes de 50€" + "\n";
                valorUsuario = valorUsuario % 50;
            }
            if (valorUsuario >= 10)
            {
                billete = (int)valorUsuario / 10;
                lblMostrar.Text = lblMostrar.Text + billete + " billetes de 10€" + "\n";
                valorUsuario = valorUsuario % 10;
            }
            if (valorUsuario >= 5)
            {
                billete = (int)valorUsuario / 5;
                lblMostrar.Text = lblMostrar.Text + billete + " billetes de 5€" + "\n";
                valorUsuario = valorUsuario % 5;
            }
            if (valorUsuario >= 2)
            {
                monedasEntero = (int)valorUsuario / 2;
                lblMostrar.Text = lblMostrar.Text + monedasEntero + " monedas de 2€" + "\n";
                valorUsuario = valorUsuario % 2;
            }
            if (valorUsuario >= 1)
            {
                monedasEntero = (int)valorUsuario / 1;
                lblMostrar.Text = lblMostrar.Text + monedasEntero + " monedas de 1€" + "\n";
                valorUsuario = valorUsuario % 1;
            }
            
            valorUsuario = valorUsuario * 100;

            if (valorUsuario >= 50)
            {
                centimosDecimal = (int)valorUsuario / 50;
                lblMostrar.Text = lblMostrar.Text + centimosDecimal + " moneda de 0.50€" + "\n";
                valorUsuario = valorUsuario % 50;
            }
            if (valorUsuario >= 20)
            {
                centimosDecimal = (int)valorUsuario / 20;
                lblMostrar.Text = lblMostrar.Text + centimosDecimal + " moneda de 0.20€" + "\n";
                valorUsuario = valorUsuario % 20;
            }
            if (valorUsuario >= 10)
            {
                centimosDecimal = (int)valorUsuario / 10;
                lblMostrar.Text = lblMostrar.Text + centimosDecimal + " moneda de 0.10€" + "\n";
                valorUsuario = valorUsuario % 10;
            }
            if (valorUsuario >= 5)
            {
                centimosDecimal = (int)valorUsuario / 5;
                lblMostrar.Text = lblMostrar.Text + centimosDecimal + " moneda de 0.05€" + "\n";
                valorUsuario = valorUsuario % 5;
            }
            if (valorUsuario >= 2)
            {
                centimosDecimal = (int)valorUsuario / 2;
                lblMostrar.Text = lblMostrar.Text + centimosDecimal + " moneda de 0.02€" + "\n";
                valorUsuario = valorUsuario % 2;
            }
            if (valorUsuario >= 1)
            {
                centimosDecimal = (int)valorUsuario / 1;
                lblMostrar.Text = lblMostrar.Text + centimosDecimal + " moneda de 0.01€" + "\n";
                valorUsuario = valorUsuario % 1;
            }

            int NewMethod()
            {
                int billete = (int)valorUsuario / 500;
                lblMostrar.Text = lblMostrar.Text + billete + " billetes de 500€" + "\n";
                valorUsuario = valorUsuario % 500;
                return billete;
            }
            //if (valorUsuario >= 50)
            //{
            //    centimosDecimal = (int)((valorUsuario - valorUsuario) * 100);
            //    lblMostrar.Text = lblMostrar.Text + centimosDecimal + " moneda de 0.50€" + "\n";
            //    valorUsuario = valorUsuario % 50;
            //}
        }
    }
}

