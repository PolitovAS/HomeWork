/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число: ");
string nfirst = Console.ReadLine() ?? "";
int n = Convert.ToInt32(nfirst);
int count = 1;

if (n <= count)
{
    Console.Write("Число меньше необходимого минимального диапазона");
}
while (count < n+1)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count = count + 1;
}
