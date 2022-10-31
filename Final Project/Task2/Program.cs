// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m < 0) Console.WriteLine("M - не натуральное число!");
if(n < 0) Console.WriteLine("N - не натуральное число!");
if(n > 0 && m > 0)
{
    int res = SumNaturalNumbersFromMToN(m, n);
    Console.WriteLine($"M = {m}, N = {n} -> {res}!");
}
int SumNaturalNumbersFromMToN(int num1, int num2)
{
    int sum = 0;
    for (int i = num1; i <= num2; i++)
    {
        sum = sum + i;
    }
    return sum;
}