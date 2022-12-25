//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int del1 = number%100;
int del2 = del1/10;
Console.WriteLine("Вторая цифра числа: " + del2);