using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    /// <summary>
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Welcome To Stack And Queue Program Using Linked List=====================");

            Stack stackOBJ = new Stack();

            //Pushing(adding) elements one by one.
            //Top elements will be 50.
            stackOBJ.Push(70);
            stackOBJ.Push(30);
            stackOBJ.Push(56);

            //Displaying stack.
            stackOBJ.DisplayStackElements();
            Console.ReadLine();

        }
    }
}

