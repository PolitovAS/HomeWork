/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void Numbers(int i)
{

    if (i <= 0 == false)
    {
        Console.Write(i + (i != 1 ? ", " : ""));
        if (i <= 1)
            return;
        i--;
        Numbers(i);
    }
    else
    {
        Console.Write(i + (i != 1 ? ", " : ""));
        if (i >= 1)
            return;
        i++;
        Numbers(i);
    }
}

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
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int n = GetNumber("Введите значение N: ");
Console.WriteLine();
Numbers(n);
