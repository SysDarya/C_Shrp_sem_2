// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.

Console.Write ("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите третье число: ");
int c = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите четвертое число: ");
int d = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите пятое число: ");
int e = Convert.ToInt32 (Console.ReadLine());

int sum = a + b + c + d + e;
double mid = sum/5;

Console.WriteLine ($"Сумма чисел равна {sum}, а среднее арифметическое равно {mid}.");