using System;

namespace SinglyLinkedList
{
    class Program
    {
        class Node<T>
        {
            public T Value;
            public Node<T> Next;

            public Node(T value) { }
            public Node(T value, Node<T> next) { }
        }

        class LinkedList<T>
        {
            public Node<T> Head;
            public Node<T> Tail;
            public int Count { get; private set; }

            public void AddFirst(T Value)
            {
                if (Head == null)
                {
                    Node<T> node = new Node<T>(value);
                        }
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
