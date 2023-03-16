/*
Задача 53: Задайте двумерный массив.
 Напишите программу, которая поменяет местами первую 
 и последнюю строку массива.
 */

 int [,] InitMatrix ()
 {
    int [,] result = new int [4,4];
    Random rnd = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = rnd.Next(1,10);
        }
    }
    return result;
 }
 void PrintMatrix (int [,] matr)
 {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int J = 0; J < matr.GetLength(1); J++)
        {
           Console.Write($"{matr[i,J]} ") ;
        }
        Console.WriteLine();
    }

 }
 
 void GetMatrix (int [,] matr)
 {
        
        int ten =0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           ten = matr [0,j];
           matr[0, j] = matr[matr.GetLength(0)-1,j];
           matr[matr.GetLength(0)-1,j] = ten;
        }
    }

    int[,] Matrix = InitMatrix();
    PrintMatrix(Matrix);
    GetMatrix(Matrix);
    Console.WriteLine();
    PrintMatrix(Matrix);
