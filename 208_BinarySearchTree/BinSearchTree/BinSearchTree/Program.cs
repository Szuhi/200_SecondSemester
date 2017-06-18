using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinSearch<int, string> tree = new BinSearch<int, string>();
            tree.Add(4, "four");
            tree.Add(1, "one");
            tree.Add(7, "seven");
            tree.Add(2, "two");
            tree.Add(3, "three");
            tree.Add(5, "five");

            foreach (string s in tree)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
