using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //TODO declaramos una lista donde meteremos TODAS las figuras
        List<Figura> listaFiguras = new List<Figura>();

        //TODO método mostrar datos de las figuras
        public string MostrarDatosFiguras(List<Figura> listaFiguras)
        {
            int cont = 1;
            string texto = "";

            foreach (Figura figura in listaFiguras)
            {
                texto += "Figura número: " + cont + "\n";
                texto += figura.QuienSoy() + "\n";
                texto += figura.ToString() + "\n";
                texto += "Mi área es: " + figura.Area() + "\n\n";
                cont++;
            }
            return texto;
        }

        //TODO método mostrar datos círculos
        public string MostrarDatosCirculos(List<Figura> listaFiguras)
        {
            string texto = "Datos de los círculos :\n";
            int cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Circulo))
                {
                    texto+= "Círculo número: " + cont + "\n";
                    texto+= figura.ToString() + "\n";
                    texto+= "Área del círculo: " +  figura.Area() + "\n\n";
                    cont++;
                }
            }
            return texto;
        }

        //TODO método mostrar datos cuadrados
        public string MostrarDatosCuadrados(List<Figura> listaFiguras)
        {
            string texto = "Datos de los círculos :\n";
            int cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Cuadrado))
                {
                    texto+= "Cuadrado número: " + cont + "\n";
                    texto+= figura.ToString() + "\n";
                    texto+= "Área del círculo: " +  figura.Area() + "\n";
                    cont++;
                }
            }
            return texto;
        }

        private void btnAgregarCirculo_Click(object sender, EventArgs e)
        {
            fCirculo fCirculo = new fCirculo(listaFiguras);
            fCirculo.ShowDialog(); 
        }

        private void btnAgregarCuadrado_Click(object sender, EventArgs e)
        {
            fCuadrado fCuadrado = new fCuadrado(listaFiguras);
            fCuadrado.ShowDialog();
        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarDatosFiguras(listaFiguras));
        }

        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarDatosCirculos(listaFiguras));
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarDatosCuadrados(listaFiguras));
        }
    }
}
