using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public class ListaAlumnos
    {
        //TODO propiedades
        private List<Alumno> listaAlumnos;

        //TODO constructor
        public ListaAlumnos()
        {
            listaAlumnos = new List<Alumno>();
        }

        //TODO método para agregar alumno a listaAlumno
        public void AgregarAlumno(string nombre, string dni, string telf, int codCurso)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = nombre;
            alumno.Dni = dni;
            alumno.Telefono = telf;
            alumno.CodigoCurso = codCurso;
            listaAlumnos.Add(alumno);
        }

        //TODO método para buscar alumno
        public int BuscarAlumno(string dni)
        {
            int pos = -1;
            bool encontrado = false;
            int i = 0;
            Alumno alumno;

            while (i < listaAlumnos.Count && !encontrado)
            {
                alumno = listaAlumnos[i];
                if (alumno.Dni == dni)
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

        //TODO método para eliminar alumno (por su dni)
        public bool EliminarAlumno(string dni)
        {
            bool eliminado = false;
            int pos = BuscarAlumno(dni);

            if (pos != -1)
            {
                listaAlumnos.RemoveAt(pos);
                eliminado = true;
            }
            return eliminado;
        }

        //TODO método para mostrar alumnos
        public string MostrarListaAlumnos()
        {
            string msg = "Los alumnos registrados son:\n\n";
            Alumno alumno;
            if (listaAlumnos.Count >= 0)
            {

                for (int i = 0; i < listaAlumnos.Count; i++)
                {
                    alumno = listaAlumnos[i];
                    msg += alumno.MostrarDatosAlumnos() + "\n";
                }
            }
            return msg;
        }

        //TODO método para comparar nombres de empleados
        private bool CompararNombreAlum(Alumno alu1, Alumno alu2)
        {
            bool nombreMayor = false;
            if (string.Compare(alu1.Nombre, alu2.Nombre) <= 0)
            {
                nombreMayor = true;
            }
            return nombreMayor;
        }

        //TODO método para ordenar alumnos por orden alfabético
        public void OrdenarAlumAlfabeticamente()
        {
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                for (int j = i + 1; j < listaAlumnos.Count; j++)
                {
                    if (CompararNombreAlum(listaAlumnos[j], listaAlumnos[i]))
                    {
                        Alumno alumno = listaAlumnos[i];
                        listaAlumnos[i] = listaAlumnos[j];
                        listaAlumnos[j] = alumno;
                    }
                }
            }
        }

        //TODO método para mostrar datos de alumno (por dni)
        public string MostrarDatosAluPorDni(string dni)
        {
            Alumno alumno;
            int pos = BuscarAlumno(dni);
            string msg = "";

            if (pos != -1)
            {
                alumno = listaAlumnos[pos];
                msg += alumno.MostrarDatosAlumnos();
            }
            return msg;
        }

        //TODO método para mostrar los alumnos pertenecientes a cada curso
        public string MostrarAlumnosInscritos(int codCurso)
        {
            string msg = "";
            foreach(Alumno alumno in listaAlumnos)
            {
                if (alumno.CodigoCurso == codCurso) 
                {
                    msg += alumno.Nombre + "\n";
                }
            }
            return msg;
        }

        //TODO método para añadir nota a alumno
        public bool AgregarNota(string dni, double nota)
        {
            Alumno alumno;
            int pos = BuscarAlumno(dni);
            bool encontrado = false;

            if (pos != -1)
            {
                alumno = listaAlumnos[pos];
                alumno.AgregarNota(nota);
                encontrado = true;
            }
            return encontrado;
        }


        //TODO método para mostrar alumnos con nota media >= 5
        public string MostrarAlumNotaMediaMayor5()
        {
            string msg = "Los alumnos con nota media mayor o igual que '5' son:\n\n";

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                Alumno alumno = listaAlumnos[i];
                if(alumno.SumarNota() / alumno.ContarNota() >= 5)
                {
                    msg += alumno.Nombre + "\n";
                }            
            }
            return msg;
        }

        //TODO método para mostrar alumnos con nota media menor que 5
        public string MostrarAlumNotaMediaMenor5()
        {
            string msg = "";

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                Alumno alumno = listaAlumnos[i];
                if (alumno.SumarNota() / alumno.ContarNota() < 5 )
                {
                    msg = "Los alumnos con nota media menor que '5' son:\n\n";
                    msg += alumno.Nombre + "\n";
                }
            }
            return msg;
        }
        //TODO método para eliminar nota
        public bool EliminarNota(string dni)
        {
            Alumno alumno;
            int pos = BuscarAlumno(dni);
            bool encontrado = false;

            if (pos != -1)
            {
                alumno = listaAlumnos[pos];
                alumno.EliminarNotas();
                encontrado = true;
            }
            return encontrado;
        }

        //TODO método comprobar si lista esta vacia 
        public bool ListaVacia()
        {
            bool vacio = false;
            if (listaAlumnos.Count <= 0)
            {
                vacio = true;
            }
            return vacio;
        }
    }
}
