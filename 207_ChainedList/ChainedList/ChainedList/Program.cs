using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainedList<int> list = new ChainedList<int>();
            list.InsertAtTheBegining(4);
            list.InsertAtTheBegining(3);
            list.InsertAtTheBegining(5);
            list.Listing();

            ChainedList<string> list2 = new ChainedList<string>();
            list2.InsertAtTheBegining("Thursday.");
            list2.InsertAtTheBegining("Is");
            list2.InsertAtTheBegining("It");
            list2.Listing();

            Console.ReadLine();
        }
    }

    class ChainedList<T>
    {
        class ListItem
        {
            public T content;
            public ListItem next;
        }

        ListItem head = null;

        public void InsertAtTheBegining(T item)
        {
            ListItem newItem = new ListItem();
            newItem.content = item;
            newItem.next = head;
            head = newItem;
        }

        public void Listing()
        {
            ListItem actual = head;
            while (actual != null)
            {
                Console.WriteLine(actual.content);
                actual = actual.next;
            }
        }
    }
}
