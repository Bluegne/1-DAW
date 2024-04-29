using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Objects
{
    class Employee
    {
        //TODO declarar miembros de la clase (son como los datos -> lo que tiene un empleado)
        //TODO tiene que ser privado
        private string mName; //miembro 1
        private int mAge; //miembro 2
        //TODO almacenar ventas realizadas por el empleados, utilizando una lista
        private List<double> mSales; //miembro 3

        //TODO propiedades de la clase, que son públicas para poder acceder a los miembros
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Age
        {
            get { return mAge; }
            set
            {   //TODO no permitir edades negativas o superiores a 100
                if (value >= 0 && value <=100)
                {
                    mAge = value;
                }
            }  
        }

        //TODO crear constructor
        public Employee()
        {
            mName = "";
            mAge = 0;
            //TODO crear la lista de ventas
            mSales = new List<double>();
        }

        //TODO crear métodos de la clase --> métodos son como las funciones
        //TODO crear método del empleado
        public void Birthday()
        {
            mAge = mAge + 1;
        }
        //TODO añadir una al empleado
        public void AddSale(double sale)
        {
            if (sale > 0)
            {
                mSales.Add(sale);
            }
        }

        //TODO función que devuelve un texto con la lista de las ventas
        //debe ser privada ya que solo se utilizará dentro de la clase (en ShowData)
        
        private string ShowSales()
        {
            string text;
            int i;

            if (mSales.Count > 0)
            {
                text = "The employee sales are: ";
                for(i = 0; i < mSales.Count; i++)
                {
                    text+= mSales[i] + ", ";
                }
                text+= "\n";
            }
            else
            {
                text = "The employee has 0 sales.\n";
            }
            return text;
        }
        //TODO función que devuelve un texto con los datos del empleado
        // debe ser pública para que se pueda llamar desde fuera de la clase
        public string ShowData()
        {
            string text;
            text = "Employee data:\n";
            text+= "Name:" + mName + "\n";
            text+= ShowSales();

            return text;
        }
    }
}
    
