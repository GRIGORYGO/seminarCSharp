/*
Пользователь вводит с клавиатуры M чисел. Посчитайте,
 сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int Prompt (string massege)
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
            Console.WriteLine("Ввели не цифроб попробуйте еще раз: ");
        }
    }
    return result;
}

int[] InputArray(int lenght)
{
    int[] resultArray = new int[lenght];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Prompt ($"Ввeдите {i + 1} ий элемент");
    }
    return resultArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        if (i == arr.Length - 1)
        {
            Console.Write("]");

        }
    }
}
int CountPositivNumber (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] > 0)
      {
        count ++; //count = count + 1
      }  
    }
    return count;
}

int lenght = Prompt ("Ввeдите количество элементов >");
int []arr;
arr = InputArray(lenght);
PrintArray(arr);
int result = CountPositivNumber(arr);
Console.WriteLine($"Количетво чисел > 0 = {CountPositivNumber(arr)}");