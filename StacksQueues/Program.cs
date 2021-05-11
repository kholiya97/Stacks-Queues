using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{/// <summary>
 /// Stack class 
 /// </summary>
    public class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }

        /// <summary>
        /// Push elements into stack.
        /// </summary>
        /// <param name="value"></param>
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed into stack ", value);
        }

        /// <summary>
        /// Display method to display stack elements.
        /// </summary>
        public void DisplayStackElements()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("Stack Is Empty.");
        }

        /// <summary>
        /// Peek method will return top element from stack.
        /// </summary>
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty!!!");
                return;
            }
            Console.WriteLine("{0} is a TOP elements of the stack ", this.top.data);
        }

        /// <summary>
        /// Pop method will delete top element from thre stack.
        /// </summary>
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty...You can not delete.(Underflow condition)");
                return;
            }
            Console.WriteLine("Elements popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        /// <summary>
        /// Peek and pop till stack is empty.
        /// </summary>
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            //this.top=null;
        }
    }
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class AbilityToEnQueueInQueue
    {
        Node head = null;

        /// <summary>
        /// Inserting elements in queue -----> FIFO order.
        /// </summary>
        /// <param name="data"></param>
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue. ", node.data);
        }

        /// <summary>
        /// Display queue elements.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty!!!");
                return;
            }
            while (temp != null)
            {
                Console.Write("Queue elements are : " + temp.data + " ");
                temp = temp.next;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Welcome To Stack And Queue Program Using Linked List=====================");

            Stack stackOBJ = new Stack();
            AbilityToEnQueueInQueue queueOBJ = new AbilityToEnQueueInQueue();

            //Pushing(adding) elements one by one.
            //Top elements will be 50.
            stackOBJ.Push(70);
            stackOBJ.Push(30);
            stackOBJ.Push(56);

            //Displaying stack.
            stackOBJ.DisplayStackElements();

            Console.WriteLine();
            stackOBJ.Peek();
            stackOBJ.Pop();
            stackOBJ.IsEmpty();
            stackOBJ.DisplayStackElements();

            //Queue operations
            queueOBJ.Enqueue(44);
            queueOBJ.Enqueue(440);
            queueOBJ.Enqueue(344);
            queueOBJ.Enqueue(333);
            queueOBJ.Enqueue(12);
            queueOBJ.Display();

            Console.ReadLine();




        }
    }
}

