using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public partial class fAlumnos : Form
    {
        public fAlumnos(ListaAlumnos listaAlumnos, ListaCursos listaCursos)
        {
            InitializeComponent();
            this.listaAlumnos = listaAlumnos;
            this.listaCursos = listaCursos;
        }
        public ListaAlumnos listaAlumnos;
        public ListaCursos listaCursos;

        private void btnAgregarAlum_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Introduce nombre del Alumno");
                string dni = Interaction.InputBox("Introduce DNI del Alumno");
                string telf = Interaction.InputBox("Introduce número de télefono del Alumno");
                int codCurso = int.Parse(Interaction.InputBox("Introduce el código del curso al que quieres agregar al alumno"));
                int pos = listaCursos.BuscarCurso(codCurso);
                if(pos != -1)
                {
                    listaAlumnos.AgregarAlumno(nombre, dni, telf, codCurso);
                    MessageBox.Show("** El alumno " + "'" + nombre + "'" + " ha sido agregado exitosamente **");
                }
                else
                {
                    MessageBox.Show("El curso no existe");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fomato incorrecto");
            }

        }

        private void btnBorrarAlum_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Alumnos **");
            }
            else
            {
                string dni = Interaction.InputBox("Introduce DNI del alumno que desea eliminar:");
                bool eliminado = listaAlumnos.EliminarAlumno(dni);
                if (eliminado)
                {
                    MessageBox.Show("** Alumno eliminado exitosamente **");
                }
                else
                {
                    MessageBox.Show("** Alumno no encontrado **");
                }
            }
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Alumnos **");
            }
            else
            {
                string alumnos = listaAlumnos.MostrarListaAlumnos();
                MessageBox.Show(alumnos);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Alumnos **");
            }
            else
            {
                listaAlumnos.OrdenarAlumAlfabeticamente();
                MessageBox.Show("** Lista de alumnos ordenada correctamente **");
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Alumnos **");
            }
            else
            {
                string dni = Interaction.InputBox("Introduce el DNI de alumno:");
                int pos = listaAlumnos.BuscarAlumno(dni);
                if (pos == -1)
                {
                    MessageBox.Show("** Alumno no encontrado **");
                }
                else
                {
                    string msg = listaAlumnos.MostrarDatosAluPorDni(dni);
                    MessageBox.Show(msg);
                }
            }
        }

        private void btnMostrarAlumCur_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No existen Alumnos **");
            }
            else
            {
                try
                {
                    int codCurso = int.Parse(Interaction.InputBox("Introduce código del curso para ver los alumnos inscritos:"));
                    int pos = listaCursos.BuscarCurso(codCurso);
                    if (pos >= 0)
                    {
                        string alumInscritos = listaAlumnos.MostrarAlumnosInscritos(codCurso);
                        MessageBox.Show(alumInscritos);
                        if (alumInscritos == "")
                        {
                            MessageBox.Show("** No se han encontrado alumnos inscritos en este curso **");
                        }
                    }
                    else
                    {
                        MessageBox.Show("** Curso no encontrado **");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Fomato incorrecto");
                }
                
            }
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No existen Alumnos **");
            }
            else
            {
                string dni = Interaction.InputBox("Introduce el DNI de alumno:");
                double nota = double.Parse(Interaction.InputBox("Introduce la nota a agregar:"));
                int pos = listaAlumnos.BuscarAlumno(dni);
                if (nota < 1)
                {
                    MessageBox.Show("** Nota introducida es inválida **");
                }
                if (pos >= 0)
                {
                    listaAlumnos.AgregarNota(dni, nota);
                    MessageBox.Show("** Nota agregada exitosamente **");
                }
                else
                {
                    MessageBox.Show("** Alumno no encontrado **");
                }
            }
        }

        private void btnMostrarAluNotaMayor5_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No existen Alumnos **");
            }
            else
            {
                string msg = listaAlumnos.MostrarAlumNotaMediaMayor5();
                if (msg == "")
                {
                    MessageBox.Show("** No hay alumnos con nota media mayor o igual que 5 **");
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No existen Alumnos **");
            }
            else
            {
                string dni = Interaction.InputBox("Introduce DNI del alumno al que desea eliminar notas:");
                listaAlumnos.EliminarNota(dni);
                int pos = listaAlumnos.BuscarAlumno(dni);
                if (pos >= 0)
                {
                    MessageBox.Show("** Nota eliminada exitosamente **");
                }
                else
                {
                    MessageBox.Show("** Alumno no encontrado **");
                }
            }
        }

        private void btnbtnMostrarAluNotaMenor5_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.ListaVacia())
            {
                MessageBox.Show("** No existen Alumnos **");
            }
            else
            {
                string msg = listaAlumnos.MostrarAlumNotaMediaMenor5();
                if(msg == "")
                {
                    MessageBox.Show("** No hay alumnos con nota media menor que 5 **");
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
        }
    }
}
