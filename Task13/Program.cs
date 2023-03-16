/*
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7, -5); B (1, -1) -> 7,21
*/
int GetNumber (string massege)
{
    int result = 0;
    while (true)
    {
         Console.WriteLine(massege);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
                Console.WriteLine("Ввели не число, попробуйте еще раз");
        }


    }

    return result;

}

double GetDistance (int x1, int y1, int x2, int y2)
{
double dist = Math.Sqrt (Math. Pow((x1-x2),2) 
+Math. Pow ((y1-y2), 2));
return dist;
}

int x1 = GetNumber ("Введите значение x1"); 
int y1 = GetNumber ("Введите значение у1"); 
int x2 = GetNumber ("Введите значение x2"); 
int y2 = GetNumber ("Введите значение у2");

double distance = GetDistance(x1, y1, x2, y2);
Console.WriteLine ($"расстояние между ними в 20 пространстве {distance:0.##}");