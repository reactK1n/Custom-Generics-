using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomGenerics
{
    public class Node<T>
    {
        public T Data {get; set;}
        public Node<T> Next {get; set;}


        public Node(T data)
        {
            Data = data;
        }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}