// Задача 3 - Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите B: ");
int B = int.Parse(Console.ReadLine());

double pow = Math.Pow(A, B);

Console.WriteLine(pow);