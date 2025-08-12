// Write a C# program to implement a stack by using array with push and pop operations.

namespace Assignment_6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack using custom LinkedList:");
            StackLL stackLL = new();
            stackLL.Display();
            Console.WriteLine("\nAdded "+stackLL.Push(1));
            stackLL.Display();
            Console.WriteLine("\nAdded " + stackLL.Push(2));
            stackLL.Display();
            Console.WriteLine("\nRemoved " + stackLL.Pop());
            stackLL.Display();
            stackLL.Peek();
            Console.WriteLine("\nRemoved " + stackLL.Pop());
            stackLL.Display();
            stackLL.Peek();

            Console.WriteLine("\n\nStack using array (size of 3):");
            StackArray stackArray = new(3);
            stackArray.Display();
            Console.WriteLine("\nAdded " + stackArray.Push(1));
            stackArray.Display();
            Console.WriteLine("\nAdded " + stackArray.Push(2));
            stackArray.Display();
            Console.WriteLine("\nAdded " + stackArray.Push(3));
            stackArray.Display();
            Console.WriteLine("\nRemoved " + stackArray.Pop());
            stackArray.Display();
            stackArray.Peek();
            Console.WriteLine("\nRemoved " + stackArray.Pop());
            stackArray.Display();
            Console.WriteLine("\nRemoved " + stackArray.Pop());
            stackArray.Display();
            stackArray.Peek();
        }
    }
}
