// Задача 63. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

Console.WriteLine("Введите N:");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 0) return;
    else NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}
Console.Write($"N = {number} -> ");
NaturalNumbers(number);