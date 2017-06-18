using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] cage = new Dog[]
            {
                new Dog("Alfons", 7),
                new Dog("Berni", 14),
                new Dog("Ceasar", 6),
                new Dog("Dome", 4),
                new Dog("Einstein", 12),
            };

            Write(cage);
            Array.Sort(cage);

            Write(cage);
            Console.ReadLine();
        }

        static void Write(Dog[] t)
        {
            foreach (Dog d in t)
                Console.WriteLine(d);
            Console.WriteLine();
        }
    }
}
