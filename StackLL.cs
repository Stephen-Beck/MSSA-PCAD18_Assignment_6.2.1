namespace Assignment_6._2._1
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
    public class StackLL
    {
        private int size = 0;
        public Node Head { get; set; }
        public Node Next { get; set; }
        public StackLL()
        {
            Head = null;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Push(int num)
        {
            Node newNode = new Node(num);

            newNode.Next = Head;
            Head = newNode;
            size++;
            return newNode.Data;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");
            else
            {
                Node temp = Head;

                Head = Head.Next;
                size--;

                return temp.Data;
            }
        }

        public void Peek()
        {
            Console.Write("\nPeek: ");
            if (IsEmpty())
                Console.WriteLine("null (stack is empty)");
            else Console.WriteLine(Head.Data);
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Node temp = Head;

            while (temp != null)
            {
                if (temp.Next != null)
                    Console.Write(temp.Data + " --> ");
                else Console.WriteLine(temp.Data);

                temp = temp.Next;
            }
        }
    }
}
