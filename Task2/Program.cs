/* 
Напишите программу, которая 
на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> 
да a = -3 b = 9 -> нет
*/
Console.WriteLine("Введите первое число: ");
String numberOneStr = Console.ReadLine();
int numberOne = Convert.ToInt32(numberOneStr);

Console.WriteLine("Введите второе число: ");
String numberTwoStr = Console.ReadLine();
int numberTwo = Convert.ToInt32(numberTwoStr);
 
if (numberTwo == numberOne / numberTwo) 
{
Console.WriteLine($" да, число {numberTwo} является квадратом второго числа");
}
else
{
Console.WriteLine($"Нет, число {numberTwo} не является квадратом второго числа");
};
