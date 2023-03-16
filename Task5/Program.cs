/*
Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает третье число,
456 -> 6
782 -> 2
918 -> 8
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите трехзначное число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int result = number % 10;
Console.WriteLine(result);

