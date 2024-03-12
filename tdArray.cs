using System;
namespace Arrays;

sealed internal class tdArray<T> : bArray, ITDArray
{
    public T[,] array;

    public tdArray(int rows, int columns, bool fillByUser = false) : base(fillByUser)
    {
        array = new T[rows, columns];

        if (fillByUser)
        {
            userArray();
        }
        else
        {
            randomArray();
        }
    }

    public void ReCreate(int rows, int columns)
    {
        array = new T[rows, columns];
        userArray();
    }

    protected override void userArray()
    {
        Console.WriteLine("Введите значения матрицы:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = (T)(object)int.Parse(values[j]);
            }
        }
    }

    protected override void randomArray()
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = RandomGenerator<T>.RandomValue();
            }
        }
    }

    public override void Print()
    {
        Console.WriteLine("Элементы матрицы:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void reverse()
    {
        Console.WriteLine("Элементы матрицы с четными строками в обратном порядке:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 1)
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}