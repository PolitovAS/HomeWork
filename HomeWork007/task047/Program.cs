/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Введите количество строк:\t");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов:\t");
int n = int.Parse(Console.ReadLine() ?? "");
double[,] array = new double[m, n];
Random rnd = new Random();

//Заполняем массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round((rnd.NextDouble() * 40 - 20), 1);
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