using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simply_connected
{
    internal class Program
    {
        internal class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

        }

        internal class LinkList
        {
            public void Push(int value)
            {
                Size++;
                var node = new Node() { Value = value };
                if (Head == null)
                {
                    Head = node;
                }
                else
                {
                    Current.Next = node;
                }
                Current = node;

            }


            public void ListNodes()
            {
                Node tempNode = Head;

                while (tempNode != null)
                {
                    Console.WriteLine(tempNode.Value);
                    tempNode = tempNode.Next;
                }
            }

            public int this[int position]
            {
                get
                {
                    Node tempNode = Head;
                    for (int i = 0; i < position; ++i)
                        // переходим к следующему узлу списка
                        tempNode = tempNode.Next;
                    return tempNode.Value;
                }
            }
            private Node Head { get; set; }
            private Node Tails { get; set; }
            private Node Current { get; set; }
            private Node Current1 { get; set; }
            private int Size { get; set; }
        }
        class Program1
        {
            private static void Main(string[] args)
            {
                var node = new LinkList();
                node.Push(1);
                node.Push(2);
                node.Push(3);
                node.Push(4);
                node.Push(9);
                node.ListNodes();
                Console.ReadKey();
            }
        }
    }
}
