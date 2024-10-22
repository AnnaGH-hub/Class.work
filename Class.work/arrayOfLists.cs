using System;
using System.Collections.Generic;

class ArrayOfLists
{
    private List<int>[] arrayOfLists;
    public ArrayOfLists(int size)
    {
        arrayOfLists = new List<int>[size];
        for (int i = 0; i < size; i++)
        {
            arrayOfLists[i] = new List<int>();
        }
    }

    public void Add(int index, int item)
    {
        arrayOfLists[index].Add(item);
    }

    public void PrintAll()
    {
        for (int i = 0; i < arrayOfLists.Length; i++)
        {
            Console.WriteLine($"List at index {i}: {string.Join(", ", arrayOfLists[i])}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayOfLists arrayOfLists = new ArrayOfLists(3);

        arrayOfLists.Add(0, 10);
        arrayOfLists.Add(0, 20);
        arrayOfLists.Add(1, 30);
        arrayOfLists.Add(2, 40);

        arrayOfLists.PrintAll();
    }
}
