// Задача 4 - Подсчитать сумму цифр в числе

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

int result = 0;

while (N>0)
{
    result = result + N%10;
    N = N/10;
}
Console.WriteLine(result);