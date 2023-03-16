/*Напишите программу, которая на вход принимает число и выдает его квадрат
 (число умноженное на само себя).
 Например:
4 = 16
-3 = 9
-7 = 49 
*/
Console.WriteLine("Введите число: ");
String numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int resulte = number * number;
Console.WriteLine($"Квадрат числа {number} = {resulte}");
