using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Member
    {
        private string aName;
        private int aAge;
        private string aVoiceType;

        public string Name
        {
            get { return aName; }
            set { aName = value; }
        }

        public int Age
        {
            get { return aAge; }
            set { aAge = value; }
        }

        public string VoiceType
        {
            get { return aVoiceType; }
            set { aVoiceType = value; }
        }
    }
}
