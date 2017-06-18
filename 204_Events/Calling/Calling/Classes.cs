using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling
{
    class Telephone
    {
        string number;
        int account;
        ICallObserver observer;
        const int CHARGE = 200;

        public Telephone(string number)
        {
            this.number = number;
        }

        public void UploadAccount(int sum)
        {
            account += sum;
        }

        public void ObserveRegister(ICallObserver f)
        {
            observer = f;
        }

        void ReceiveCall(Telephone source)
        {
            if (observer != null)
                observer.IncomingCall(this, source.number);
        }

        public void Calling(Telephone dest)
        {
            if (observer != null)
                observer.OutgoingCall(this, dest.number);
            if(account >= CHARGE)
            {
                dest.ReceiveCall(this);
                account -= CHARGE;
            }
        }

        public override string ToString()
        {
            return number;
        }
    }

    class CallJournal : ICallObserver
    {
        public void IncomingCall(Telephone sender, string source_number)
        {
            Console.WriteLine("Incoming call: " + sender + ", source: " + source_number);
        }

        public void OutgoingCall(Telephone sender, string dest_number)
        {
            Console.WriteLine("Outgoing call: " + sender + ", destination: " + dest_number);
        }
    }

    class FileJournal : ICallObserver
    {
        public void IncomingCall(Telephone sender, string source_number)
        {
            System.IO.File.AppendAllText("journal.log", "Incoming call: " + sender + ", source: " + source_number + "\r\n");
        }

        public void OutgoingCall(Telephone sender, string dest_number)
        {
            System.IO.File.AppendAllText("journal.log", "Outgoing call: " + sender + ", source: " + dest_number + "\r\n");
        }
    }
}
