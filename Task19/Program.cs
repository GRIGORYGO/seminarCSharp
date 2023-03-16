/* Задача 30: Напишите программу, 
которая выводит массив из 8 элементов, заполненный[1,0,1,1,0,1,0,1]
*/

int [] array = new int [8];
Random rnd = new Random();
int n = array.Length;

for (int i = 0; i < array.Length; i++)
{
  array[i]=rnd.Next(0,2);
  Console.WriteLine($"{array [i]}, ");
}

