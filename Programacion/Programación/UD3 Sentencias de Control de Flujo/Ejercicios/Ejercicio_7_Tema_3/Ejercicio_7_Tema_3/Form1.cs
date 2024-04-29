using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(txtNumero.Text);

            switch (num)
            {
                case 1: MessageBox.Show("Se ha introducido el número 1");
                    break;
                case 2: MessageBox.Show("Se ha introducido el número 2");
                    break;
                case 3: MessageBox.Show("Se ha introducido el número 3");
                    break;
                case 4: MessageBox.Show("Se ha introducido el número 4");
                    break;
                case 5: MessageBox.Show("Se ha introducido el número 5");
                    break;
                default:
                    MessageBox.Show("Se ha introducido un número mayor que 5");
                    break;
            }
        }
    }
}
