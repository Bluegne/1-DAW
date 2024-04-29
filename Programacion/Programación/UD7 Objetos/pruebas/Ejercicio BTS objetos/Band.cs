using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Band
    {
        private string aProducer;
        public string Producer
        {
            get { return aProducer; }
            set { aProducer = value; }
        }

        private DateTime birthDate;
        private string aGenre;
        private List<Member> aMembers;
        private List<Album> aAlbums;

        public string Genre
        {
            get { return aGenre; }
            set { aGenre = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public List<Member> Members
        {
            get { return aMembers; }
            set { aMembers = value; }
        }

        public List<Album> Albums
        {
            get { return aAlbums; }
            set { aAlbums = value; }
        }
    }
}
