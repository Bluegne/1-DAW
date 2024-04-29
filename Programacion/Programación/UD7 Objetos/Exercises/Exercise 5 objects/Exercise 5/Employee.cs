using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Employee
    {
        //TODO declarar miembros de la clase.
        private string mName;
        private int mAge;
        private List<double> mSales;

        //TODO propiedades de la clase.
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Age
        {
            get { return mAge; }
            set
            {
                //TODO no permitir edades negativas o superiores a 100.
                if (value >= 0 && value <=100)
                {
                    mAge = value;
                }
            }
        }

        //TODO constructor.
        public Employee()
        {
            mName = "";
            mAge = 0;
            //TODO crear lista de ventas.
            mSales = new List<double>();
        }

        //TODO métodos de la clase.
        //cumpleaños empleado.
        public void Birthday()
        {
            mAge = mAge + 1;
        }

        //TODO método para añadir venta a empleado.
        public void AddSale(double sale)
        {
            if (sale > 0)
            {
                mSales.Add(sale);
            }
        }

        public void DeleteSales()
        {            
            mSales.Clear();           
        }

        //TODO método que devuelve un texto con la lista de ventas.
        private string ShowSales()
        {
            string text = "";

            if (mSales.Count > 0)
            {
                text = "Ventas realizadas:\n";
                for (int i = 0; i < mSales.Count; i++)
                {
                    text = text + mSales[i] + "€" + "\n"; 
                }
                text = text + "\n";
            }
            else
            {
                text = "Empleado sin ventas.\n";
            }
            return text;
        }

        //TODO método que devuelve un texto con los datos del empleado.
        //es pública ya que se llama desde fuera de la clase.
        public string ShowData()
        {
            string text;

            text = "\n- Nombre: " + mName + "\n";
            text += "- Edad: " + mAge + "\n";
            text += "- " + ShowSales();
            text += "\n..........................................\n";

            return text;
        }

        //TODO método que calcula la ventas.
        public double CalculateSales()
        {
            double totalSales = 0;
            if (mSales.Count > 0)
            {
                foreach (double sale in mSales)
                {
                    totalSales += sale;
                }
            }
            else
            {
                totalSales = -1;
            }
            return totalSales;
        }
    }
}
