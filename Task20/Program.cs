/*
Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9,10);
    }

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void GetChangePossitionArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    arr[i] = arr[i] * -1;
    
    }

    
}


int [] arr = InitArray();


PrintArray(arr);
GetChangePossitionArray(arr);
PrintArray(arr);

