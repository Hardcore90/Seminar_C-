// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool IsThreeDigitNumber(int a)
{
    return a / 100 == 0 || a / 1000 > 0;
}

if(IsThreeDigitNumber(number)) Console.WriteLine("Число не трёхзначное!");
else
{
int ShowSecondDigit(int num)
{
    int result = num / 10;
    result = result % 10;
    return result;
}
int secondDigit = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}!");
}