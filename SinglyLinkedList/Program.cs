using System;
using System.Collections.Generic;
using System.Transactions;

namespace SinglyLinkedList
{
    class Program
    {
        class Node<T>
        {
            public T Value;
            public Node<T> Next;

            public Node(T value) { this.Value = value; }
            public Node(T value, Node<T> next) { this.Value = value; }
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
                    Node<T> node = new Node<T>(Value);
                    Head = node;
                    Tail = Head;


                }
                else
                {
                    Node<T> nodeToInsert = new Node<T>(Value);
                    nodeToInsert.Next = Head;
                    Head = nodeToInsert;

                    Count++;
                }
            }

            public void AddLast(T Value)
            {
                if (Head == null)
                {
                    Node<T> node = new Node<T>(Value);
                    Head = node;
                    Tail.Next = Head;
                    Count++;
                }
                else
                {
                    Node<T> otherNode = new Node<T>(Value);
                    Tail.Next = otherNode;
                    Tail = Tail.Next;
                    Count++;
                }
            }



            public bool AddBefore(T node, T Value)
            {


                Node<T> current = Head;
                for (int i = 0; i < Count; current = current.Next, i++)
                {
                    if (Head.Value.Equals(node))
                    {
                        AddFirst(Value);
                        return true;
                    }


                    if (current.Next.Value.Equals(node))
                    {
                        Node<T> beforeNode = current.Next;



                        Node<T> newNode = new Node<T>(Value);

                        current.Next = newNode;
                        newNode.Next = beforeNode;
                        Count++;
                        return true;

                    }


                }

                return false;
            }

            public bool AddAfter(T node, T Value)
            {
                Node<T> current = Head;
                for (int i = 0; i < Count; i++, current = current.Next)
                {


                    if (Tail.Value.Equals(node))
                    {
                        AddLast(Value);
                        return true;
                    }
                    if (current.Value.Equals(node))
                    {

                        Node<T> afterNode = current.Next;
                        Node<T> newNode = new Node<T>(Value);


                        current.Next = newNode;
                        newNode.Next = afterNode;
                        Count++;

                        return true;

                    }
                }

                return false;
            }

            public bool RemoveFirst()
            {
                if (Head == null)
                {
                    return false;
                }
                else
                {
                    Head = Head.Next;
                    Count--;
                    return true;

                }
            }

            public bool RemoveLast()
            {
                if (Head == null)
                {
                    return false;
                }
                else
                {
                    Node<T> current = Head;

                    for (int i = 0; i < Count; current = current.Next, i++)
                    {
                        if (current.Next.Equals(Tail))
                        {
                            current.Next = null;
                            Count--;
                            Tail = current;
                            return true;
                        }
                    }

                    return false;
                }
            }

            public bool Remove(T Value)
            {
                // if value is value of head

                // if value is value of tail

                // otherwise
                Node<T> current = Head;
                for (int i = 0; i < Count; current = current.Next, i++)
                {

                    if (Value.Equals(Head))
                    {
                        if (current.Next.Value.Equals(Value))
                        {
                            Node<T> nodeAfter = current.Next.Next;
                            current.Next = nodeAfter;
                            Count--;
                            Head = nodeAfter;
                            return true;

                        }
                    }

                    if (Value.Equals(Tail))
                    {
                        if (current.Next.Value.Equals(Value))
                        {
                            Node<T> nodeAfter = current.Next.Next;
                            current.Next = nodeAfter;
                            Count--;
                            Tail = nodeAfter;
                            return true;

                        }
                    }
                    if (current.Next.Value.Equals(Value))
                    {
                        Node<T> nodeAfter = current.Next.Next;
                        current.Next = nodeAfter;
                        Count--;
                        return true;

                    }


                }
                return false;
            }

            public void Clear()
            {
                Head = null;
                Tail = null;
            }

            public bool Contains(T Value)
            {
                Node<T> current = Head;
                for (int i = 0; i < Count; current = current.Next, i++)
                {
                    if (current.Equals(Value))
                    {
                        return true;
                    }
                }
                return false;
            }

            public Node<T> Search(T Value)
            {
                Node<T> current = Head;
                for (int i = 0; i < Count; current = current.Next, i++)
                {
                    if (current.Equals(Value))
                    {
                        return current;
                    }
                }

                return null;
            }

            public int Counter
            {
                get
                {
                    return Count;
                }
            }
        }
        static void Main(string[] args)
        {


            LinkedList<int> list = new LinkedList<int>();


            list.AddFirst(12);


            list.AddLast(15);


            list.AddBefore(15, 19);
            ;

            list.AddAfter(19, 258);
            ;

            list.Remove(258);
            ;

            list.RemoveFirst();
            ;

            list.RemoveLast();
            ;
        }


    }
}

