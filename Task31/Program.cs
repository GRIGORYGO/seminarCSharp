/*
Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");




string[,] table = new string[2, 5];
// String. Empty
// table[0,o] table[0,1] table [0,2]
// table[1,01 table[1,1] table [1,2]
/* 
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
   for (int  columen = 0; columen < 5; columen++)
   {
    Console.WriteLine($"{table [rows,columen]}--");
   } 
}*/

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
   } 
   Console.WriteLine();
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
