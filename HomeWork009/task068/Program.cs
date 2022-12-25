/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
Console.WriteLine();
Console.WriteLine(AсkermanFunct(m, n));

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели неотрицательное число, либо не число");
        }
    }
    return result;
}

int AсkermanFunct(int n, int m)
{
    if(n == 0)
        return m + 1;
    if((n !=0) && (m == 0))
        return AсkermanFunct(n - 1, 1);
    if(n > 0 && m > 00)
        return AсkermanFunct(n - 1, AсkermanFunct(n, m - 1));
    return AсkermanFunct(m,n);
}