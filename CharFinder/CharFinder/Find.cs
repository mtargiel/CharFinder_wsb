using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFinder
{
    class Find
    {
        private string _zdanie;

        public string Zdanie
        {
            get { return _zdanie; }
            set { _zdanie = value; }
        }

        private char _znak;

        public char Znak
        {
            get { return _znak; }
            set { _znak = value; }
        }

        public Find(string zdanie, char znak)
        {
            Zdanie = zdanie;
            Znak = znak;
        }

        public int policzZnaki()
        {

            return _zdanie.Count(x => x == _znak); ;
        }
    }
}
