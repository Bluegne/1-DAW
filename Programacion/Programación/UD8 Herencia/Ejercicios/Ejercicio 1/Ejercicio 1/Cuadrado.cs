using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Cuadrado : Figura
    {
        //TODO miembros
        private int mLado;
        
        //TODO propiedades
        public int Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }

        //TODO Constructor. Llama al constructor de Figura
        public Cuadrado(int x, int y, string color, int lado) : base(x, y, color)
        {
            mLado = lado;
        }

        //TODO sobreescritura del método virtual QuienSoy
        public override string QuienSoy()
        {
            return "Soy un cuadrado.";
        }

        //TODO sobreescritura del método ToString
        public override string ToString()
        {
            string texto = base.ToString();
            texto = texto + "\n Lado: " + mLado;

            return texto;
        }

        //TODO sobreescritura del método abstracto Area
        public override double Area()
        {
            double area = mLado * mLado;

            return area;
        }
    }
}
