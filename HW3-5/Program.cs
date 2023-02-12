// Задача 5 - Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите A: ");
decimal A = decimal.Parse(Console.ReadLine());

if (A>27) Console.WriteLine("Введите число меньше 27 включительно");
else
{
    decimal result = 1;
    for (int i = 1; i <= A; i++)
    {
        result = result*i;
    }
    Console.WriteLine(result);
}