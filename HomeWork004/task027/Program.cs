/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число больше 0.");
        }
    }

    return result;
}

int GetSumm(int number)
{
    int result = 0;
    for (int i = number; i >= 0; i--)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = GetNumber("Введите число: ");
int summ = GetSumm(number);
Console.WriteLine(($"Сумма цифр в числе {number} = {summ}"));