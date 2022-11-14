// написать программу, которая на вход принимает число и выдает, является ли число чётным

Console.WriteLine("Введите число ");
int num = Convert.ToInt32 (Console.ReadLine ());
if (num % 2 == 0) Console.WriteLine("Чётное");
else Console.WriteLine ("Нечётное");