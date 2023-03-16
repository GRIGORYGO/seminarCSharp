/*
*Напишите программу, которая будет принимать на вход два числа
и проверяет является ли одно число квадратом другого 
*/

int Getnumber(string masseg)
{
 Console.WriteLine(masseg);
 String numberStr = Console.ReadLine();
 int number = Convert.ToInt32(numberStr);
 return number;
}
int numberOne = Getnumber("Введите первое числа");
int numberTwo = Getnumber("Введите второе числа");
if (numberTwo == numberOne * numberOne || numberOne == numberTwo * numberTwo)
 {
 Console.WriteLine("Да, является квадратом");
 }
 else Console.WriteLine("нет не является квадратом");