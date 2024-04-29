using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jujutsu
{
    public class Character
    {
        //TODO crear atributos
        private string mName;
        private int mAge;

        //TODO crear propiedades públicas de los atributps
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }


        //TODO crear constructor
        public Character()
        {
            mName = "";
            mAge = 0;
        }
    }
}
