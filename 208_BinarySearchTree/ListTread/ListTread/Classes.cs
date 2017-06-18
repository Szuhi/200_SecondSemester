using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTread
{
    class ChainedList<T> : IEnumerable<T>
    {
        class ListItem
        {
            public T content;
            public ListItem next;
        }

        class ListTread : IEnumerator<T>
        {
            ListItem first, actual;

            public ListTread(ListItem first)
            {
                this.first = first;
                actual = null;
            }

            public T Current { get { return actual.content; } }
            public void Dispose()
            {
                first = null;
                actual = null;
            }

            object System.Collections.IEnumerator.Current { get { return this.Current; } }
            public bool MoveNext()
            {
                if (actual == null)
                    actual = first;
                else
                    actual = actual.next;
                return actual != null;
            }

            public void Reset()
            {
                actual = null;
            }
        }

        ListItem head;
        public void AddToTheBegining(T e)
        {
            ListItem newItem = new ListItem();
            newItem.content = e;
            newItem.next = head;
            head = newItem;
        }

        public void AddToTheEnd(T e)
        {
            ListItem newItem = new ListItem();
            newItem.content = e;
            if (head == null)
                head = newItem;
            else
            {
                ListItem tmp = head;
                while (tmp.next != null)
                    tmp = tmp.next;
                tmp.next = newItem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListTread(head);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
