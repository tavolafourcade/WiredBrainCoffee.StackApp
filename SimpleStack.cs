﻿using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack
    {
        private readonly double[] _items;
        private int _currentIndex = -1; // If no item is in SimpleStack, the current index is -1.

        public SimpleStack()
        {
            _items = new double[10]; // This means the SimpleStack class will work with a max of 10 items.
        }

        public void Push(double item)
        {
            /* Write the increment operator before _currentIndex
             * In this way, it will first increment from -1 to 0
             * Then, it will be assign to _items when the Push method is called.
             */
            _items[++_currentIndex] = item; 
        }
    }
}