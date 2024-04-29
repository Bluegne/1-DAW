using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10_Tema_2
{
    public partial class Form1 : Form
    {
        const double CONVERSOR = 166.38;
        public Form1()
        {
            InitializeComponent();
        }

        private void bConvertToPeseta_Click(object sender, EventArgs e)
        {
            double euro, peseta;
            try
            {
                euro = Convert.ToDouble(tEuros.Text) * CONVERSOR;
                // peseta = euro * conversor;
                tPesetas.Text = euro.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
            
        }

        private void bConvertToEuro_Click(object sender, EventArgs e)
        {
            double peseta, euro;
            try
            {
                peseta = Convert.ToDouble(tPesetas.Text) / CONVERSOR;
                // euro = peseta / conversor;
                tEuros.Text = peseta.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }

        }
    }
}
