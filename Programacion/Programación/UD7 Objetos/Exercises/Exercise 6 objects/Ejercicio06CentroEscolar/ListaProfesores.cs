using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class ListaProfesores
    {
        //TODO propiedades
        private List<Profesor> listaProfesores;

        //TODO constructor
        public ListaProfesores()
        {
            listaProfesores = new List<Profesor>();
        }

        //TODO método para agregar profesor a listaProfesores
        public void AgregarProfesor(string nombre, string dni, string asignatura, int codCurso)
        {
            Profesor profesor = new Profesor();
            profesor.Nombre = nombre;
            profesor.Dni = dni;
            //profesor.AgregarAsignatura = asignatura;
            profesor.CodigoCurso = codCurso;
            listaProfesores.Add(profesor);
        }

        //TODO método para buscar profesor
        public int BuscarProfesor(string dni)
        {
            int pos = -1;
            bool encontrado = false;
            int i = 0;
            Profesor profesor;

            while (i < listaProfesores.Count && !encontrado)
            {
                profesor = listaProfesores[i];
                if (profesor.Dni == dni)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }

        //TODO método para eliminar profesor (por su dni)
        public bool EliminarProfesor(string dni)
        {
            bool eliminado = false;
            int pos = BuscarProfesor(dni);
            if (pos != -1)
            {
                listaProfesores.RemoveAt(pos);
                eliminado = true;
            }
            return eliminado;
        }

        //TODO método para mostrar lista profesores
        public string MostrarListaProfesores()
        {
            string msg = "Los Profesores registrados son:\n\n";

            foreach (Profesor profesor in listaProfesores)
            {
                msg += profesor.Nombre + "\n";
            }
            return msg;
        }

        //TODO método para comparar nombres de profesores
        private bool CompararNombreProf(Profesor prof1, Profesor prof2)
        {
            bool nombreMayor = false;
            if (string.Compare(prof1.Nombre, prof2.Nombre) <= 0)
            {
                nombreMayor = true;
            }
            return nombreMayor;
        }

        //TODO método para ordenar profesores por orden alfabético
        public void OrdenarProfAlfabeticamente()
        {
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                for (int j = i + 1; j < listaProfesores.Count; j++)
                {
                    if (CompararNombreProf(listaProfesores[j], listaProfesores[i]))
                    {
                        Profesor profesor = listaProfesores[i];
                        listaProfesores[i] = listaProfesores[j];
                        listaProfesores[j] = profesor;
                    }
                }
            }
        }

        //TODO método para mostrar datos de profesores (por dni)
        public string MostrarDatosProfPorDni(string dni)
        {
            Profesor profesor;
            int pos = BuscarProfesor(dni);
            string msg = "";

            if (pos != -1)
            {
                profesor = listaProfesores[pos];
                msg += profesor.MostrarDatosProfesor();
            }
            return msg;
        }

        //TODO método para añadir asignatura a profesor
        public bool AsignarAsignatura(string dni, string asignatura)
        {
            Profesor profesor;
            int pos = BuscarProfesor(dni);
            bool encontrado = false;

            if (pos != -1)
            {
                profesor = listaProfesores[pos];
                encontrado = profesor.AgregarAsignatura(asignatura);                
            }
            return encontrado;
        }

        //TODO método para eliminar asignatura
        public bool EliminarAsignatura(string dni)
        {
            Profesor profesor;
            int pos = BuscarProfesor(dni);
            bool encontrado = false;

            if (pos != -1)
            {
                profesor = listaProfesores[pos];
                profesor.EliminarAsignatura();
                encontrado = true;
            }
            return encontrado;
        }

        //TODO método comprobar si lista esta vacia 
        public bool ListaVacia()
        {
            bool vacio = false;
            if(listaProfesores.Count <= 0) 
            {
                vacio = true;
            }
            return vacio;
        }
        //TODO método para comprobar si el profesor imparte la asignatura
        public bool TieneAsignatura(string dni, string asignatura)
        {
            bool existe = false;
            int pos = BuscarProfesor(dni);
            if(pos != -1)
            {
                Profesor profesor = listaProfesores[pos];
                if (profesor.ListaAsignaturas.Contains(asignatura))
                {
                    existe = true;
                }
            }
            return existe;
        }
        //TODO método mostrar profesores con asignaturas
        public string MostrarProfesoresConAsignaturas(string asignatura)
        {
            string msg = "Los profesores que imparten asignaturas son: ";
            for(int i = 0;  i < listaProfesores.Count; i++)
            {
                Profesor profesor = listaProfesores[i];
                if (profesor.TieneAsignatura(asignatura))
                {
                    msg += profesor.Nombre + "\n";
                }
            }
            return msg;
        }

        public void OrdenarProfAlfabeticamente()
        {
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                for (int j = i + 1; i < listaPersonas.Count; j++)
                {
                    Persona persona1;
                    Persona persona2;

                    if (persona1.GetType() == typeof(Profesor) && persona2.GetType() == typeof(Profesor))
                    {
                        if (string.Compare(persona1.Nombre, persona2.Nombre) < 0)
                        {
                            Persona aux = listaPersonas[i];
                            persona1 = listaPersonas[j];
                            persona2 = aux;
                        }
                    }
                }
            }
        }
    }
}
