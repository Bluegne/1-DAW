using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_26_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sum, count;
            sum = 0;
            count = 0;
            string text = "";

            for (int i = 3; i <= 99; i = i + 3)
            {
                text = text + i + ", ";
                sum = sum + i;
                count = count + 1;

                if (count >= 7)
                {
                    text = text + "\n";
                    count = 0;
                }
            }
            MessageBox.Show("Serie: " + "\n" + text + "\n" + "\n" + " La suma es: " + sum);
        }
    }
}
