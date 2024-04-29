using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tCuadroTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tCuadroTexto.Text);
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            BackColor = Color.CadetBlue;
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            tCuadroTexto.ForeColor = Color.Red;
        }
    }
}
