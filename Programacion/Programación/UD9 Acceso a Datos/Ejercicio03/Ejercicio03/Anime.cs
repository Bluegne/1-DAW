using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Anime
    {
        private string _Titulo;
        private string _Genero;
        private int _totalEpisodios;
        private string _Estudio;
        private string _anyoLanzamiento;
        private string _Estado;

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public string Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }

        public string Estudio
        {
            get { return _Estudio; }
            set { _Estudio = value; }
        }
        
        public int TotalEpisodios
        {
            get { return _totalEpisodios; }
            set { _totalEpisodios = value; }
        }

        public string AnyoLanzamiento
        {
            get { return _anyoLanzamiento; }
            set { _anyoLanzamiento = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public Anime(string titulo, string genero, int totalEpisodios, string estudio, string anyo, string estado)
        {
            _Titulo = titulo;
            _Genero = genero;
            _totalEpisodios = totalEpisodios;
            _Estudio = estudio;
            _anyoLanzamiento = anyo;
            _Estado = estado;
        }
    }
}
