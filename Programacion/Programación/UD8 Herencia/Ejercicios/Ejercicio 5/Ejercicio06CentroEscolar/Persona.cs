using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public abstract class Persona
    {
        private string nombre;
        private string dni;
        private string telefono;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Dni
        {
          get { return dni; }
          set { dni = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Persona(string nombre, string dni, string telefono)  
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
        }
        public Persona()
        {
            nombre = "";
            dni = "";
            telefono = "";
        }
        public override string ToString()
        {
            string texto;
            texto = "Nombre: " + nombre + "\n";
            texto += "DNI: " + dni + "\n";
            texto += "Telefono: " + telefono + "\n";

            return texto;
        }
    }
}
