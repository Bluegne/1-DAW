using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio06CentroEscolar
{
    internal class Alumno
    {
        //TODO propiedades 
        private string mNombre;
        private string mDni;
        private string mTelefono;
        private List<double> mListaNotas;
        private int mCodCurso;

        //TODO dar accesibilidad a las propiedades
        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string Dni
        {
            get { return mDni; }
            set { mDni = value; }
        }

        public string Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }

        public List<double> ListaNotas
        {
            get { return mListaNotas; }
            set { mListaNotas = value; }
        }

        public int CodigoCurso 
        {
            get { return mCodCurso; }
            set { mCodCurso = value; }
        }

        //TODO constructor
        public Alumno()
        {
            mNombre = "";
            mDni = "";
            mTelefono = "";
            mListaNotas = new List<double>();
        }

        //TODO método mostrar datos Alumno
        public string MostrarDatosAlumnos()
        {
            string msg = "";

            msg += "\nNombre alumno: " + mNombre + "\n";
            msg += "DNI: " + mDni + "\n";
            msg += "Telf: " + mTelefono + "\n";
            msg += "Inscrito en el curso: " + mCodCurso + "\n";
            msg += MostrarNotas();
            msg += "\n..........................................\n";

            return msg;
        }

        //TODO método para agregar notas
        public void AgregarNota(double nota)
        {
            if (nota >= 1 && nota <= 10)
            {
                mListaNotas.Add(nota);
            }            
        }

        //TODO método eliminar notas
        public void EliminarNotas()
        {
            for (int i = 0; i < mListaNotas.Count; i++)
            {
                mListaNotas.RemoveAt(i);
            }
        }

        //TODO método sumar nota
        public double SumarNota()
        {
            double sumaNota = 0;
            foreach (double nota in mListaNotas)
            {
                sumaNota += nota;
            }
            return sumaNota;
        }

        //TODO método contar nota
        public double ContarNota()
        {
            double totalNotas = ListaNotas.Count;
            return totalNotas;
        }


        //TODO método mostrar notas
        public string MostrarNotas()
        {
            string msg = "Notas:\n";
            foreach (double nota in mListaNotas)
            {
                msg += nota + "\n";
            }
            return msg;
        }
    }
}
