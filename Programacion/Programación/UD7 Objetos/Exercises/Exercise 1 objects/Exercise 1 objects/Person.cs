using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_objects
{
    internal class Person
    {
        //TODO declarar miembros de la clase
        private string mName;
        private int mAge;
        private string mPhone;
        private char mGender;
        private bool mMarried;

        public Person(string name, int age)
        {
            mName = name;
            mAge = age;
        }

        public Person()
        {
            mName = "";
        }

        //TODO declarar las propiedades de los miembros 
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

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public char Gender
        {
            get { return mGender; }
            set { mGender = value; }
        }

        public bool Married
        {
            get { return mMarried; }
            set { mMarried = value; }
        }

        //TODO agregar métodos a la clase
    }
}
