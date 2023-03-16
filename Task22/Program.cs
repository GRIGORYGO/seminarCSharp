/*
Напишите программу замена элементов массива:
положительные элементы замените на соответствующие
 отрицательные,
[-4, -8, 8, 2] -> 14, 8, -8,-2]*/

int [] InitArray ()
{
    int [] result = new int [12];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
       result[i] = rnd.Next(-9,20);
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

void GetChangeNumber (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
     arr[i] = arr[i] * -1;
        
    }
    
}


int [] arr = InitArray ();
PrintArray(arr);
GetChangeNumber(arr);
PrintArray(arr);