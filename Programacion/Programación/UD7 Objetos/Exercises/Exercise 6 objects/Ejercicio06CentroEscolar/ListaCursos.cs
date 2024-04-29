using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class ListaCursos
    {
        //TODO agregar propiedades
        private List<Curso> listaCursos;

        //TODO constructor
        public ListaCursos() 
        {
            listaCursos = new List<Curso>();
        }

        //TODO método para agregar curso a listaCursos
        public void AgregarCurso(int codCurso, string nombreCurso)
        {
            Curso curso = new Curso();
            curso.Codigo = codCurso;
            curso.Nombre = nombreCurso;
            listaCursos.Add(curso);
        }

        //TODO método para buscar curso (por código)
        public int BuscarCurso(int codCurso)
        {
            bool encontrado = false;
            int i = 0;
            int pos = -1;
            Curso curso;

            while (i < listaCursos.Count && !encontrado)
            {
                curso = listaCursos[i];
                if (curso.Codigo == codCurso) 
                {
                    encontrado = true;
                    pos = i;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }

        //TODO método para eliminar curso
        public bool EliminarCurso(int codCurso)
        {
            bool eliminado = false;
            int pos = BuscarCurso(codCurso);
            if(pos != -1)
            {
                listaCursos.RemoveAt(pos);
                eliminado = true;
            }
            return eliminado;
        }

        //TODO método para mostrar los cursos registrados
        public string MostrarCursos()
        {
            int cod;
            string nombre;
            string msg = "Los cursos registrados son:\n\n";
            for(int i = 0; i < listaCursos.Count; i++)
            {
                cod = listaCursos[i].Codigo;
                nombre = listaCursos[i].Nombre;
                msg = msg + "Cod " + cod + " " + nombre + "\n";
            }
            return msg;
        }

        //TODO método comprobar si lista esta vacia 
        public bool ListaVacia()
        {
            bool vacio = false;
            if (listaCursos.Count <= 0)
            {
                vacio = true;
            }
            return vacio;
        }

    }
}
