using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallExample
{
    class Program
    {
        static int Sum(int[] a)
        {
            return Sum(a, a.Length - 1);
        }

        static int Sum(int[] a, int n)
        {
            if (n == 0)
                return a[0];
            return Sum(a, n - 1) + a[n];
        }

        static int LogSearch(int[] a, int k)
        {
            return LogSearch(a, k, 0, a.Length - 1);
        }

        static int LogSearch(int[] a, int k, int bottom, int top)
        {
            if (bottom > top)
                return -1;
            int middle = (bottom + top) / 2;
            if (a[middle] < k)
                return LogSearch(a, k, middle + 1, top);
            else if (a[middle] > k)
                return LogSearch(a, k, bottom, middle - 1);
            return middle;
        }

        static void Main(string[] args)
        {
            int[] t = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Sum: " + Sum(t));
            Console.WriteLine("The place of the value 7: " + LogSearch(t, 7));
            Console.WriteLine("The place of the value 11: " + LogSearch(t, 11));
            Console.ReadLine();
        }
    }
}
