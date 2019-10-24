using System;
using StackExample;
using StackExample.ExceptionHandlers;
using Xunit;

namespace StackExample.Tests
{
    public class StackTest
    {
        [Fact]
        public void Creation()
        {
            Stack<int> stack = new Stack<int>(0);
            Assert.Equal(0, stack.Size);
        }

        [Fact]
        public void Push_Pop()
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var expected = stack.Pop();
            Assert.Equal(3, expected);
            Assert.Equal(2, stack.Size);
        }

        [Fact]
        public void Too_Much_Pop()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => stack.Pop());
        }

        [Fact]
        public void Too_Much_Push()
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Throws<ExceededSizeException>(() => stack.Push(4));
        }

        [Fact]
        public void Peek_Exception()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => stack.Peek());
        }

        [Fact]
        public void Peek_Element()
        {
            Stack<int> stack = new Stack<int>(2);
            stack.Push(1);
            stack.Push(2);
            int expected = stack.Peek();
            Assert.Equal(2, expected);
            Assert.Equal(2, stack.Size);
        }
    }

}
