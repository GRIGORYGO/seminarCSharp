/*
/*залача 46: запаите двумерный массив размером mxn. 
заполненный случаиными целыми числами.
m = 3; n = 4;
*/
int[,] InitMatrix()
{
    int[,] result = new int[3, 4];
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

}
    
 
 int[,] result = InitMatrix();
PrintMatrix(result);