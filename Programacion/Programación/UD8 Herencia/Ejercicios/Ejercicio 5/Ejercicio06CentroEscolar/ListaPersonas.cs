using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class ListaPersonas
    {
        private List<Persona> listaPersonas;

        public ListaPersonas() 
        {
            this.listaPersonas = new List<Persona>();
        }

        public int BuscarPersona(string dni)
        {
            bool encontrado = false;
            int pos = 0;

            for(int i = 0; i < listaPersonas.Count && !encontrado; i++)
            {
                if (listaPersonas[i].Dni == dni)
                {
                    encontrado = true;
                    pos = i;
                }
            }
            return pos;
        }

        public void AgregarProfesor(string nombre, string dni, string telf, int codCurso, string correo)
        {
            Profesor profesor = new Profesor(nombre, dni, telf, codCurso, correo);
            listaPersonas.Add(profesor);
        }

        public bool ListaVacia()
        {
            bool vacio = false;
            if (listaPersonas.Count <= 0)
            {
                vacio = true;
            }
            return vacio;
        }

        public bool EliminarPersona(string dni)
        {
            bool eliminado = false;
            int pos = BuscarPersona(dni);
            if (pos != -1)
            {
                listaPersonas.RemoveAt(pos);
                eliminado = true;
            }
            return eliminado;
        }

        // profesores
        public string MostrarListaProfesores()
        {
            string texto = "Los Profesores registrados son:\n\n";

            foreach (Persona persona in listaPersonas)
            {
                if(persona.GetType() == typeof(Profesor)) 
                {
                    texto += persona.Nombre + "\n";
                }
            }
            return texto;
        }
        public string MostrarDatosProfPorDni(string dni)
        {
            int pos = BuscarPersona(dni);
            string texto = "";

            foreach (Persona persona in listaPersonas)
            {
                if (persona.GetType() == typeof(Profesor))
                {
                    if (pos != -1)
                    {
                        texto = persona.ToString();
                    }
                }
            }
            return texto;
        }

        public bool ComprobarExistenciaProfesor(string dni)
        {
            bool existe = false;
            foreach (Persona persona in listaPersonas)
            {
                if (persona.GetType() == typeof(Profesor))
                {
                    if (persona.Dni == dni)
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }

        public void OrdenarProfAlfabeticamente()
        {
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                for (int j = i + 1; j < listaPersonas.Count; j++)
                {
                    if (listaPersonas[i] is Profesor && listaPersonas[j] is Profesor) 
                    {
                        Persona profesor1 = (Profesor)listaPersonas[i];
                        Persona profesor2 = (Profesor)listaPersonas[j];

                        if (string.Compare(profesor1.Nombre, profesor2.Nombre) > 0) 
                        {
                            listaPersonas[i] = profesor2;
                            listaPersonas[j] = profesor1;
                        }
                    }
                }
            }
        }

        public bool AsignarAsignaturaProf(string dni, string asignatura)
        {
            int pos = BuscarPersona(dni);
            bool asignada = false;
            if (pos == -1)
            {
                return false;
            }
            else
            {
                Persona persona = (Profesor)listaPersonas[pos];
                if (persona.GetType() == typeof(Profesor))
                {
                    ((Profesor)persona).AgregarAsignatura(asignatura);
                    asignada = true;
                }
            }
            return asignada;
        }


        public bool EliminarAsignatura(string dni)
        {
            int pos = BuscarPersona(dni);
            bool eliminado = false;
            Profesor profesor = (Profesor)(listaPersonas[pos]);
            
            if (profesor.GetType() == typeof(Profesor))
            {
                profesor.EliminarAsignatura();
            }

            return eliminado;
        }

        public bool ComprobarListaProfesores()
        {
            bool encontrado = false;

            for (int i = 0; i < listaPersonas.Count && !encontrado; i++)
            {
                Persona persona = listaPersonas[i];
                if (persona.GetType() == typeof(Profesor))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public string MostrarProfQueImparteAsig(string asignatura)
        {
            string texto = "El profesor que imparte la asignaturas " + asignatura + " es: ";
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                Persona persona = listaPersonas[i];
                if (persona.GetType() == typeof(Profesor))
                {
                    if (((Profesor)persona).ImparteAsignatura(asignatura))
                    {
                        texto += persona.Nombre + "\n";
                    }
                }
            }
            return texto;
        }

        public bool ImparteAsignatura(string dni, string asignatura)
        {
            bool existe = false;
            int pos = BuscarPersona(dni);
            if (pos != -1)
            {
                Persona persona = listaPersonas[pos];
                if (persona.GetType() == typeof(Profesor))
                {
                    if (((Profesor)persona).ListaAsignaturas.Contains(asignatura))
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }

        // alumnos
        public void AgregarAlumno(string nombre, string dni, string telf, int codCurso)
        {
            Alumno alumno = new Alumno(nombre, dni, telf, codCurso);
            listaPersonas.Add(alumno);
        }

        public string MostrarListaAlumnos()
        {
            string texto = "Los Alumnos registrados son:\n\n";

            foreach (Persona persona in listaPersonas)
            {
                if (persona.GetType() == typeof(Alumno))
                {
                    texto += persona.Nombre + "\n";
                }
            }
            return texto;
        }

        public bool ComprobarExistenciaAlumno(string dni)
        {
            bool existe = false;
            foreach (Persona persona in listaPersonas)
            {
                if (persona.GetType() == typeof(Alumno))
                {
                    if (persona.Dni == dni)
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }

        public string MostrarDatosAlumPorDni(string dni)
        {
            int pos = BuscarPersona(dni);
            string texto = "";

            foreach (Persona persona in listaPersonas)
            {
                if (persona.GetType() == typeof(Alumno))
                {
                    if (pos != -1)
                    {
                        texto = persona.ToString();
                    }
                }
            }
            return texto;
        }

        public void OrdenarAlumAlfabeticamente()
        {
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                for (int j = i + 1; j < listaPersonas.Count; j++)
                {
                    if (listaPersonas[i] is Alumno && listaPersonas[j] is Alumno)
                    {
                        Persona alumno1 = (Alumno)listaPersonas[i];
                        Persona alumno2 = (Alumno)listaPersonas[j];

                        if (string.Compare(alumno1.Nombre, alumno2.Nombre) > 0)
                        {
                            listaPersonas[i] = alumno2;
                            listaPersonas[j] = alumno1;
                        }
                    }
                }
            }
        }

        public bool ComprobarListaAlumnos()
        {
            bool encontrado = false;
            for (int i = 0; i < listaPersonas.Count && !encontrado; i++)
            {
                 Persona persona = listaPersonas[i];
                 if (persona.GetType() == typeof(Alumno))
                 {
                    encontrado = true;
                 }
            }
            return encontrado;
        }

        public bool AgregarNota(string dni, double nota)
        {
            int pos = BuscarPersona(dni);
            bool encontrado = false;

            for (int i = 0; i < listaPersonas.Count && !encontrado; i++)
            {
                Persona persona = listaPersonas[i];
                if (persona.GetType() == typeof(Alumno))
                {
                    if (pos != -1)
                    {
                        persona = listaPersonas[pos];
                        ((Alumno)persona).AgregarNota(nota);
                        encontrado = true;
                    }
                }
            }
            return encontrado;
        }

        public string MostrarAlumNotaMediaMayor5()
        {
            string texto = "Los alumnos con nota media mayor o igual que '5' son:\n\n";

            for (int i = 0; i < listaPersonas.Count; i++)
            {
                Persona persona = listaPersonas[i];
                if (persona.GetType() == typeof(Alumno))
                {
                    if (((Alumno)persona).SumarNota() / ((Alumno)persona).ContarNota() >= 5)
                    {
                        texto += persona.Nombre + "\n";
                    }
                }
            }
            return texto;
        }

        public string MostrarAlumNotaMediaMenor5()
        {
            string texto = "";

            for (int i = 0; i < listaPersonas.Count; i++)
            {
                Persona persona = listaPersonas[i];
                if (persona.GetType() == typeof(Alumno))
                {
                    if (((Alumno)persona).SumarNota() / ((Alumno)persona).ContarNota() < 5)
                    {
                        texto = "Los alumnos con nota media menor que '5' son:\n\n";
                        texto += persona.Nombre + "\n";
                    }
                }
               
            }
            return texto;
        }
        public bool EliminarNotaAlum(string dni)
        {
            int pos = BuscarPersona(dni);
            bool eliminado = false;
            Persona persona = listaPersonas[pos];

            if (persona.GetType() == typeof(Alumno))
            {
                ((Alumno)persona).EliminarNotas();
            }

            return eliminado;
        }

        public string MostrarAlumInscritos(int codCurso)
        {
            string texto = "";
            Persona persona;

            for (int i = 0; i < listaPersonas.Count; i++)
            {
                persona = listaPersonas[i];
                if (persona.GetType() == typeof(Alumno))
                {
                    if (((Alumno)persona).CodCurso == codCurso)
                    {
                        texto += persona.Nombre + "\n";
                    }
                }
            }
            return texto;
        }
    }
}
