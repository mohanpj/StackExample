using System;
using StackExample.ExceptionHandlers;

namespace StackExample
{
    public class Stack<T>
    {
        private T[] _stackArray;
        private readonly int _maximumLength;
        private int _stackIndex;

        public int Size { get => _stackIndex; private set => _stackIndex = value; }

        public Stack(int maximumLength)
        {
            _maximumLength = maximumLength;
            _stackArray = new T[maximumLength];
        }

        public void Push(T value)
        {
            if (_maximumLength == _stackIndex)
            {
                throw new ExceededSizeException("Items cannot be added to the stack. Stack is full");
            }

            _stackArray[_stackIndex] = value;
            _stackIndex++;
        }

        public T Pop()
        {
            if (_stackIndex == 0)
            {
                throw new ExpenditureProhibitedException("There are no items in the stack");
            }
            _stackIndex--;

            return _stackArray[_stackIndex];
        }

        public T Peek()
        {
            if (_stackIndex == 0)
            {
                throw new ExpenditureProhibitedException("There are no items in the stack");
            }

            return _stackArray[_stackIndex - 1];
        }
    }

}
