using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_objects
{
    class Person
    {
        //TODO declarar miembros de la clase (privados)
        private string mName;
        private int mAge;
        private string mPhone;
        private char mGender;
        private bool mStatus;

        //TODO crear las propiedades de la clase
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Age
        {
            get { return mAge; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    mAge = value;
                }
            }

        }

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public char Gender
        {
            get { return mGender; }
            set 
            { 
                if (value == 'M' || value == 'F')
                {
                    mGender = value;
                }
            }
        }

        public bool Status
        {
            get { return mStatus; }
            set { mStatus = value; }
        }

        public Person()
        {
            mName = "";
            mAge = 0;
            mPhone = "";
        }
        private string ShowGender(char gender)
        {
            string text = "";
            if (gender == 'M')
            {
                text = "Masculino";
            }
            else 
            {
                text = "Femenino";
            }
            return text;
        }
        private string ShowStatus(bool status)
        {
            string text = "";
            if (status) 
            {
                text = "Casado"; 
            }
            else
            {
                text = "Soltero";
            }
            return text;
        }
        public string ShowData()
        {
            string text = "";

            text = "Datos de la persona:+\n";
            text += "Nombre: " + mName + "\n";
            text += "Edad: " + mAge + "\n";
            text += "Télefono: " + mPhone + "\n";
            text += "Género: " + ShowGender(mGender) + "\n";
            text += "Estado Civil: " + ShowStatus(mStatus);

            return text;
        }
    }
}
