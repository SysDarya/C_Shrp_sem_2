// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write ("Введите трехзначное число: ");
int a = Convert.ToInt32 (Console.ReadLine());

if (a>99 && a<1000){
    int a1 = a%10;
    Console.WriteLine ($"Последняя цифра числа {a} равна {a1}.");
}
else{
    Console.WriteLine ("Пожалуйста, введите число из трех знаков.");
}