namespace Assignment_6._2._1
{
    public class StackArray
    {
        private int top = -1;
        private readonly int[] array;
        public StackArray(int arraySize)
        {
            array = new int[arraySize];
        }

        public bool IsFull()
        {
            return (top == array.Length-1);
        }
        
        public int Push(int num)
        {
            if (IsFull())
                throw new InvalidOperationException("Stack is full");
            else
            {
                array[++top] = num;
                return array[top];
            }
        }

        public int Pop()
        {
            int temp = array[top--];
            return temp;
        }

        public void Peek()
        {
            Console.Write("\nPeek: ");
            if (top == -1)
                Console.WriteLine("null (stack is empty)");
            else Console.WriteLine(array[top]);
        }

        public void Display()
        {
            // Edge cases
            if (top == -1) Console.WriteLine("Stack is empty");

            Console.Write("[");
            for (int i = 0; i <= top; i++)
            {
                if (i != top)
                    Console.Write(array[i] + ",");
                else Console.Write(array[i]);
            }
            Console.WriteLine("]");
        }
    }
}
