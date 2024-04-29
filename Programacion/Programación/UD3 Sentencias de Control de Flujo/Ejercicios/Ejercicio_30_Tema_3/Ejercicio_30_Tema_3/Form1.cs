using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_30_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            int i = 1;
            bool successful = false;
            i = 1;
            //TODO 5 intentos maximo para colocar user y pass
            while (i <= 5 && !successful) 
            { 
                //TODO pedir username y password
                string username = Interaction.InputBox("Please enter your username", "Sign in");
                string password = Interaction.InputBox("Please enter your password", "Sign in");
                
                //TODO si user y pass son correctos, bool cambia a true, mensaje bienvenida
                if (username == "root" && password == "1234")
                {
                    successful = true;
                    MessageBox.Show("Welcome to the system");
                }
                //TODO si user y pass son incorrectos, intentar de nuevo
                else
                {
                    i++;
                }
            }//TODO si usuario supera intentos maximo, mensaje aviso, fin bucle
            if (i > 5)
            {
                MessageBox.Show("You have exceeded the number of attempts allowed");
            }
        }
    }
}
