using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] block = new Figure[]
            {
                new Rectangle(3,5,"blue"),
                new Square(4,"green"),
                new Square(2,"yellow"),
                new Rectangle(1,7,"red"),
                new Circle(5,"purple")
            };

            BlockWrite(block);
            HasToBeHoley(block);
            BlockWrite(block);

            Console.WriteLine("Biggest figure: " + MaxArea(block).Data());
            Console.ReadLine();
        }

        static void BlockWrite(Figure[] t)
        {
            foreach (Figure s in t)
                Console.WriteLine(s.Data());
            Console.WriteLine();
        }

        // Makes objects holey, where the perimiter is smaller than the area
        static void HasToBeHoley(Figure[] t)
        {
            foreach (Figure s in t)
                if (s.Area() > s.Perimeter())
                    s.MakeItHoley();
        }

        static Figure MaxArea(Figure[] t)
        {
            int maxi = 0;
            double maxt = t[0].Area();

            for (int i = 0; i < t.Length; i++)
            {
                if(t[i].Area() > maxt)
                {
                    maxi = i;
                    maxt = t[i].Area();
                }
            }

            return t[maxi];
        }
    }
}
