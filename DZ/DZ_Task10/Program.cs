// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool IsFiveDigitNumber(int a)
{
    return a / 10000 == 0 || a / 100000 > 0;
}
if(IsFiveDigitNumber(number)) Console.WriteLine("Число не пятизначное!");
else 
{
    bool IsNumPolidrom(int num)
    {
        int num1 = num / 10000;
        int num5 = num % 10;
        int num2 = num / 1000;
            num2 = num2 % 10;
        int num4 = num / 10;
            num4 = num4 % 10;
        return num1 == num5 && num2 == num4;
    }
if(IsNumPolidrom(number)) Console.WriteLine($"{number} -> Да!");
else Console.WriteLine($"{number} -> Нет!");
}