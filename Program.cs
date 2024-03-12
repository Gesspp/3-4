using System;
using Arrays;

public class Program
{
    public static void Main(string[] args)
    {
        int count, rows, cols, answer;

        iPrinter[] arrays = new iPrinter[8];

        Console.WriteLine("Введите количество элементов линейного массива (int)");
        count = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы хотите заполнить массив самостоятелно? 1 - Да, 2 - Нет");
        answer = int.Parse(Console.ReadLine());
        arrays[0] = new odArray<int>(count, answer == 1);

        Console.WriteLine("Введите количество элементов линейного массива (double)");
        count = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы хотите заполнить массив самостоятелно? 1 - Да, 2 - Нет");
        answer = int.Parse(Console.ReadLine());
        arrays[1] = new odArray<double>(count, answer == 1);

        Console.WriteLine("Введите количество элементов линейного массива (bool)");
        count = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы хотите заполнить массив самостоятелно? 1 - Да, 2 - Нет");
        answer = int.Parse(Console.ReadLine());
        arrays[2] = new odArray<string>(count, answer == 1);

        Console.WriteLine("Введите количество элементов линейного массива (string)");
        count = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы хотите заполнить массив самостоятелно? 1 - Да, 2 - Нет");
        answer = int.Parse(Console.ReadLine());
        arrays[3] = new odArray<bool>(count, answer == 1);



        Console.WriteLine("Введите колличество строк и столбцов двумерного массива на разных строках (int)");
        rows = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы хотите заполнить массив самостоятелно? 1 - Да, 2 - Нет");
        answer = int.Parse(Console.ReadLine());
        arrays[4] = new tdArray<int>(rows, cols, answer == 1);

        Console.WriteLine("Введите колличество строк и столбцов двумерного массива на разных строках (double)");
        rows = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы хотите заполнить массив самостоятелно? 1 - Да, 2 - Нет");
        answer = int.Parse(Console.ReadLine());
        arrays[5] = new tdArray<double>(rows, cols, answer == 1);

        Console.WriteLine("Введите колличество строк и столбцов двумерного массива на разных строках (bool)");
        rows = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы хотите заполнить массив самостоятелно? 1 - Да, 2 - Нет");
        answer = int.Parse(Console.ReadLine());
        arrays[6] = new tdArray<bool>(rows, cols, answer == 1);

        Console.WriteLine("Введите колличество строк и столбцов двумерного массива на разных строках (string)");
        rows = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы хотите заполнить массив самостоятелно? 1 - Да, 2 - Нет");
        answer = int.Parse(Console.ReadLine());
        arrays[7] = new tdArray<string>(rows, cols, answer == 1);



        for (int i = 0; i < arrays.Length; i++)
        {
            arrays[i].Print();
        }

    }
}