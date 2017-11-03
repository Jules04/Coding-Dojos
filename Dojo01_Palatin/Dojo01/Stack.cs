using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo01
{
    class Stack<T>
    {
        private StackElement<T> currentElement; 

      
        public void Push(T item)
        {
            if (currentElement != null)
            {
                currentElement = new StackElement<T>() { ValueOfElement = item, Successor = null };
            }
            else
            {
                StackElement<T> temp = new StackElement<T>() { ValueOfElement = item, Successor = currentElement };
                currentElement = temp;
            }

        }

        public T Pop()
        {
            if (currentElement != null)
            {
                T temp = currentElement.ValueOfElement;
                currentElement = currentElement.Successor;
                return temp;
            }
            else
            {
                throw new NullReferenceException(); 
            }
        }

 
        public T Peek()
        {
            if (currentElement != null)
            {
                return currentElement.ValueOfElement;
            }
            else
            {
                return default(T);
            }
        }

    }
}

