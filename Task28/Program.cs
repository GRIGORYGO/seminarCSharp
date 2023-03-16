/*
/* Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -› 11
2 -> 10*/
int GetNumber(string massege)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massege);
        if (int.TryParse(Console.ReadLine(), out result))
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


int[] GetResult(int number)
{
    List<int> result = new List<int>();
    
    while (number > 0)
    {
        result.Add(number % 2);
        number /= 2;
    }
    return result.ToArray();
}
int num = GetNumber ("Введите число: ");
int [] arr = GetResult (num) ;
Console.Write(String.Join(" ", arr));