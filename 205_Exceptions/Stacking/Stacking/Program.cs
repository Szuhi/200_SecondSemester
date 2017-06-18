using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacking
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack v = new Stack(5);
                v.Push(1);
                v.Push(2);
                v.Push(3);
                v.Push(4);
                v.Push(5);

                Console.WriteLine(v.Pop());
                Console.WriteLine(v.Pop());
                Console.WriteLine(v.Pop());
                Console.WriteLine(v.Pop());
                Console.WriteLine(v.Pop());
                Console.WriteLine(v.Pop());
            }
            catch (StackIsFullException e)
            {
                Console.WriteLine("Couldn't store: " + e.Item);
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("It is going to be on the screen");
            }

            Console.ReadLine();
        }
    }
}
