using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public class Circulo : Figura
    {
        //TODO miembro privado
        private int mRadio;

        public int Radio
        {
            get { return mRadio; }
            set { mRadio = value; }
        }

        //TODO Constructor. Llama al constructor de Figura
        public Circulo(int x, int y, string color, int radio) : base(x, y, color)
        {
            mRadio = radio;
        }

        //TODO sobreescritura del método virtual QuienSoy
        public override string QuienSoy()
        {
            return "Soy un circulo";
        }

        //TODO sobreescritura del método ToString
        public override string ToString()
        {
            string texto = base.ToString();
            texto = texto + "\nRadio: " + mRadio;

            return texto;
        }
        //TODO sobreescritura del método abstracto Area
        public override double Area()
        {
            return Math.PI * mRadio * mRadio;
        }
    }
}
