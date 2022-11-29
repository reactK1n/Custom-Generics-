using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGenerics
{
    public class Queue<T>
    {
        public Node<T> First { get; set; }
        public int count = 0;


        public bool IsEmpty()
        {
            Node<T> node = First;
            if(node == null)
            {
               Console.WriteLine("true") ;
            return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }

        public void Enqueue(T data)
        {
            Node<T> node = First;
            if(node == null)
            {
                First = new Node<T>(data);
                return;
            }
            
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new Node<T>(data);

        }

        public Node<T> Dequeue()
        {
            Node<T> temp = First;
               if(temp == null)
            {
                return First;
            }
            First = First.Next;
            Console.WriteLine($"{temp.Data} IS REMOVED");
            return temp;
        }

        public void Size()
        {
            Node<T> current = First;
            if(current == null)
            {
                count = 0;
                return;
            }
            while(current.Next != null)
            {
                current = current.Next;
                count++;
            }
            Console.WriteLine(count + 1);
        }


        public void DisplayList()
        {
            Console.WriteLine("iterating through the .........");
            Node<T> current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;     
            }       

        }
    }
}