// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.

Console.Write ("Рандомное число из отрезка [10, 9999]: ");
int a = new Random().Next (10,100);
Console.WriteLine (a);

int b = a % 10;
int c = a / 10;
if (b>c){
    Console.WriteLine ($"Наибольшая цифра {b}.");
}
if (c>b){
    Console.WriteLine ($"Наибольшая цифра {c}.");
}
if (b == c){
    Console.WriteLine ($"Цифры в числе равны.");
}