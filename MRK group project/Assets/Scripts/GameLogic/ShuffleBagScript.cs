using System.Collections;
using System.Collections.Generic;
using System;

public class ShuffleBag 
{
    private Random random = new Random();
    private List<char> data;

    private char currentItem;
    private int currentPosition = -1;

    private int Capacity { get { return data.Capacity; } }
    public int Size { get { return data.Count; } }

    public ShuffleBag(int initCapacity)
    {
        data = new List<char>(initCapacity);

    }
    public void Add(char item, int amount)
    {
        for (int i = 0; i < amount; i++)
            data.Add(item);

        currentPosition = Size - 1;
    }
    public char Next()
    {
        if (currentPosition < 1)
        {
            currentPosition = Size - 1;
            currentItem = data[0];

            return currentItem;
        }

        var pos = random.Next(currentPosition);

        currentItem = data[pos];
        data[pos] = data[currentPosition];
        data[currentPosition] = currentItem;
        currentPosition--;

        return currentItem;
    }

}