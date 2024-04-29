using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public partial class fProfesores : Form
    {
        public fProfesores()
        {
            InitializeComponent();
        }
        public ListaCursos listaCursos;
        public ListaProfesores listaProfesores;
        public fProfesores(ListaCursos listaCursos, ListaProfesores listaProfesores)
        {
            InitializeComponent();
            this.listaProfesores = listaProfesores;
            this.listaCursos = listaCursos;
        }

        private void bntAgregarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Introduce nombre del Profesor");
                string dni = Interaction.InputBox("Introduce DNI del Profesor");
                string telf = Interaction.InputBox("Introduce número de télefono del Profesor");
                int codCurso = int.Parse(Interaction.InputBox("Introduce el código del curso al que quieres agregar al profesor"));
                int pos = listaCursos.BuscarCurso(codCurso);
                if (pos != -1)
                {
                    listaProfesores.AgregarProfesor(nombre, dni, telf, codCurso);
                    MessageBox.Show("** El Profesor " + "'" + nombre + "'" + " ha sido agregado exitosamente **");
                }
                else
                {
                    MessageBox.Show("El curso no existe");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            string dni = Interaction.InputBox("Introduce DNI del Profesor que desea eliminar:");
            if (listaProfesores.EliminarProfesor(dni))
            {
                MessageBox.Show("** Profesor eliminado exitosamente **");
            }
            else
            {
                MessageBox.Show("** Profesor no encontrado **");
            }
        }

        private void btnMostrarListaProf_Click(object sender, EventArgs e)
        {
            if (listaProfesores.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Profesores **");
            }
            else
            {
                string profesores = listaProfesores.MostrarListaProfesores();
                MessageBox.Show(profesores);
            }
        }

        private void btnOrdenarProfAlfabeticamente_Click(object sender, EventArgs e)
        {
            if (listaProfesores.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Profesores **");
            }
            else
            {
                listaProfesores.OrdenarProfAlfabeticamente();
                MessageBox.Show("** Lista de Profesores ordenada correctamente **");
            }
        }

        private void btnMostrarDatosProf_Click(object sender, EventArgs e)
        {
            string dni = Interaction.InputBox("Introduce el DNI del Profesor:");
            int pos = listaProfesores.BuscarProfesor(dni);
            if (listaProfesores.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Profesores **");
            }
            else
            {
                if (pos == -1)
                {
                    MessageBox.Show("** Profesor no encontrado **");
                }
                else
                {
                    string msg = listaProfesores.MostrarDatosProfPorDni(dni);
                    MessageBox.Show(msg);
                }
            }
        }

        private void btnAñadirAsigProfesor_Click(object sender, EventArgs e)
        {
            string dni = Interaction.InputBox("Introduce el DNI del Profesor:");
            int pos = listaProfesores.BuscarProfesor(dni);
            if (pos != -1)
            {
                string asignatura = Interaction.InputBox("Introduce nombre de la Asignatura:");
                if (listaProfesores.TieneAsignatura(dni, asignatura))
                {
                    MessageBox.Show("** Profesor ya imparte esta asignatura **");
                }
                else
                {
                    listaProfesores.AsignarAsignatura(dni, asignatura);
                    MessageBox.Show("** Asignatura agregada exitosamente **");
                }
            }
            else
            {
                MessageBox.Show("** Profesor no encontrado **");
            }
        }

        private void btnEliminarAsigProf_Click(object sender, EventArgs e)
        {
            if (listaProfesores.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Profesores **");
            }
            else
            {
                string dni = Interaction.InputBox("Introduce DNI del Profesor al que desea eliminar asignatura:");
                if (listaProfesores.EliminarAsignatura(dni))
                {
                    MessageBox.Show("** Asignatura eliminada exitosamente **");
                }
                else
                {
                    MessageBox.Show("** Profesor no encontrado **");
                }
            }
        }

        private void btnMostrarProfImparteAsig_Click(object sender, EventArgs e)
        {
            if (listaProfesores.ListaVacia())
            {
                MessageBox.Show("** No se han registrado Profesores **");
            }
            else
            {
                string asignatura = Interaction.InputBox("Introduce nombre de la asignatura:");
                string msg = listaProfesores.MostrarProfesoresConAsignaturas(asignatura);
                MessageBox.Show(msg);
            }
        }
    }
}
