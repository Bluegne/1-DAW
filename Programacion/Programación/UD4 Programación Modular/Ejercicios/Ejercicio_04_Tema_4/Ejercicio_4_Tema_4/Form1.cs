using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //TODO Función que devuelva valor absoluto de núm real introducido por usuario
        int ValorAbsoluto(int numUsuario)
        {
            int res;
            if (numUsuario < 0)
            {
                //TODO sacar valor real de núm negativo (ejm -6 * -1 = 6) multiplicar negativo * -1 negativo devuelve positivo
                res = numUsuario * -1;
            }
            else
            {
                res = numUsuario;
            }
            return res;
        }
        private void btnMostrarValorAbs_Click(object sender, EventArgs e)
        {
            int numUsuario = int.Parse(txtNumUsuario.Text);
            int res;
            res = ValorAbsoluto(numUsuario);
            MessageBox.Show("Valor absoluto de " + numUsuario + " es de " +  res);
        }
    }
}
