﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.

Console.Write ("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());

if (a%b == 0){
    Console.WriteLine ($"Число {a} кратно числу {b}.");
}
else{
    int c = a%b;
    Console.WriteLine ($"Число {a} не кратно числу {b}. Остаток от деления равен {c}.");
}