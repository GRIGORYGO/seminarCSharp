/*
Напишите программу, которая принимает на вход число
и проверяет, кратно ли оно одновременно 7 и 23.
*/
int GetNumber(string massig)
{
Console.Write("Введите число: ");
String numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
return number;
}
int number = GetNumber("Введите число");
if (number % 7 ==0 && number % 23 ==0) 
{ 
 Console.WriteLine($"{number} кратно и 7 и 23");
}
else 
    Console.WriteLine($"{number} не кратно");