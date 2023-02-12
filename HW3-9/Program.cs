// Задача 9 - Задать массив, заполнить случайными 
// положительными трёхзначными числами. 

int[] arr = new int[16];

for (int i = 0; i <= 15; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();