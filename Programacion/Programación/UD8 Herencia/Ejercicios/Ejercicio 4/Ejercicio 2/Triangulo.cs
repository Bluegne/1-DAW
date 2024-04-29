using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Triangulo : Figura
    {
        private double mLado;

        public double Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }

        public Triangulo(double posX, double posY, string color, double lado) : base (posX, posY, color)
        {
            mLado = lado;
        }

        public override string QuienSoy()
        {
            return "Soy un triángulo";
        }

        public override string ToString()
        {
            string texto = base.ToString();
            texto = texto + "\nBase: " + mLado; ;

            return texto;
        }
        public override double Area()
        {
            double cateto = mLado / 2;
            double altura = Math.Sqrt(mLado * mLado - cateto * cateto);
            double area = mLado * altura / 2;
            return area;
        }

        public override double Perimetro()
        {
            double area = mLado * 3;
            return area;
        }
    }
}
