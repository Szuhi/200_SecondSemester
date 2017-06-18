using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    enum AnimalSpecies { Dog, Panda, Rabit }
    class Animal
    {
        string name;
        int weight;
        bool male;
        AnimalSpecies spec;

        public Animal(string name, int weight, bool male, AnimalSpecies spec)
        {
            this.name = name;
            this.weight = weight;
            this.male = male;
            this.spec = spec;
        }

        public string Name { get { return name; } }
        public int Weight { get { return weight; } }
        public bool Male { get { return male; } }
        public AnimalSpecies Spec { get { return spec; } }
    }

    class Cage
    {
        Animal[] block;
        int n;

        public Cage(int size)
        {
            block = new Animal[size];
            n = 0;
        }

        public void Add(Animal a)
        {
            if (n == block.Length)
                return;
            block[n++] = a;
        }

        public void Delete(string name)
        {
            int j = 0;

            while (j < n && block[j].Name != name)
                j++;

            if(j<n)
            {
                for (int z = 0; z < n - 1; z++)
                    block[z] = block[z+1];
                n--;
            }
        }

        public int CountSpecies(AnimalSpecies f)
        {
            int db = 0;
            for (int i = 0; i < n; i++)
                if (block[i].Spec == f)
                    db++;
            return db;
        }

        public bool SpeciesAndSexExisting(AnimalSpecies f, bool h)
        {
            int j = 0;
            while (j < n && !(block[j].Spec == f && block[j].Male == h))
                j++;
            return j < n;
        }

        public Animal[] AnimalSpecies(AnimalSpecies f)
        {
            Animal[] t = new Animal[CountSpecies(f)];
            int j = 0;
            for (int i = 0; i < n; i++)
                if (block[i].Spec == f)
                    t[j++] = block[i];
            return t;
        }
    }
}
