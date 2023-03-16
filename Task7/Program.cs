/* Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.
456 -> 46
782 > 72
*/

int Getnumber ()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000);
    return result;
}

int GetNumberwithoutSecondNumber ( int number )
{
    int FirstDigit = number / 100;
    int SecondDigit = number % 10;
    int result = FirstDigit * 10 + SecondDigit;
    return result;

}
int number = Getnumber();
Console.WriteLine($"сгенерированное число: {number}");
int number2 = GetNumberwithoutSecondNumber(number);
Console.WriteLine($"{number2}");
