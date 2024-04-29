using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jujutsu
{
    public class School
    {
        //TODO crear atributos
        private string mName;
        private string mCity;
        private List<Character> characterList;

        //TODO crear propiedades públicos de los atributos
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string City
        {
            get { return mCity; }
            set { mCity = value; }
        }

        public List<Character> CharacterList
        {
            get { return characterList; }
            set { characterList = value; }
        }

        //TODO crear constructor
        public School()
        {
            mName = "";
            mCity = "";
            characterList = new List<Character>();
        }
    }
}
