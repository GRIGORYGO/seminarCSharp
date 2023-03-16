/*
Задача 31: Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9, -8,1,0, -7,2,-1,8, -3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9, 10);
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        if (i == arr.Length - 1)
        {
            Console.Write(']');
        }
    }
    Console.WriteLine();
}

/*int GetSumOfPositive (int[]arr)
{
  int sumresult = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i>0)
    sumresult = sumresult + arr[i];
    
  }
  return sumresult;
}
int GetSumOfNegative (int[]arr)
{
  
  int negresult = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(i<0)
    negresult = negresult + arr[i];
  }
  return negresult;

}*/


(int, int) GetSumsInArray(int[] arr)
{
    int negativeSum = 0;
    int positiveSum = 0;
    for (int i = 0; 1 < arr.Length; i++)
    {
        if(arr[i]>0)
            positiveSum += arr[i];
        else negativeSum += arr[i];
    }
    return (negativeSum, positiveSum);
}

int[] arr = InitArray();
PrintArray(arr);
(int negativeSum, int positiveSum) = GetSumsInArray(arr);
Console.WriteLine($" сумма положительных в массиве = {positiveSum}, сумма отрицательных = {negativeSum}");