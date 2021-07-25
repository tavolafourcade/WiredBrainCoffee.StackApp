
namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack
    {
        private readonly object[] _items;
        private int _currentIndex = -1; // If no item is in SimpleStack, the current index is -1.

        /*
         * We can use expression bodies if the constructor have one line
         * This means, we don't need the curly braces.
         * We can do the same with the Push method.
         */
        public SimpleStack() => _items = new object[10]; // This means the SimpleStack class will work with a max of 10 items.

        public int Count => _currentIndex + 1;
        public void Push(object item)
        {
            /* Write the increment operator before _currentIndex
             * In this way, it will first increment from -1 to 0
             * Then, it will be assign to _items when the Push method is called.
             */
            _items[++_currentIndex] = item; 
        }

        public object Pop() => _items[_currentIndex--];
    }
}