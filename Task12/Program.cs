/* 
Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек 
 в этой четверти (х и у).
 */

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)
        && result > 0 && result < 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
        
    }
    return result;
}

string Getrange(int quarter)
{
    if (quarter == 1)
        return "x от нуля до плюс бесконечности, у от нуля до плюс беспонечности";
    else if (quarter == 2)
        return "x от нуля до минус бесконечности, у от нуля до плюс бесконечности";
    else if (quarter == 3)
        return "x от нуля до минус бесконечности, у от нуля до минус бесконечности";
    else
        return "x от нуля до плюс бесконечности, у от нуля до минус бесконечности";
}
int number = GetNumber("Ввудите номер четверти:");
string range = Getrange(number);
Console.WriteLine(range);
