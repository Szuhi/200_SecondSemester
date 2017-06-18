using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class OwnException : Exception
    {
        int number;
        public int Number { get { return number; } }

        public OwnException(int number)
            : base("Own exception happened!")
        {
            this.number = number;
        }
    }
}
