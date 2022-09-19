// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsThreeDigitNumber(int a)
{
    return a / 100 == 0;
}

if(IsThreeDigitNumber(number)) Console.WriteLine($"{number} -> Третьей цифры нет!");
else
{
int ThirdDigitOfNumber(int num)
{
    while(num / 1000 > 0)
    {
        num = num / 10;
    }
    return num % 10;
}
int result = ThirdDigitOfNumber(number);
Console.WriteLine($"{number} -> {result}!");
}