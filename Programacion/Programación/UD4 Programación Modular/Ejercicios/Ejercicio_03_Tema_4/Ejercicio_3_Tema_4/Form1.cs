using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void changeResult(ref int num1, ref int num2)
        {
            int valAux = num1;
            num1 = num2;
            num2 = valAux;
        }
        private void btnChangeValue_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            changeResult(ref num1, ref num2);
            MessageBox.Show("Number 1 is " + num1 + " and number is " + num2);
        }
    }
}
