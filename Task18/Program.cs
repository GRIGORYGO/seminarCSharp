/*
Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int GetNumber (string massege)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine ("введите число: ");
       if (int.TryParse(Console.ReadLine(), out result))
       {
        break;
       }
       else
       {
        Console.WriteLine("Ввели не цифроб попробуйте еще раз: ");
       }
    }
    return result;
}

int GetProduct(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++ )
    {
      product = product * i;  //product *= i
    }
    return product;
}
int number = GetNumber("Введите число: ");
int product = GetProduct(number);
Console.WriteLine($"Произведение чисел от 1 до {number}  = {product}");