﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 99)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while(a > 1000)
    {
        a /= 10;
    }
    Console.WriteLine($"третья цифра заданного числа {a%10}");
}
