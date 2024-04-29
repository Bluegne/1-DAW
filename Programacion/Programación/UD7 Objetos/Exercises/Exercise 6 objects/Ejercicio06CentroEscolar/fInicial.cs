using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        // Creamos la lista de cursos.
        ListaCursos listaCursos = new ListaCursos();
        ListaAlumnos listaAlumnos = new ListaAlumnos();
        ListaProfesores listaProfesores = new ListaProfesores();
        // Crear aquí también la lista de profesores y de alumnos.

        private void bCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos(listaCursos, listaAlumnos); //creo un objeto 'formulario' de cursos

            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.
            
            fCur.ShowDialog(); //esto hace que se abra el formulario, que aparezca
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            fAlumnos fAlum = new fAlumnos(listaAlumnos, listaCursos);
            fAlum.ShowDialog();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            fProfesores fProfesores = new fProfesores(listaCursos, listaProfesores);
            fProfesores.ShowDialog();
        }
    }
}
