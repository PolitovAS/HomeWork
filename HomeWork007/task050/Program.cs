/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1,7 -> такого числа в массиве нет
*/

Console.Write("Введите количество строк:\t");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов:\t");
int n = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[m, n];
Random rnd = new Random();

//Заполняем массив
for (int i = 0; i <array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(-10, 10);
    }
}

//Выводим массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Введите индекс искомой строки:\t");
int mDesired = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите индекс искомого столбца:\t");
int nDesired = int.Parse(Console.ReadLine() ?? "");

if (mDesired < 0 | mDesired > array.GetLength(0) - 1 | nDesired < 0 | nDesired > array.GetLength(1) - 1)
    Console.WriteLine("Такого числа в массиве нет!");
else
    Console.WriteLine($"Значение элемента с индексами ({mDesired}, {nDesired}): {array[mDesired, nDesired]}");