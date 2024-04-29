using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public class Profesor : Persona
    {
        //TODO propiedades
        private List<string> listaAsignaturas;
        private int codCursoTutor;
        private string correo;

        public List<string> ListaAsignaturas
        {
            get { return listaAsignaturas; }
            set { listaAsignaturas = value; }
        }

        public int CodigoCurso
        {
            get { return codCursoTutor; }
            set { codCursoTutor = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        //TODO Constructor. Llama al constructor de Persona
        public Profesor(string nombre, string dni, string telefono, int codCursoTutor, string correo) : base(nombre, dni, telefono)
        {
            listaAsignaturas = new List<string>();
            this.codCursoTutor = codCursoTutor;
            this.correo = correo;
        }

        public Profesor(string nombre, string dni, string telefono, string correo) : base(nombre, dni, telefono)
        {
            listaAsignaturas = new List<string>();
            this.correo = correo;
        }
        public override string ToString()
        {
            string texto = "";

            texto = base.ToString() + "\n";
            texto += "Correo: " + correo + "\n";
            texto += "Tutor del curso: " + codCursoTutor + "\n";
            texto += MostrarAsignaturas();
            texto += "\n..........................................\n";

            return texto;
        }

        //TODO método para agregar asignaturas
        public bool AgregarAsignatura(string asignatura)
        {
            bool contiene = false; 
            if (!listaAsignaturas.Contains(asignatura))
            {
                listaAsignaturas.Add(asignatura);
                contiene = true; 
            }
            return contiene;
        }


        //TODO método eliminar asignatura
        public void EliminarAsignatura()
        {
            for (int i = 0; i < listaAsignaturas.Count; i++)
            {
                listaAsignaturas.RemoveAt(i);
            }
        }

        //TODO método mostrar asignaturas
        public string MostrarAsignaturas()
        {
            string texto = "Asignaturas:\n";
            for (int i = 0; i < listaAsignaturas.Count; i++)
            {
                texto += listaAsignaturas[i] + "\n";
            }
            return texto;
        }

        //TODO método comprobar si tiene asignatura asignada
        public bool ImparteAsignatura(string asignatura)
        {
            bool contiene = false;
            for(int i = 0; i < listaAsignaturas.Count && !contiene; i++)
            {
                if(listaAsignaturas[i] == asignatura)
                {
                    contiene = true;
                }
            }
            return contiene;
        }      
    }
}
