Here is a C# console application that reverses a linked list both iteratively and recursively:

```C#
using System;
using System.Collections.Generic;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}

public class LinkedList
{
    public Node Head { get; set; }

    public void Add(int value)
    {
        Node newNode = new Node { Value = value };
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Print()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void ReverseIteratively()
    {
        Node prev = null;
        Node current = Head;
        Node temp = null;
        while (current != null)
        {
            temp = current.Next;
            current.Next = prev;
            prev = current;
            current = temp;
        }
        Head = prev;
    }

    public Node ReverseRecursively(Node node)
    {
        if (node == null || node.Next == null)
        {
            return node;
        }
        Node remaining = ReverseRecursively(node.Next);
        node.Next.Next = node;
        node.Next = null;
        return remaining;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        Console.WriteLine("Original List: ");
        list.Print();
        list.ReverseIteratively();
        Console.WriteLine("Reversed List (Iteratively): ");
        list.Print();
        list.Head = list.ReverseRecursively(list.Head);
        Console.WriteLine("Reversed List (Recursively): ");
        list.Print();
    }
}
```