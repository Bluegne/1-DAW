using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    internal class Profesor
    {
        //TODO propiedades
        private string mNombre;
        private string mDni;
        private string mTelefono;
        private List<string> mListasAsignaturas;
        private int mCodCurso;

        //TODO dar accesibilidad a las propiedades
        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string Dni
        { 
            get {  return mDni; } 
            set {  mDni = value; } 
        }

        public string Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }

        public List<string> ListaAsignaturas
        {
            get { return mListasAsignaturas; }
            set { mListasAsignaturas = value; }
        }

        public int CodigoCurso
        {
            get { return mCodCurso; }
            set { mCodCurso = value; }
        }

        //TODO constructor
        public Profesor()
        {
            mNombre = "";
            mDni = "";
            mTelefono = "";
            mListasAsignaturas = new List<string>();
            mCodCurso = 0;
        }

        //TODO método mostrar datos Profesor
        public string MostrarDatosProfesor()
        {
            string msg = "";

            msg += "\nNombre Profesor: " + mNombre + "\n";
            msg += "DNI: " + mDni + "\n";
            msg += "Telf: " + mTelefono + "\n";
            msg += MostrarAsignaturas();
            msg += "\n..........................................\n";

            return msg;
        }

        //TODO método para agregar asignaturas
        public bool AgregarAsignatura(string asignatura)
        {
            bool contiene = true;
            if (!mListasAsignaturas.Contains(asignatura))
            {
                mListasAsignaturas.Add(asignatura);
                contiene = false;
            }
            return contiene;
        }

        //TODO método eliminar asignatura
        public void EliminarAsignatura()
        {
            for (int i = 0; i < mListasAsignaturas.Count; i++)
            {
                mListasAsignaturas.RemoveAt(i);
            }
        }

        //TODO método mostrar asignaturas
        public string MostrarAsignaturas()
        {
            string msg = "Asignaturas:\n";
            for (int i = 0; i < mListasAsignaturas.Count; i++)
            {
                msg += mListasAsignaturas[i] + "\n";
            }
            return msg;
        }

        //TODO método comprobar si tiene asignatura asignada
        public bool TieneAsignatura(string asignatura)
        {
            bool contiene = false;
            for(int i = 0; i < mListasAsignaturas.Count && !contiene; i++)
            {
                if(mListasAsignaturas[i] == asignatura)
                {
                    contiene = true;
                }
            }
            return contiene;
        }      
    }
}
