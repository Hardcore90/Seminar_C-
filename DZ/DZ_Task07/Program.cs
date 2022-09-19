// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
bool IsWeekend(int num)
{
    return num == 6 || num == 7;
}
if(number < 1 || number > 7) Console.WriteLine("Такого дня недели не существует!");
else if (IsWeekend(number)) Console.Write($"{number} -> да!");
else Console.Write($"{number} -> нет!");
if (IsWeekend(number)) Console.WriteLine("Выходной!");

