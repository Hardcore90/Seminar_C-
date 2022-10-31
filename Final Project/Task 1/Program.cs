// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NumbersFromNTo1(int num)
{
    if(num < 0) Console.WriteLine("Не натуральное число!");
    else if(num == 0) return;
    else
    {
        Console.Write($"{num} ");
        NumbersFromNTo1(num - 1);
    }
}
Console.Write($"N = {n} -> ");
NumbersFromNTo1(n);