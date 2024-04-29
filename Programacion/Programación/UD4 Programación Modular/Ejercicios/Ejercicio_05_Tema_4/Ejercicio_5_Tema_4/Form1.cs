using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int Larger(int numA, int numB)
        {
            int largerNumber;

            if (numA > numB)
            {
                largerNumber = numA;
            }
            else
            {
                largerNumber = numB;
            }
            return largerNumber;
        }
        private void btnShowNumber_Click(object sender, EventArgs e)
        {
            int numA, numB, largerNumber;

            numA = int.Parse(txtNumA.Text);
            numB = int.Parse(txtNumB.Text);
            largerNumber = Larger(numA, numB);
            MessageBox.Show("The largest number is: " + largerNumber);
        }
    }
}
