using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGenerics
{
    public class LinkedList<T>
    {
        public Node<T> First { get; set; }
        public int count;

        public void Add(T data)
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
            Count();
        }


        public bool Remove(T data)
        {
            Node<T> node = First;
            if(node == null)
            {
                Console.WriteLine($"{data} NOT FOUND");
                return true;
            }
            while(node.Next != null)
                {
                    if (node.Next.Data.Equals(data))
                    { 
                        break;
                    }
                    node = node.Next;
                }
            node.Next = node.Next.Next;
            
            Console.WriteLine($"{data} IS REMOVED");
            return true;
        }

        public bool Check(T data)
        {
            Node<T> node = First;
            if(node == null)
            {
                Console.WriteLine($"False");
                return false;
            }
            while(node.Next != null)
            {
                if (node.Next.Data.Equals(data))
                { 
                    Console.WriteLine($"True");
                    return true;
                }
                node = node.Next;
            }
            Console.WriteLine($"False");
            return false;
        }

        public void Index(T data)
        {
            int index = 0;
            Node<T> node = First;
            if(node == null)
            {
                Console.WriteLine(-1);
                return;
            }
            while(node.Next != null)
            {
                index++;
                if (node.Next.Data.Equals(data))
                { 
                    Console.WriteLine(index);
                    return;
                }
                node = node.Next;
            }
            Console.WriteLine(-1);
            return;
        }

        

        public Node<T> DeleteFirst()
        {
            Node<T> temp = First;
            First = First.Next;
            return temp;
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

        public void Count()
        {
            Node<T> node = First;
            
            while(node.Next != null)
            {
                node = node.Next;
                count++;
            }
            Console.WriteLine(count + 1);
        }

    }
}