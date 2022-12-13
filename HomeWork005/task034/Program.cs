/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

//получить размерность массива с консоли
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

//получить заполненный массив рандомными положительными трехзначными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

    return array;
}

//распечатать массив на консоль 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

//найти количество четных чисел
int GetCountEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArray(array);
int countEven = GetCountEven(array);
Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
