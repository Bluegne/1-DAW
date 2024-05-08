using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDBHelper sqlDBHelper;
        private int pos;

        void ActualizarLblRegistros(int pos, int numAnimes)
        {
            lblRegistro.Text = "Registro " + (pos + 1) + " de " + numAnimes;
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

        void OnOffBotonSiguiente()
        {
            if (pos < 0)
            {
                btnSiguiente.Enabled = false;
            }
            else if (pos == sqlDBHelper.NumAnimes - 1) 
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }
        bool ComprobarCampos()
        {
            bool valido = false;
            if(txtTitulo.Text != "" && txtGenero.Text != "" && txtEstudio.Text != "" && txtEpisodios.Text != "" && txtAnyo.Text != "" && txtEstado.Text != "") 
            {
                for (int i = 0; i < txtEpisodios.TextLength; i++)
                {
                    if (char.IsNumber(txtEpisodios.Text[i]))
                    {
                        valido = true;
                    }
                }
            }
            return valido;
        }

        bool ComprobarCambios(int pos)
        {
            Anime anime = sqlDBHelper.DevuelveAnime(pos);
            bool valido = false;

            if (txtTitulo.Text != anime.Titulo || txtGenero.Text != anime.Genero || txtEstudio.Text != anime.Estudio || txtEpisodios.Text != anime.TotalEpisodios.ToString() || txtAnyo.Text != anime.AnyoLanzamiento && txtEstado.Text != anime.Estado)
            {
                for (int i = 0; i < txtEpisodios.TextLength; i++)
                {
                    if (char.IsNumber(txtEpisodios.Text[i]))
                    {
                        valido = true;
                    }
                }
            }
            return valido;
        }

        private void mostrarRegistro(int pos)
        {
            Anime anime = sqlDBHelper.DevuelveAnime(pos);

            txtTitulo.Text = anime.Titulo;
            txtGenero.Text = anime.Genero;
            txtEstudio.Text = anime.Estudio;
            txtEpisodios.Text = anime.TotalEpisodios.ToString();
            txtAnyo.Text =  anime.AnyoLanzamiento;
            txtEstado.Text = anime.Estado;
            OnOffBotonAnterior();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = false;
            sqlDBHelper = new SqlDBHelper();
            pos = 0;
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumAnimes);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            pos = 0;
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumAnimes);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            OnOffBotonAnterior();
            OnOffBotonSiguiente();
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumAnimes);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos == sqlDBHelper.NumAnimes - 1)
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnAnterior.Enabled = true;
            }
            mostrarRegistro(pos);
            OnOffBotonAnterior();
            OnOffBotonSiguiente();
            ActualizarLblRegistros(pos, sqlDBHelper.NumAnimes);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
            pos = sqlDBHelper.NumAnimes - 1;
            mostrarRegistro(pos);
            OnOffBotonAnterior();
            OnOffBotonSiguiente();
            ActualizarLblRegistros(pos, sqlDBHelper.NumAnimes);
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtGenero.Clear();
            txtEstudio.Clear();
            txtEpisodios.Clear();
            txtAnyo.Clear();
            txtEstado.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Anime anime = new Anime(txtTitulo.Text, txtGenero.Text, int.Parse(txtEpisodios.Text), txtEstudio.Text, txtAnyo.Text, txtEstado.Text);
            sqlDBHelper.AnyadirAnime(anime);
            pos = sqlDBHelper.NumAnimes - 1;
            ActualizarLblRegistros(pos, sqlDBHelper.NumAnimes);
            btnSiguiente.Enabled = false;
            MessageBox.Show(anime.Titulo + " ha sido agregado correctamente.");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Anime anime = new Anime(txtTitulo.Text, txtGenero.Text, int.Parse(txtEpisodios.Text), txtEstudio.Text, txtAnyo.Text, txtEstado.Text);
            sqlDBHelper.ActualizarAnime(anime, pos);
            MessageBox.Show("Los datos de " + anime.Titulo + " han sido actualizados correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sqlDBHelper.EliminarAnime(pos);
            pos = pos - 1;
            MessageBox.Show("Anime eliminado correctamente.");
            mostrarRegistro(pos);
            ActualizarLblRegistros(pos, sqlDBHelper.NumAnimes);
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                btnGuardar.Enabled = true;
            }
            else if (ComprobarCambios(pos))
            {
                btnActualizar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void btnBuscarPorGenero_Click(object sender, EventArgs e)
        {
            string genero = Interaction.InputBox("Por favor ingrese el género:");
            string text = "";

            for(int i = 0; i < sqlDBHelper.NumAnimes - 1; i++)
            {
                Anime anime = sqlDBHelper.DevuelveAnime(i);
                string lowerGenre = anime.Genero.ToLower();
                if (lowerGenre == genero)
                {
                    text += "- " + anime.Titulo + "\n";
                }
                else
                {
                    MessageBox.Show("No se han encontrado animes de ese género en el sistema.");
                }
            }
            MessageBox.Show(text);
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            string text = "";

            for (int i = 0; i < sqlDBHelper.NumAnimes - 1; i++)
            {
                Anime anime = sqlDBHelper.DevuelveAnime(i);
                text += "- " + anime.Titulo + "\n";
            }
            MessageBox.Show(text);
        }

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            string titulo = Interaction.InputBox("Por favor ingrese el título del Anime:");
            string text = "";
            titulo.ToLower();
            for (int i = 0; i < sqlDBHelper.NumAnimes - 1; i++)
            {
                Anime anime = sqlDBHelper.DevuelveAnime(i);
                string lowerTitle = anime.Titulo.ToLower();
                if (lowerTitle == titulo)
                {
                    text = sqlDBHelper.MostrarDatos(anime, i);
                }
                else
                {
                    MessageBox.Show("El anime " + titulo + "no se ha encontrado en el sistema.");
                }
            }
            MessageBox.Show(text);
        }

        private void btnBuscarPorAnyo_Click(object sender, EventArgs e)
        {
            string anyo = Interaction.InputBox("Por favor ingrese el año:");
            string text = "";
            for (int i = 0; i < sqlDBHelper.NumAnimes - 1; i++)
            {
                Anime anime = sqlDBHelper.DevuelveAnime(i);;
                if (anyo == anime.AnyoLanzamiento)
                {
                    text += "- " + anime.Titulo + "\n";
                }
                else
                {
                    MessageBox.Show("No se ha encontrado animes del año " + anyo);
                }
            }
            MessageBox.Show(text);
        }
    }
}
