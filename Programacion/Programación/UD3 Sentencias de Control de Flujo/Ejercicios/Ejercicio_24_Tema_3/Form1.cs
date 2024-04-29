using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_24_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            int userNumber, result;
            result = 0;
            userNumber = int.Parse(txtUserNumber.Text);
            string texto = "Tabla del " + userNumber + "\n";

            if (userNumber > 0 && userNumber <=100)
            {
                for (int i = 1; i <= 10; i++)
                {
                    result = userNumber * i;
                    texto += userNumber + "* " + i + "= " + result + "\n";
                }
            }
            MessageBox.Show(texto);
        }
    }
}
