// Задача 11 - В одномерном массиве из 123 
// чисел найти количество элементов из 
// отрезка [10,99]

int[] arr = new int[123];

for (int i = 0; i <= 122; i++)
{
    arr[i] = new Random().Next(0, 200);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

int count = 0;

for (int i = 0; i <= 122; i++)
{
    if (arr[i] >= 10 && arr[i] <= 99)
    {
        count = count + 1;
    }
}
Console.WriteLine("Кол-во количество элементов из отрезка [10,99]: " + count);
