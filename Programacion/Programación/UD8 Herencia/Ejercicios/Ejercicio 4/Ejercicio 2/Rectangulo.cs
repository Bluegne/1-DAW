using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Rectangulo : Figura
    {
        private double mLadoA;
        private double mLadoB;

        public double LadoA
        {
            get { return mLadoA; }
            set { mLadoA = value; }
        }

        public double BaseB
        {
            get { return mLadoB; }
            set { mLadoB = value;}
        }

        public Rectangulo(double posX, double posY, string color, double ladoA, double ladoB) : base(posX, posY, color) 
        {
            mLadoA = ladoA;
            mLadoB = ladoB;
        }

        public override string QuienSoy() 
        {
            return "Soy un Rectangulo";
        }

        public override string ToString()
        {
            string texto = base.ToString();
            texto = texto + "\nAltura: " + mLadoA ;
            texto = texto + "\nLongitud: " + mLadoB;
            return texto;
        }
        public override double Area()
        {
            double area = mLadoA * mLadoB;
            return area;
        }

        public override double Perimetro()
        {
            double perimetro = mLadoA * 2 + mLadoB * 2;
            return perimetro;
        }
    }
}
