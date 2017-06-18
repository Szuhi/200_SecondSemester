using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting
{
    public delegate void NumberChanged(int newNumber);

    class Count
    {
        int number;
        public event NumberChanged Changed;
        public int Number
        {
            set
            {
                number = value;
                if (Changed != null)
                    Changed(number);
            }
        }
    }

    class Program
    {
        static void Write(int e)
        {
            Console.WriteLine("The new value: " + e);
        }
        
        static void NChange(int newNumber)
        {
            System.IO.File.AppendAllText("numbercalendar.txt", DateTime.Now.ToString() + " - Az új érték: " + newNumber + "\r\n");
        }

        static void Main(string[] args)
        {
            Count c = new Count();
            c.Changed += Write;
            c.Changed += NChange;

            c.Number = 10;
            c.Number = 11;
            c.Number = 12;

            Console.ReadLine();
        }
    }
}
