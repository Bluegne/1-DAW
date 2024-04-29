using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void calculateDivRes(int num1, int num2, out int division, out int rest)
        {
            division = num1 / num2;
            rest = num1 % num2;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int division, rest;
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            calculateDivRes(num1, num2, out division, out rest);
            MessageBox.Show("El resultado de la división es " + division + " y el resto es " + rest);
        }
    }
}
