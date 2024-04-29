using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio06CentroEscolar
{
    public partial class fCursos : Form
    {
        public fCursos()
        {
            InitializeComponent();
        }

        public ListaCursos listaCursos;
        public ListaAlumnos listaAlumnos;
       // public ListaAlumnos listaAlumnos; //necesaria para el botón de mostrar los alumnos por curso.

        private void fCursos_Load(object sender, EventArgs e)
        {

        }
        public fCursos(ListaCursos listaCursos, ListaAlumnos listaAlumnos)
        {
            InitializeComponent();
            // Ponemos en la lista de cursos del formulario la lista
            // de cursos que se pasa desde el formulario inicial
            this.listaCursos = listaCursos;
            this.listaAlumnos = listaAlumnos;
        }

        private void btnAñadirCurso_Click(object sender, EventArgs e)
        {
            try
            {
                int codCurso = int.Parse(Interaction.InputBox("Introdzca el código del curso"));
                string nombreCurso = Interaction.InputBox("Introduzca el nombre del curso");
                listaCursos.AgregarCurso(codCurso, nombreCurso);
                MessageBox.Show("El curso " + "'" + nombreCurso + "'" + " ha sido agregado bajo el código " + codCurso + " exitosamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaCursos.ListaVacia())
                {
                    MessageBox.Show("** No se han registrado cursos **");
                }
                else
                {
                    int codCurso = int.Parse(Interaction.InputBox("Introduzca el código del curso que desea eliminar."));
                    bool eliminado = listaCursos.EliminarCurso(codCurso);
                    if (eliminado)
                    {
                        MessageBox.Show("El curso con el código " + codCurso + " ha sido eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("** El curso con el código " + codCurso + " no se encuentra en la lista **");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Formato incorrecto");
            }  
        }

        private void btnMostrarCursos_Click(object sender, EventArgs e)
        {
            if (listaCursos.ListaVacia())
            {
                MessageBox.Show("** No se han registrado cursos **");
            }
            else
            {
                string cursos = listaCursos.MostrarCursos();
                MessageBox.Show(cursos);
            }
        }

        private void btnAlumnosCursos_Click(object sender, EventArgs e)
        {
            try
            {
                int codCurso = int.Parse(Interaction.InputBox("Introduzca el código del curso."));
                int pos = listaCursos.BuscarCurso(codCurso);
                if (pos != -1)
                {
                    if (listaAlumnos.ListaVacia())
                    {
                        MessageBox.Show("** No se han registrado alumnos **");
                    }
                    else
                    {
                        string aluInscritos = listaAlumnos.MostrarAlumnosInscritos(codCurso);
                        MessageBox.Show(aluInscritos);
                    }
                }
                else
                {
                    MessageBox.Show("** No se han registrado cursos **");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Formato incorrecto");
            }
            
        }
    }
}
