﻿/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int[,] InitMatrix()
{
    int[,] result = new int[4, 4];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(1, 10);
        }

    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j= 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix [i,j]} ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}
    
 
 int[,] result = InitMatrix();
PrintMatrix(result);

int min = result [0,0];
int rowmin = 0;
int columnmin = 0;
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        if (min > result [i,j])
        {
            min = result [i,j];
            rowmin=i;
            columnmin=j;
        }
        
    }
    
}
for (int i = 0; i < result.GetLength(0); i++)

{
    if (i == rowmin)
    {
        continue;
    }
    for (int j = 0; j < result.GetLength(1); j++)
    {
      if (j==columnmin)
      {
        continue;
      }
      Console.Write($"{result[i,j]} ");
}
Console.WriteLine();
    }
    