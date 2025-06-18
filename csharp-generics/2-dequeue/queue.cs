﻿using System;

public class Node<T>
{
    public T Value;
    public Node<T> Next;

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}

public class Queue<T>
{
    private Node<T> head;
    private Node<T> tail;
    private int count;

    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void Enqueue(T value)
    {
        Node<T> newNode = new Node<T>(value);
        if (tail != null)
        {
            tail.Next = newNode;
        }
        tail = newNode;
        if (head == null)
        {
            head = newNode;
        }
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T); // Return default value for type T
        }

        T value = head.Value;
        head = head.Next;
        count--;

        if (head == null) // If the queue is now empty, set tail to null
        {
            tail = null;
        }

        return value;
    }

    public int Count()
    {
        return count;
    }
}
