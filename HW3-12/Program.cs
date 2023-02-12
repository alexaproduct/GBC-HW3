// Задача 12 - Найти сумму чисел 
// одномерного массива
// стоящих на нечетной позиции

int[] arr = new int[7];

for (int i = 0; i <= 6; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

int sumoddi = 0;

for (int i = 0; i <= 6; i++)
{
    if (i%2 != 0)
    {
        sumoddi = sumoddi + arr[i];
    }
}
Console.WriteLine("Сумма на нечетных позициях: " + sumoddi);