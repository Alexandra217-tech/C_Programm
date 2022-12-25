// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Write("Введите число : ");
string number = (Console.ReadLine());
if (number.Length>2)
{
    char thirdChar = number[2];
    Console.WriteLine(thirdChar);
}
else
{
   Console.WriteLine("Третьей цифры нет"); 
}