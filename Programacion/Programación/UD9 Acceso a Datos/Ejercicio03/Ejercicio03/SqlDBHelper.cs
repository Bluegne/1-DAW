using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio03
{
    internal class SqlDBHelper
    {
        private DataSet dataSetAnimes;
        private SqlDataAdapter daAnimes;
        private int _numAnimes;

        public int NumAnimes
        {
            get => _numAnimes;
        }
        // Constructor del objeto.
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            string relative = @"..\..\AppData\Anime.mdf";
            string absolute = Path.GetFullPath(relative);
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + absolute + " ;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);

            con.Open();
            string cadenaSQL = "SELECT * From Anime";
            daAnimes = new SqlDataAdapter(cadenaSQL, con);
            dataSetAnimes = new DataSet();
            daAnimes.Fill(dataSetAnimes, "Animes");

            _numAnimes = dataSetAnimes.Tables["Animes"].Rows.Count;

            con.Close();
        }
        public Anime DevuelveAnime(int pos)
        {
            Anime anime = null;
            if (pos >= 0 && pos < _numAnimes)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dataSetAnimes.Tables["Animes"].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y creamos el objeto profesor con esos datos.
                anime = new Anime(dRegistro[1].ToString(), dRegistro[2].ToString(), Convert.ToInt16(dRegistro[3]), dRegistro[4].ToString(), dRegistro[5].ToString(), dRegistro[6].ToString());
            }
            return anime;
        }
        private void ReconectarBD()
        {
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daAnimes);
            daAnimes.Update(dataSetAnimes, "Animes");
        }
        public void AnyadirAnime(Anime anime)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dataSetAnimes.Tables["Animes"].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro[0] = -1;
            dRegistro[1] = anime.Titulo;
            dRegistro[2] = anime.Genero;
            dRegistro[3] = anime.TotalEpisodios;
            dRegistro[4] = anime.Estudio;
            dRegistro[5] = anime.AnyoLanzamiento;
            dRegistro[6] = anime.Estado;

            dataSetAnimes.Tables["Animes"].Rows.Add(dRegistro);
            // Reconectamos y actualizamos la BD
            ReconectarBD();
            // Actualizamos el número de profesores
            _numAnimes++;
        }
        public void ActualizarAnime(Anime anime, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetAnimes.Tables["Animes"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro[0] = -1;
            dRegistro[1] = anime.Titulo;
            dRegistro[2] = anime.Genero;
            dRegistro[3] = anime.TotalEpisodios;
            dRegistro[4] = anime.Estudio;
            dRegistro[5] = anime.AnyoLanzamiento;
            dRegistro[6] = anime.Estado;
            ReconectarBD();
        }
        public void EliminarAnime(int pos)
        {
            // Eliminamos el registro situado en la posición actual.
            dataSetAnimes.Tables["Animes"].Rows[pos].Delete();
            // Tenemos un anime menos
            _numAnimes--;
            // Reconectamos y actualizamos la BD
            ReconectarBD();
        }

        public string MostrarDatos(Anime anime, int pos)
        {
            string text = "";
            DataRow dRegistro = dataSetAnimes.Tables["Animes"].Rows[pos];

            text += "Título: " + anime.Titulo + "\n";
            text += "Género: " + anime.Genero + "\n";
            text += "Episodios: " + anime.TotalEpisodios + "\n";
            text += "Estudio: " + anime.Estudio + "\n";
            text += "Año lanzamiento: " +  anime.AnyoLanzamiento + "\n";
            text += "Estado: " + anime.Estado;

            return text;

        }
    }
}
