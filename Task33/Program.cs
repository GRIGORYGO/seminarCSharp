/*
/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int[,] InitMatrix()
{
    int[,] array = new int[4,4];
    
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }

    return array;
}


void GetNewMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 != 0 && j %2 != 0)
            {
                matr[i,j] =  matr[i,j]* matr[i,j];
            }
        }
    }
    
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
GetNewMatrix (matrix);
Console.WriteLine();
PrintMatrix(matrix);