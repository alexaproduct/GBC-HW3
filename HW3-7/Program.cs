﻿// Задача 7 - Задать массив из 8 элементов,
// заполненных нулями и единицами вывести 
// их на экран

int[] arr = new int[8];

for (int i = 0; i <= 7; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.WriteLine(arr[i]);
}