/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int line = 4;
int[,] matrix = new int[line, line];
int count = 1;
for (int x = 0; x < (line * line); x++)
{
    for (int i = x; i < line - x; i++)
    {
        matrix[x,i] = count;
        count++;
    }
    for (int i = x + 1; i < line - x; i++)
    {
        matrix[i, line - 1 - x] = count;
        count++;
    }
    for (int i = line - 2 - x; i >= x; i--)
    {
        matrix[line - 1 - x, i] = count;
        count++;
    }
    for (int i = line - 2 - x; i > x; i--)
    {
        matrix[i, x] = count;
        count++;
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t");
    }
    System.Console.WriteLine("\n");
}
System.Console.WriteLine();
