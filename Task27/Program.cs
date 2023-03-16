/*
Задача 39: Напишите программу, которая перевернёт одномерный 
массив (последний элемент будет на первом месте, а первый
- на последнем и т.д.)
[1 2 3 4 5]
[5 4 3 2 1]
[6 7 3 6 1]
*/

int [] InitArray (int dimantion)
{
    int [] result = new int [dimantion];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
       result[i] = rnd.Next(1,10);
    }
    return result;
}

void PrintArray (int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        if (i == arr.Length -1 )
        {
           Console.Write("]");
           
        }
    } 
    Console.WriteLine (); 
}

int [] ReverseArray(int [] arr)
{
int [] result = new int [arr.Length];
int count = 0;
for (int i = result. Length - 1; i >= 0; i--)
{
result [count] = arr[i];
count++;
}
return result;
}

int[] result = InitArray(5);
PrintArray(result);
int[] array = ReverseArray(result);
PrintArray(array);