/*
Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы.
 В случае, если это невозможно, программа должна вывести 
 сообщение для пользователя.
 */
 int [,] InitMatrix ()
 {
    int [,] result = new int [2,4];
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
 
 int [,] GetNewMatrix (int[,]matr)
 {
    int [,] result = new int [matr.GetLength(1),matr.GetLength(0)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = matr[j,i];
        }
    
    }
    return result;
 }

 int [,]  Matrix = InitMatrix();
 PrintMatrix(Matrix);
 int[,] NewMatrix = GetNewMatrix (Matrix);
 Console.WriteLine();
 PrintMatrix(NewMatrix);