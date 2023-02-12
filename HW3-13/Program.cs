// Задача 13 - Найти произведение пар чисел 
// в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д.


int[] arr = new int[7];

for (int i = 0; i <= 6; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

int product = 1;
int j = 7;

for (int i = 0; i <= 6; i++)
{
    j = j-1;
    product = arr[i] * arr [j];
    Console.WriteLine(product);
    if (i>=j) break;
}
Console.WriteLine();
