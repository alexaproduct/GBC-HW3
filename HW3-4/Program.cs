// Задача 4 - Подсчитать сумму цифр в числе

// Определить количество цифр в числе

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

int i = 0;

while (N>0)
{
    i++;
    N/=10;
}
Console.WriteLine("Количество чисел: "+ i);