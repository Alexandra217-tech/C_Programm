﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 6)
{
    Console.WriteLine("no");
}
else
{
   Console.WriteLine("yes"); 
}