// Задача 3 - Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите B: ");
int B = int.Parse(Console.ReadLine());

int power = 1;

for (int i = 1; i <= B; i++)
{
    power = power * A;
}

Console.WriteLine(power);