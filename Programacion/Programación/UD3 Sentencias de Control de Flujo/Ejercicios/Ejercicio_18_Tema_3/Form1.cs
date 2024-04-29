using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_18_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int suma = 0;

            while (i <= 50)
            {
                suma = suma + i;
                i = i + 2;
            }
            MessageBox.Show("El resultado de la suma es: " + suma);
        }
    }
}
