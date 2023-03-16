/*
Напишите программу, которая будет выдавать название дня недели 
по заданному номеру.
3 -> среда; 5 -> пятница
*/
Console.WriteLine("Введите число: ");
String numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if(number == 1) 
Console.WriteLine("понедельник");
else if(number == 2) 
Console.WriteLine("вторник");
else if(number == 3) 
Console.WriteLine("среда");
else if(number == 4) 
Console.WriteLine("четверг");
else if(number == 5) 
Console.WriteLine("пятница");
else if(number == 6) 
Console.WriteLine("суббота");
else if(number == 7) 
Console.WriteLine("воскресенье");
else
Console.WriteLine("Вы ввели не день недели");
