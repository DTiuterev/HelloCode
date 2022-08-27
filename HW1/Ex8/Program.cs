// Программа печати всех четных чисел от 1 до вводимого оператором числа
Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= numberA; i+=2)
{
    Console.Write(i);
}