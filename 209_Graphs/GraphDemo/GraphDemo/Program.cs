using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphNeighbourList g1 = new GraphNeighbourList(7);
            g1.AddEdge(0, 1);
            g1.AddEdge(0, 3);
            g1.AddEdge(0, 4);
            g1.AddEdge(1, 2);
            g1.AddEdge(1, 3);
            g1.AddEdge(2, 3);
            g1.AddEdge(2, 5);
            g1.AddEdge(3, 5);
            g1.AddEdge(5, 6);

            Console.WriteLine("Csúcsok: ");
            Write(g1.Peaks());

            Console.WriteLine("0. csúcs szomszédai: ");
            Write(g1.Neighbours(0));

            Console.WriteLine("Szélességi bejárás: ");
            Write(g1.LattitudeRun());

            Console.WriteLine("Mélységi bejárás: ");
            Write(g1.DepthRun());

            Console.ReadLine();
        }

        static void Write(List<int> l)
        {
            foreach (int e in l)
                Console.Write(e + " ");
            Console.WriteLine();
        }
    }
}
