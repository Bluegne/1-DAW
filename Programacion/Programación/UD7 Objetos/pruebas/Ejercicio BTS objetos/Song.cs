using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Song
    {
        private string aName;
        private int aMinutes;
        private int aSeconds;

        public string Name
        {
            get { return aName; }
            set { aName = value; }
        }

        public int Minutes
        {
            get { return aMinutes; }
            set { aMinutes = value; }
        }

        public int Seconds
        {
            get { return aSeconds; }
            set { aSeconds = value; }
        }
    }
}
