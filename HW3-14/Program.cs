// Задача 14 - В Указанном массиве 
// вещественных чисел найдите разницу 
// между максимальным и минимальным элементом

int[] arr = new int[7];

for (int i = 0; i <= 6; i++)
{
    arr[i] = new Random().Next(-10, 10);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

for (int i = 0; i <= 6; i++)
{
    arr.Min();
    arr.Max();
}
Console.WriteLine("Minimum number is " + arr.Min());
Console.WriteLine("Maximum number is " + arr.Max());

int min = arr.Min();
int max = arr.Max();

int diff = max - min;
Console.WriteLine("Difference is " + diff);

Console.WriteLine();

Console.WriteLine("Другое решение");

int max1 = 0;
int min1 = 0;

for (int i = 0; i <= 6; i++)
{
    if (arr[i]< min1) min1 = arr[i];
}
Console.WriteLine("Minimum number is " + min1);

for (int i = 0; i <= 6; i++)
{
    if (arr[i]> max1) max1 = arr[i];
}
Console.WriteLine("Maximum number is " + max1);

int diff1 = max1 - min1;

Console.WriteLine("Difference is " + diff1);