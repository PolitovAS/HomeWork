/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,0,1)
34(0,1,0) 41(0,1,1)
27(1,0,0) 90(1,0,1)
26(1,1,0) 55(1,1,1)
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message + " ");

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}

int[,,] InitMatrix(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " " + (i, j, k) + " ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int m = GetNumber("Введите количество страниц: ");
int n = GetNumber("Введите количество строк: ");
int l = GetNumber("Введите количество столбцов: ");
int[,,] matrix = InitMatrix(m, n, l);
PrintMatrix(matrix);