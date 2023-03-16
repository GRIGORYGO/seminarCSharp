/* Задача 33: Задайте массив. Напишите программу, которая
 определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
- 3; массив [6,7, 19,345,3]да */

int[] InitArray()
{
    int[] result = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 400);
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        if (i == arr.Length-1)
        {
            Console.Write("]");
        }
    }
    Console.WriteLine();
}

string GetCheckArray(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)

        {
            return "Да";
        }
    }
    return "He";
}

    int[] arr = InitArray();
    PrintArray(arr);
   
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    string check = GetCheckArray(arr, number);
    Console.Write(check);