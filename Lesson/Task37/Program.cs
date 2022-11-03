// Задача 65. Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
void NaturalNumbersFromMToN(int numM, int numN)
{
    if(numM < numN)
    {
        NaturalNumbersFromMToN(numM, numN - 1);
        Console.Write($" {numN} ");
    }
    if(numM > numN)
    {
        Console.Write($" {numM} ");
        NaturalNumbersFromMToN(numM - 1, numN);
    }
    if(numN == numM)  Console.Write($" {numM} ");
}
Console.Write($"M = {m}, N = {n} ->");
NaturalNumbersFromMToN(m, n);
