using System;

namespace StackExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            var result = stack.Pop();
            Console.WriteLine($"Stack result { result}");
        }
    }
}
