using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int hora, min, seg;
            hora = int.Parse(txtHora.Text);
            min = int.Parse(txtMin.Text);
            seg = int.Parse(txtSeg.Text);

            if ((hora > 0 && hora <= 23) && (min > 0 && min <= 59) && (seg > 0 && seg <= 59))
            {
                if (seg == 59)
                {
                    min = min + 1;
                    seg = 0;
                }
                else
                {
                    seg = seg + 1;
                }
                if (min > 59)
                {
                    hora = hora + 1;
                    min = 0;
                }
                if (hora > 23)
                {
                    hora = 0; 
                }
                MessageBox.Show("La hora siguiente será " + hora + " : " + min + " : " + seg);
            }
            else
            {
                MessageBox.Show("Se ha introducido una hora incorrecta");
            }
        }
    }
}
