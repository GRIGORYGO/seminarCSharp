/*Задача 65: Задайте значения
Напишите программу, которая выведет все натуральные числа 
в промежутке от М до N.
M = 1; N = 5 -> 1,2,3,4,5
*/
int GetNumber(string msg)
{
    Console.Write(msg);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Ввели не цифру, попробуйте еще раз: ");
    }
    return result;
}

string WriteNubers(int m, int n)
{
    if (n == m) return ($"{m} ");
    else 
    {
       return WriteNubers(m,n - 1) + " " + n.ToString();
    }
}


int m = GetNumber("Bведите число M -> ");
int n = GetNumber("Bведите число N -> ");
Console.WriteLine(WriteNubers(m,n));

