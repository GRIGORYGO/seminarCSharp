/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
int GetNumber(string massege)
{
    int result = 0;
    while (true)
    {
        Console.Write(massege);
        if (int.TryParse(Console.ReadLine(), out result))
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
void GetSquare(int n)
 {
for (int i = 1; i <= n; i++)
{
Console.WriteLine($"{i*i}, ");
}
}

int n = GetNumber("Введите число N: ");
GetSquare (n) ;