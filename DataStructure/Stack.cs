using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGenerics
{
    public class Stack<T>
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

        public void Push(T data)
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

        public void Pop()
        {
            Node<T> temp = First;
            
            if(temp == null)
            {
                return;
            }
            if(temp == null)
            {
                First = null;
                return ;
            }
                while(temp.Next.Next != null)
                    temp = temp.Next;
                
                Console.WriteLine($"{temp.Next.Data} IS REMOVED");
                temp.Next = null;
        }

        public void Peek()
        {
            Node<T> node = First;
            
            if(node == null)
            {
                return;
            }
                while(node.Next != null)
                {
                    node = node.Next;
                    
                }
                Console.WriteLine(node.Data);
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
            Console.WriteLine(count);
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