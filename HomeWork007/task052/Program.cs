/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите количество строк:\t");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов:\t");
int n = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[m, n];
Random rnd = new Random();

//Заполняем массив
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(-10, 10);
    }
}

//Выводим массив
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

//Ищем средне арифметическое. Почему оно так работает, так и не понял. Методом тыка
for (int i = 0; i < array.GetLength(1); i++)
{
    float avg = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        avg += array[j, i];        
    }
    avg = avg / array.GetLength(0);
    Console.WriteLine($"Среднее арифметическое в столбце {i}: {Math.Round(avg, 2)}");       
}

