// Задача 8 - Определить, присутствует ли 
// в заданном массиве, некоторое число

int[] arr = new int[10];

for (int i = 0; i <= 9; i++)
{
    arr[i] = new Random().Next(0, 20);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

for (int i = 0; i <= 9; i++)
{
    if (arr[i] == 19) Console.WriteLine("Да, присутствует");
}
