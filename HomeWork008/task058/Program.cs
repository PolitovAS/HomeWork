/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    try
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    catch { }
    return matrix3;
}

int m1 = GetNumber("Введите количество строк первой матрицы:");
int n1 = GetNumber("Введите количество столбцов первой матрицы:");
int m2 = GetNumber("Введите количество строк второй матрицы:");
int n2 = GetNumber("Введите количество столбцов второй матрицы:");
Console.WriteLine();
int[,] matrix1 = InitMatrix(m1, n1);
int[,] matrix2 = InitMatrix(m2, n2);
int[,] matrix3 = MultMatrix(matrix1, matrix2);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
if (matrix1.GetLength(0) != matrix2.GetLength(1))
{
    System.Console.WriteLine("Умножение не возможно!");
}
else
{
    PrintMatrix(matrix3);
}

