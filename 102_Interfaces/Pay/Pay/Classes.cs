using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay
{
    class PlasticCard : IOwnership
    {
        string owner;

        public PlasticCard(string owner)
        {
            this.owner = owner;
        }

        public string Owner { get { return owner; } set { owner = value; } }
    }
    
    class Card : PlasticCard, ICurrency
    {
        int account;

        public Card(string owner, int account)
            : base(owner)
        {
            this.account = account;
        }

        public virtual bool Paying(int sum)
        {
            if(account >= sum)
            {
                account -= sum;
                return true;
            }
            return false;
        }
    }

    class BannedCard : Card, ILost
    {
        string lost;

        public BannedCard(string owner, int account, string lost)
            : base(owner, account)
        {
            this.lost = lost;
        }

        public string Time { get { return lost; } }

        public override bool Paying(int sum)
        {
            return false;
        }
    }

    class Loan : ICurrency
    {
        int total;

        public bool Paying(int sum)
        {
            total += sum;
            return true;
        }
    }
}
