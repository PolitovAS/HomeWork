/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = GetNumber("Введите значение M: ");
int n = GetNumber("Введите значение N: ");
Console.WriteLine();

if (m >= n)
    Console.WriteLine("Первое число не меньше последнего. Расчитать сумму не возможно.");
else
    NumbersSumm(m, n, 0);

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

void NumbersSumm(int m, int n, int summ)
{
    summ += n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    NumbersSumm(m, n - 1, summ);
}