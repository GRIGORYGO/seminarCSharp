/*
 Напишите прогоамму, которая поинимает на вход кординаты точки Х и Y
причем x не равн О, и у не равно 0, выдаёт номер четверти 
плоскости. в которой находится эта точка.
1. получить число с консоли
2.получить номер четверти
3. вывести на экран результат
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result != 0) //23
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

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else return 4;
}

int x = GetNumber("Введите x:");
int y = GetNumber("Введите у:");
int quarter = GetQuarter(x, y);
Console.WriteLine($"точка с координатами ({x}, {y}) лежит в {quarter} четверти");