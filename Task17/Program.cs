/*
Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetNumber(string massege)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massege);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не коректное число, попробуйте еще раз:");
        }
    }
    return result;
}

int GetDegit (int number)
{
   string numberStr = number.ToString();
   return numberStr.Length;
}

int number = GetNumber("Введите число: ");
int digit = GetDegit (number);
Console.WriteLine($"Количество цифр в числе = {digit}");
