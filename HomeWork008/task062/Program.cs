/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();
int[,] matrix = new int[rows, columns];
int count = 1;
for (int x = 0; IsNeed(x, rows, columns); x++)
{
    for (int i = x; i < columns - x; i++)
    {
        matrix[x, i] = count;
        count++;
    }
    for (int i = x + 1; i < rows - x; i++)
    {
        matrix[i, columns - 1 - x] = count;
        count++;
    }
    for (int i = columns - 2 - x; i >= x; i--)
    {
        matrix[rows - 1 - x, i] = count;
        count++;
    }
    for (int i = rows - 2 - x; i > x; i--)
    {
        matrix[i, x] = count;
        count++;
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine("\n");
}
Console.WriteLine();


bool IsNeed(int x, int rows, int columns)
{
    if(rows < columns)
    {
        if(rows % 2 == 0)
            return x < rows / 2;
        else
            return x <= rows / 2;
    }
    
    if (columns % 2 == 0)
        return x < columns / 2;
    else
        return x <= columns / 2;
}