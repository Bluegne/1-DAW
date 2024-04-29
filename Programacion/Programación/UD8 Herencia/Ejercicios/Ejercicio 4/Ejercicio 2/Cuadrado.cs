using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Cuadrado : Figura
    {
        //TODO miembros
        private double mLado;
        
        //TODO propiedades
        public double Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }

        //TODO Constructor. Llama al constructor de Figura
        public Cuadrado(double x, double y, string color, double lado) : base(x, y, color)
        {
            mLado = lado;
        }

        //TODO sobreescritura del método virtual QuienSoy
        public override string QuienSoy()
        {
            return "Soy un cuadrado";
        }

        //TODO sobreescritura del método ToString
        public override string ToString()
        {
            string texto = base.ToString();
            texto = texto + "\nLado: " + mLado;

            return texto;
        }

        //TODO sobreescritura del método abstracto Area
        public override double Area()
        {
            double area = mLado * mLado;

            return area;
        }
        public override double Perimetro()
        {
            double perimetro = mLado * 4;
            return perimetro;
        }
    }
}
