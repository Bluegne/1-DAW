using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using System.Windows.Forms;

namespace Ejercicio04
{
    class ListaEmpleados
    {
        private List<Empleado> mLista;

        // Constructor de la clase. Creamos la lista.
        public ListaEmpleados()
        {            
            mLista = new List<Empleado>();
        }

        // Método que añade un empleado a la lista.
        // Le pasa el nombre y la edad
        public void AnyadirEmpleado(string nombre, int edad)
        { 
            Empleado empl = new Empleado();

            empl.Nombre = nombre;
            empl.Edad = edad;

            // Añadimos el objeto recién creado a la lista.
            mLista.Add(empl);
        }

        public string MostrarListaEmpleados2()
        {
            string texto = "Lista de Empleados:\n";

            foreach(Empleado empl in mLista)
            {
                texto = texto + empl.MostrarDatos();
            }

            return texto;
        }

        public string MostrarListaEmpleados()
        {
            string texto = "Lista de Empleados:\n";

            for (int i=0;i<mLista.Count;i++)
            {
                Empleado emp = mLista[i];
                texto = texto + emp.MostrarDatos();
            }

            return texto;
        }


        // Método privado que busca por nombre la posicion
        // de un empleado en la lista. -1 si no lo encuentra.
        private int BuscarEmpleado(string nombre)
        {
            int pos = -1, i;
            bool encontrado = false;
            Empleado empl;

            i = 0;
            while (i < mLista.Count && !encontrado)
            {
                empl = mLista[i];
                if (empl.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }

        // Método que se le pasa el nombre del empleado y la venta.
        // Si lo encuentra le añade esa venta.
        // Devuelve cierto o falso según se haya podido encontrar y añadir la venta.
        public bool AnyadirVenta(string nombre, double venta)
        {
            int pos;
            Empleado empl;
            bool encontrado = false;

            pos = BuscarEmpleado(nombre);
            if (pos >= 0)
            {
                empl = mLista[pos];
                empl.AnyadirVenta(venta);
                encontrado = true;
            }

            return encontrado;
        }

        // Método que se le pasa el nombre del empleado.
        // Si lo encuentra llama a su método Cumpleanyos
        // Devuelve cierto si se ha encontrado el empleado
        public bool Cumpleanyos(string nombre)
        {
            int pos;
            Empleado empl;
            bool encontrado = false;

            pos = BuscarEmpleado(nombre);
            if (pos >= 0)
            {
                empl = mLista[pos];
                empl.CumpleAnyos();
                encontrado = true;
            }

            return encontrado;            
        }
    }
}
