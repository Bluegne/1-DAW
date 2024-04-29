using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_01
{
    public partial class FFormulario1 : Form
    {
        public FFormulario1()
        {
            InitializeComponent();
        }

        private void bPrimero_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo. Este es mi primer programa");
        }


        private void bSegundo_Click(object sender, EventArgs e)
        {
            lTexto.Text = tCuadro.Text;
        }
    }
}
