using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int.Parse(Console.ReadLine());
                int d = 0;
                int[] t = new int[] { 1, 2, 3 };
                throw new OwnException(42);
            }
            catch (FormatException e)
            {
                Console.WriteLine("It's not a number!");
            }
            catch (OwnException e)
            {
                Console.WriteLine("The stored value is: " + e.Number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
