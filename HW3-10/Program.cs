// Задача 10 - Показать количество 
// нечетных\четных чисел

int[] arr = new int[7];

for (int i = 0; i <= 6; i++)
{
    arr[i] = new Random().Next(0, 20);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();

int counteven = 0;

for (int i = 0; i <= 6; i++)
{
    if (arr[i]%2 == 0)
    {
        counteven = counteven + 1;
    }
}
Console.WriteLine("Кол-во четных: " + counteven);

int countodd = 7 - counteven;
Console.WriteLine("Кол-во нечетных: " + countodd);
