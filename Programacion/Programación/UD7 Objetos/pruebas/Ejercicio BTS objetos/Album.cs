using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Album
    {
        private string aName;
        private int aYear;
        private List<Song> aSongs;

        public string Name
        {
            get { return aName; }
            set { aName = value; }
        }
        
        public int Year
        {
            get { return aYear; }
            set { aYear = value; }
        }
        
        public List<Song> Songs
        {
            get { return aSongs; }
            set { aSongs = value; }
        }
    }
}
