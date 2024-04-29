using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Microsoft.Win32;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDBHelper sqlDBHelper;
        private int pos;
        void ActualizarLblRegistros(int pos, int numProfesores)
        {
            lblRegistro.Text = "Registro " + (pos + 1) + " de " + numProfesores;
        }

        void OnOffBotonAnterior()
        {
            if (pos > 0)
            {
                btnAnterior.Enabled = true;
            }
            else
            {
                btnAnterior.Enabled = false;
            }
        }

        bool ValidarCampos()
        {
            bool validado = true;
            if (!Validaciones.ComprobarDni(txtDni.Text))
            {
                validado = false;
            }
            if (!Validaciones.ComprobarNombre(txtNombre.Text))
            {
                validado = false;
            }
            if (!Validaciones.ComprobarNombre(txtApellidos.Text))
            {
                validado = false;
            }
            if (!Validaciones.ComprobarTlf(txtTlf.Text))
            {
                validado = false;
            }
            if (!Validaciones.ComprobarEmail(txteMail.Text))
            {
                validado = false;
            }
            return validado;
        }

        private void mostrarRegistro(int pos)
        {
            Profesor profesor = sqlDBHelper.devuelveProfesor(pos);

            txtDni.Text = profesor.Dni;
            txtNombre.Text = profesor.Nombre;
            txtApellidos.Text = profesor.Apellidos;
            txtTlf.Text = profesor.Tlf;
            txteMail.Text = profesor.eMail;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlDBHelper = new SqlDBHelper();            
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = false;

            pos = 0;
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumProfesores);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {            
            btnSiguiente.Enabled = true;
            pos = 0;
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumProfesores);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            OnOffBotonAnterior();
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumProfesores);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {            
            pos++;
            if (pos == sqlDBHelper.NumProfesores - 1)
            {
                btnSiguiente.Enabled = false;
            }
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumProfesores);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
            pos = sqlDBHelper.NumProfesores - 1;
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumProfesores);
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtApellidos.Clear();
            txteMail.Clear();
            txtNombre.Clear();
            txtTlf.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor(txtDni.Text, txtNombre.Text, txtApellidos.Text, txtTlf.Text, txteMail.Text);

            sqlDBHelper.anyadirProfesor(profesor);
            pos = sqlDBHelper.NumProfesores - 1;
            ActualizarLblRegistros(pos, sqlDBHelper.NumProfesores);
            btnSiguiente.Enabled = false;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Creamos el profesor con los datos del formulario
            Profesor profesor = new Profesor(txtDni.Text, txtNombre.Text,
            txtApellidos.Text, txtTlf.Text, txteMail.Text);
            sqlDBHelper.actualizarProfesor(profesor, pos);

            //TODO activar boton actualizar. No permitir el boton guardar sin haberle dado antes a añadir. Si no se le ha dado,
            //se entiende que se quiere actualizar
        }       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sqlDBHelper.eliminarProfesor(pos);
            pos = pos - 1;
            MessageBox.Show("Profesor eliminado correctamente");
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumProfesores);
        }
    }
}
