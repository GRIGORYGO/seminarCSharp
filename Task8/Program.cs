/* 
Напишите программу, которая будет принимать на вход два числа и
выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток
от деления.
34, 5 -> не кратно, остаток 4
*/
/* 
int GetNumber ()
{
Random rnd = new Random();
int result = rnd.Next(1,100);
return result;
}
*/

int GetNumber(string massig)
{ 
    Console.WriteLine(massig);
    String numberStr =Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    return number;
}

int numberOne = GetNumber("Введите первое число: ");
int numberTwo = GetNumber("Введите второе число: ");

if (numberOne % numberTwo == 0 )
{
    Console.WriteLine($"{numberTwo} является число кратным первому");
}
  else 
  Console.WriteLine ($"{numberTwo} не кратно {numberOne}, остаток от деления = {numberOne % numberTwo}");
 


