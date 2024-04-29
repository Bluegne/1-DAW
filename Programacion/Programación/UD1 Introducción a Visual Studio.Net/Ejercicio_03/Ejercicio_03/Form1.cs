using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bPulsado_Click(object sender, EventArgs e)
        {

        }

        private void tTexto_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void bBoton1_Click(object sender, EventArgs e)
        {
            tTexto.Text = "Se ha presionada el botón 1";
        }

        private void bBoton2_Click(object sender, EventArgs e)
        {
            tTexto.Text = "Se ha presionada el botón 2";
        }

        private void bBorrarTexto_Click(object sender, EventArgs e)
        {
            //tTexto.Clear();
            tTexto.Text = "";
            //tTexto.Text = String.Empty;
        }
    }
}
