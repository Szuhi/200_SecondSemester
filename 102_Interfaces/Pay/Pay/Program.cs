using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay
{
    interface ICurrency
    {
        bool Paying(int sum);
    }
    interface IOwnership
    {
        string Owner { get; set; }
    }
    interface ILost
    {
        string Time { get; }
    }

    class Program
    {
        static bool Payment(ICurrency[] t, int o)
        {
            foreach (ICurrency f in t)
                if (!f.Paying(o))
                    return false;
            return true;
        }

        static bool ValidatePayment(ICurrency[] t, int o, string n)
        {
            foreach (ICurrency f in t)
                if (!(f is IOwnership) || (f as IOwnership).Owner != n || !f.Paying(o))
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            ICurrency[] items = new ICurrency[]
            {
                new Card("Pure Pete", 1250),
                new BannedCard("Wealthy Willy", 365000, "Yesterday"),
                new Loan()
            };

            Console.WriteLine(Payment(items, 1000));
            Console.WriteLine(ValidatePayment(items, 100, "Pure Pete"));

            Console.ReadLine();
        }
    }
}
