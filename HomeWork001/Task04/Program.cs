/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число: ");
string numfirst = Console.ReadLine() ?? "";

Console.WriteLine("Введите второе число: ");
string numsecond = Console.ReadLine() ?? "";

Console.WriteLine("Введите третье число: ");
string numthird = Console.ReadLine() ?? "";

int nfirst = Convert.ToInt32(numfirst);
int nsecond = Convert.ToInt32(numsecond);
int nthird = Convert.ToInt32(numthird);

if (nfirst == nsecond & nsecond == nthird)
{
    Console.WriteLine("Все числа равны");
}
else
{
    if (nfirst >= nsecond & nfirst > nthird)
    {
        Console.WriteLine($"{nfirst} - максиальное число");
    }
    else if (nsecond > nfirst & nsecond >= nthird)
        {
            Console.WriteLine($"{nsecond} - максиальное число");
        }
        else if (nthird > nfirst & nthird > nsecond)
            {
                Console.WriteLine($"{nthird} - максиальное число");
            }
}