using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling
{
    interface ICallObserver
    {
        void IncomingCall(Telephone sender, string source_number);
        void OutgoingCall(Telephone sender, string dest_number);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Telephone t1 = new Telephone("1"), t2 = new Telephone("2");
            CallJournal n = new CallJournal();
            t1.ObserveRegister(n);
            t2.ObserveRegister(new FileJournal());
            t1.UploadAccount(500);
            t1.Calling(t2);
            t1.Calling(t2);
            t2.Calling(t1);
            t2.Calling(t1);
            t1.Calling(t2);
            t1.Calling(t2);
            t2.Calling(t1);

            Console.ReadLine();
        }
    }
}
