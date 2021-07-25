﻿using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            Console.ReadLine();
        }


            
        private static void StackDoubles()
        {
            var stack = new SimpleStackDouble(); //Initialize an instance
            stack.Push(1.2); // Using Ctrl + . we can generate the method Push on the class SimpleStack
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop(); // Cast object into double
                Console.WriteLine($"Item: {item}");
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }

        private static void StackStrings()
        {
            var stack = new SimpleStackString();
            stack.Push("Wired Brain Coffee");
            stack.Push("Pluralsight");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
