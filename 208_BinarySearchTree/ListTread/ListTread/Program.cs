using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTread
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainedList<int> l = new ChainedList<int>();
            l.AddToTheEnd(2);
            l.AddToTheBegining(4);
            l.AddToTheEnd(3);
            l.AddToTheEnd(1);
            l.AddToTheBegining(5);

            foreach (int i in l)
                Console.WriteLine(l);

            Console.ReadLine();
        }
    }
}
