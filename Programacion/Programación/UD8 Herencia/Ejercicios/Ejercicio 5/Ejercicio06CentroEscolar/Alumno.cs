using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio06CentroEscolar
{
    public class Alumno : Persona
    {
        //TODO propiedades 
        private List<double> listaNotas;
        private int codCurso;

        public List<double> ListaNotas
        {
            get { return listaNotas; }
            set { listaNotas = value; }
        }

        public int CodCurso
        {
            get { return codCurso; }
            set { codCurso = value; }
        }

        //TODO Constructor. Llama al constructor de Persona
        public Alumno(string nombre, string dni, string telf, int codCurso) : base(nombre, dni, telf)
        {
            listaNotas = new List<double>();
            this.codCurso = codCurso;
        }

        public override string ToString()
        {
            string texto = "";

            texto = base.ToString() + "\n";
            texto += "Inscrito en el curso: " + codCurso + "\n";
            texto += MostrarNotas();
            texto += "\n..........................................\n";

            return texto;
        }

        //TODO método para agregar notas
        public void AgregarNota(double nota)
        {
            if (nota >= 1 && nota <= 10)
            {
                listaNotas.Add(nota);
            }            
        }

        //TODO método eliminar notas
        public void EliminarNotas()
        {
            for (int i = 0; i < listaNotas.Count; i++)
            {
                listaNotas.RemoveAt(i);
            }
        }

        //TODO método sumar nota
        public double SumarNota()
        {
            double sumaNota = 0;
            foreach (double nota in listaNotas)
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
            string tetxo = "Notas:\n";
            foreach (double nota in listaNotas)
            {
                tetxo += nota + "\n";
            }
            return tetxo;
        }
    }
}
