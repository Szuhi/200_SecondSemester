using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cage first = new Cage(5);
            Cage second = new Cage(3);

            first.Add(new Animal("Rex", 20, true, AnimalSpecies.Dog));
            first.Add(new Animal("Mice", 320, false, AnimalSpecies.Panda));
            first.Add(new Animal("Killer", 40, true, AnimalSpecies.Dog));
            first.Add(new Animal("Roy", 30, true, AnimalSpecies.Dog));
            first.Add(new Animal("Billy", 20, true, AnimalSpecies.Dog));

            second.Add(new Animal("Molly", 4, true, AnimalSpecies.Rabit));
            second.Add(new Animal("Puff", 320, false, AnimalSpecies.Panda));
            second.Add(new Animal("Colly", 4, true, AnimalSpecies.Rabit));
        }
    }
}
