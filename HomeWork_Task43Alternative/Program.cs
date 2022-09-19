// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Pls enter coefficient k1: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter coefficient b1: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter coefficient k2: ");
double c = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter coefficient b2: ");
double d = Convert.ToInt32(Console.ReadLine());

void PrintResults()
{
    if (a == c && b == d)
    {
        Console.Write($"\nStraight lines are combined");
    }
    else if (a == c && b != d)
    {
        Console.Write($"\nStraight lines are parallel");
    }
    else
    {
        double x = (d - b) / (a - c);
        double y = x * c + d;
        Console.Write($"\nk1 = {a}, b1 = {b}, " +
         $"k2 = {c}, b2 = {d} -> " +
         $" cross point coordinates ({x}; {y})");
    }
}

PrintResults();
