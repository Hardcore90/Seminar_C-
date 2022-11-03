// Задача 67. Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumDigitsOfNumber(int num)
{
    int sum = (num % 10);
    if(num > 0) 
    sum = sum + SumDigitsOfNumber(num/10);
    return sum;
}
int res = SumDigitsOfNumber(number);
Console.WriteLine($"Сумма цифр числа {number} равна {res}");