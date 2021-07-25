using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new SimpleStack(); //Initialize an instance
            stack.Push(1.2); // Using Ctrl + . we can generate the method Push on the class SimpleStack
            stack.Push(2.8);
            stack.Push(3.0);
        }
    }
}
