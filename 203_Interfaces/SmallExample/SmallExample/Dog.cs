using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallExample
{
    class Dog : IComparable
    {
        string name;
        int tailLength;

        public Dog(string name, int tailLength)
        {
            this.name = name;
            this.tailLength = tailLength;
        }

        public override string ToString()
        {
            return name + " (" + tailLength + " cm)";
        }

        public int CompareTo(object obj)
        {
            return tailLength - (obj as Dog).tailLength;
        }
    }
}
