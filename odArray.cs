using System;
using System.ComponentModel.DataAnnotations;

namespace Arrays;

sealed internal class odArray<T> : bArray, ILineArray
{
    private T[] array;

    public odArray(int length, bool fillByUser = false) : base(fillByUser)
    {
        array = new T[length];
        if (fillByUser)
        {
            userArray();
        }
        else
        {
            randomArray();
        }
    }

    public void ReCreate(int length)
    {
        array = new T[length];
        userArray();
    }

    protected override void userArray()
    {
        Console.WriteLine("Введите значения массива:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (T)(object)int.Parse(Console.ReadLine());
        }
    }

    protected override void randomArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = RandomGenerator<T>.RandomValue();
        }
    }

    public override void Print()
    {
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public void removeRepeat()
    {
        T[] newArray = new T[array.Length];
        int newIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Array.IndexOf(newArray, array[i]) == -1)
            {
                newArray[newIndex] = array[i];
                newIndex++;
            }
        }
        Array.Resize(ref newArray, newIndex);
        array = newArray;
    }
}