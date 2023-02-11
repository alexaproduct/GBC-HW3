// Задача 1 - Найти кубы чисел от 1 до N

Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} x {i} x {i} = {i*i*i}");
}
Console.WriteLine();
