using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadirTexto_Click(object sender, EventArgs e)
        {
            if (txtTextBox.Text != "")
            {
                if (lblLabel.Text == "")
                {
                    lblLabel.Text = txtTextBox.Text;
                }
                else
                {
                    lblLabel.Text = lblLabel.Text + "\n" + txtTextBox.Text;
                }
            }
        }
    }
}
