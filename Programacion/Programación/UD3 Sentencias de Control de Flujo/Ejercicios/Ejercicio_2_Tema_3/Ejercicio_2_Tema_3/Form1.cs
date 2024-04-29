using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int num1, num2;

            num1 = int.Parse(txtNumero1.Text);
            num2 = int.Parse(txtNumero2.Text);

            if (num1 == num2 && num2 == num1)
            {
                MessageBox.Show("Ambos números son iguales");
            }
            else
            {
                MessageBox.Show("Ambos números son diferentes");
            }
         
        }
    }
}
