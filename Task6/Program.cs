/*
напишите программу, которая выводит случайное число из отрезка [10, 99]
 и показывает наибольшую цифру числа.
Например:
78 -> 8
12-> 2
85 -5 9
*/
/* 1. найти randomnoe число;
 2. наити наибольшее число;
   */

int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(10, 100); // [10, 100)
    return result;
}

int GetMaxDigit0fNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetNumber();
Console.WriteLine($" сгенерированное число: {number}");
int maxDigit = GetMaxDigit0fNumber(number);
Console.WriteLine($"максимальная цифра числа {number} = {maxDigit}");