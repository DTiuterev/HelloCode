// Нахождение большего и меньшего чисел из двух вводимых
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write($"Число {numberA} > числа {numberB}");
}
else if (numberA < numberB)
{
           Console.Write($"Число {numberA} меньше числа {numberB}");
}
else
{
        Console.Write("Числа равны");
}
