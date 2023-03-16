/*Задача 63: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от 1 до N. 
Выполнить с помощью рекурсии.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не цифру, попробуйте еще раз: ");
        }
    }
    return result;
}

string WriteNubers(int number)
{
    if (number == 1) return ("1 ");
    else
    {
        return WriteNubers(number - 1) + ", " + number;
    }
}


int num = GetNumber ("введите натуральное число: ");
Console.WriteLine(WriteNubers(num));