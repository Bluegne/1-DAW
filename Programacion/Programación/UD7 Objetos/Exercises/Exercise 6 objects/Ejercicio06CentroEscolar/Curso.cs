using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    internal class Curso
    {
        //TODO crear propiedades 
        private string mNombre;
        private int mCodigo;
        private List<string> mListaAlumnos;

        //TODO dar accesibilidad a las propiedades
        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public int Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        public List<string> AlumnosInscritos
        {
            get { return mListaAlumnos; }
            set { mListaAlumnos = value;}
        }

        //TODO constructor
        public Curso() 
        {
            mNombre = "";
            mCodigo = 0;
            mListaAlumnos = new List<string>();
        }



    }
}
