using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarNumero_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(txtNumero.Text);

            if (num == 2)
            {
                MessageBox.Show("el número introducido es el 2");
            }
            else
            {
                MessageBox.Show("el número introducido NO es el 2");
            }
        }
    }
}
