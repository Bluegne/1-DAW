using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_14_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bMayor_Click(object sender, EventArgs e)
        {
            bool prueba;
            int num1, num2;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);

            prueba = num1 > num2;

            lRespuesta.Text = prueba.ToString();

        }

        private void lRespuesta_Click(object sender, EventArgs e)
        {

        }

        private void bMenor_Click(object sender, EventArgs e)
        {
            bool prueba;
            int num1, num2;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);

            prueba = num1 < num2;

            lRespuesta.Text = prueba.ToString();

        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            bool prueba;
            int num1, num2;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);

            prueba = num1 == num2;

            lRespuesta.Text = prueba.ToString();
        }

        private void bNoIgual_Click(object sender, EventArgs e)
        {
            bool prueba;
            int num1, num2;

            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);

            prueba = num1 != num2;

            lRespuesta.Text = prueba.ToString();
        }
    }
}
