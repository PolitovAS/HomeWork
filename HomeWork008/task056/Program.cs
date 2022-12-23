/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);           
        }        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinString(int[,] matrix)
{
int min = 0;
int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int summ = 0;   
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summ = summ + matrix[i,j];
    }        
    Console.WriteLine($"Это сумма элементов в {i + 1} строке: {summ}");
    if (i == 0)
    {
        min = summ;
    }
    else if(summ < min)
    {
        min = summ;
        count = i;
    }
}
Console.WriteLine();
return count;
}

int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов:");
Console.WriteLine();
int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine($"Минимальная сумма элементов в строке {(MinString(matrix) + 1)}");
