using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacking
{
    class Stack
    {
        int[] block;
        int vm;

        public Stack(int size)
        {
            block = new int[size];
            vm = 0;
        }

        public void Push(int e)
        {
            if (vm == block.Length)
                throw new StackIsFullException(e);
            block[vm++] = e;
        }

        public int Pop()
        {
            if (vm == 0)
                throw new StackIsEmptyException();
            return block[--vm];
        }
    }

    class StackIsFullException : Exception
    {
        int item;
        public int Item { get { return item; } }
        public StackIsFullException(int item)
            :base ("Stack is full!")
        {
            this.item = item;
        }
    }

    class StackIsEmptyException : Exception
    {
        public StackIsEmptyException()
            :base ("Stack is empty!")
        { }
    }
}
