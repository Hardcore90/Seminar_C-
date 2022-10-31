// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m < 0) Console.WriteLine("m - отрицательное число!");
if(n < 0) Console.WriteLine("n - отрицательное число!");
if(m >= 0 && n >= 0)
{
    int res = FunctionAkkerman(m, n);
    Console.WriteLine($"m = {m}, n = {n} -> {res}");
}
int FunctionAkkerman(int num1, int num2)
{
  if (num1 == 0)
    return num2 + 1;
  else
    if ((num1 != 0) && (num2 == 0))
      return FunctionAkkerman(num1 - 1, 1);
    else
      return FunctionAkkerman(num1 - 1, FunctionAkkerman(num1, num2 - 1));
}