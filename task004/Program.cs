﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


void Multiply(int numb)
{
    if (numb % 7 == 0 && numb % 23 == 0)
    {
        Console.WriteLine("Данное число кратно и 7 и 23 одновременно");
    }
    else
    {
        Console.WriteLine("Данное число не кратно и 7 и 23 одновременно");
    }
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Multiply(number);
