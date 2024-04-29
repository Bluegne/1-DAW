using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Hexagono : Figura
    {
        private double mLado;

        public double Lado
        { 
            get { return mLado; } 
            set { mLado = value; } 
        }

        public Hexagono(double x, double y, string color, double lado) : base(x, y, color)
        {
            mLado = lado; 
        }

        public override string QuienSoy()
        {
            return "Soy un hexágono";
        }

        public override string ToString()
        {
            string texto = base.ToString();
            texto = texto + "\nLado: " + mLado; ;

            return texto;
        }

        public override double Area()
        {
            double cateto = mLado / 2;
            double hipotenusa = mLado;
            double apotema = Math.Sqrt(hipotenusa * hipotenusa - cateto * cateto);
            double area = Perimetro() * apotema / 2;
            return area;
        }
        public override double Perimetro()
        {
            double perimetro = mLado * 6;
            return perimetro;
        }
    }
}
