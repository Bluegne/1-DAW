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
    public partial class fInicial : Form
    {
        public fInicial()
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
            double cont = 1;
            string texto = "";

            foreach (Figura figura in listaFiguras)
            {
                texto += "Figura número: " + cont + "\n";
                texto += figura.QuienSoy() + "\n";
                texto += figura.ToString() + "\n";
                texto += "Mi perímetro es: " + figura.Perimetro() + "\n";
                texto += "Mi área es: " + figura.Area() + "\n\n";
                cont++;
            }
            return texto;
        }

        //TODO método mostrar datos círculos
        public string MostrarDatosCirculos(List<Figura> listaFiguras)
        {
            string texto = "Datos de los círculos:\n";
            double cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Circulo))
                {
                    texto+= "Círculo número: " + cont + "\n";
                    texto+= figura.ToString() + "\n";
                    texto += "Mi perímetro es: " + figura.Perimetro() + "\n";
                    texto+= "Área del círculo: " +  figura.Area() + "\n\n";
                    cont++;
                }
            }
            return texto;
        }

        //TODO método mostrar datos cuadrados
        public string MostrarDatosCuadrados(List<Figura> listaFiguras)
        {
            string texto = "Datos de los cuadrados:\n";
            double cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Cuadrado))
                {
                    texto+= "Cuadrado número: " + cont + "\n";
                    texto+= figura.ToString() + "\n";
                    texto += "Mi perímetro es: " + figura.Perimetro() + "\n";
                    texto+= "Área del cuadrado: " +  figura.Area() + "\n\n";
                    cont++;
                }
            }
            return texto;
        }

        //TODO método mostrar datos triángulos
        public string MostrarDatosTriangulos(List<Figura> listaFiguras)
        {
            string texto = "Datos de los triángulos :\n";
            double cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Triangulo))
                {
                    texto+= "Triangulo número: " + cont + "\n";
                    texto+= figura.ToString() + "\n";
                    texto += "Mi perímetro es: " + figura.Perimetro() + "\n";
                    texto+= "Área del triángulo: " +  figura.Area() + "\n\n";
                    cont++;
                }
            }
            return texto;
        }

        //TODO método mostrar datos rectángulos
        public string MostrarDatosRectangulos(List<Figura> listaFiguras)
        {
            string texto = "Datos de los rectángulos :\n";
            double cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Rectangulo))
                {
                    texto+= "Rectángulo número: " + cont + "\n";
                    texto+= figura.ToString() + "\n";
                    texto += "Mi perímetro es: " + figura.Perimetro() + "\n";
                    texto+= "Área del rectángulo: " +  figura.Area() + "\n\n";
                    cont++;
                }
            }
            return texto;
        }

        public string MostrarDatosHexagonos(List<Figura> listaFiguras)
        {
            string texto = "Datos de los hexágonos:\n";
            double cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Hexagono))
                {
                    texto+= "Hexágono número: " + cont + "\n";
                    texto+= figura.ToString() + "\n";
                    texto += "Mi perímetro es: " + figura.Perimetro() + "\n";
                    texto+= "Área del hexágono: " +  figura.Area() + "\n\n";
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

        private void btnAgregarTriangulo_Click(object sender, EventArgs e)
        {
            fTriangulo fTriangulo = new fTriangulo(listaFiguras);
            fTriangulo.ShowDialog();
        }

        private void btnAgregarRectangulo_Click(object sender, EventArgs e)
        {
            fRectangulo fRectangulo = new fRectangulo(listaFiguras);
            fRectangulo.ShowDialog();
        }

        private void btnAgregarHexagono_Click(object sender, EventArgs e)
        {
            fHexagono fHexagono = new fHexagono(listaFiguras);
            fHexagono.ShowDialog();
        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {
            //TODO comprobar si lista está vacia
            string texto = MostrarDatosFiguras(listaFiguras);
            if (texto == "")
            {
                texto = "No se han añadadido figuras.";
            }
            else
            {
                MessageBox.Show(texto);
            }
        }

        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            //TODO comprobar si lista está vacia
            string texto = MostrarDatosCirculos(listaFiguras);
            if (texto == "")
            {
                texto = "No se han añadadido círculos.";
            }
            else
            {
                MessageBox.Show(texto);
            }
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            //TODO comprobar si lista está vacia
            string texto = MostrarDatosCuadrados(listaFiguras);
            if (texto == "")
            {
                texto = "No se han añadadido cuadrados.";
            }
            else
            {
                MessageBox.Show(texto);
            }
        }

        private void btnMostrarTriangulos_Click(object sender, EventArgs e)
        {
            //TODO comprobar si lista está vacia
            string texto = MostrarDatosTriangulos(listaFiguras);
            if (texto == "")
            {
                texto = "No se han añadadido triángulos.";
            }
            else
            {
                MessageBox.Show(texto);
            }
        }

        private void btnMostrarRectangulos_Click(object sender, EventArgs e)
        {
            //TODO comprobar si lista está vacia
            string texto = MostrarDatosRectangulos(listaFiguras);
            if (texto == "")
            {
                texto = "No se han añadadido rectángulos.";
            }
            else
            {
                MessageBox.Show(texto);
            }
        }

        private void btnMostrarHexagonos_Click(object sender, EventArgs e)
        {
            //TODO comprobar si lista está vacia
            string texto = MostrarDatosHexagonos(listaFiguras);
            if (texto == "")
            {
                texto = "No se han añadadido hexágonos.";
            }
            else
            {
                MessageBox.Show(texto);
            }
        }

    }
}
