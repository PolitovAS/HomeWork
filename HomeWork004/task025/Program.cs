/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// 1-й способ решения, без использования метода на проверку корректности вводимых чисел
/*Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}

Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {result}");*/

// 2-й способ решения, с использованием методов
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число.");
        }
    }

    return result;
}

int GetPow(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }

    return result;
}

int a = GetNumber("Введите первое число: ");
int b = GetNumber("Введите второе число: ");
int pow = GetPow(a, b);

Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {pow}");
