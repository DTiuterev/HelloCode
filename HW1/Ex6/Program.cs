﻿// Программа определения четности вводимого числп
Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
    Console.WriteLine($"Число {numberA} четное");
else
    Console.WriteLine($"Число {numberA} нечетное");
