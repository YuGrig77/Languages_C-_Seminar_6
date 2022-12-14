// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Pls enter coefficient k1: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Pls enter coefficient b1: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Pls enter coefficient k2: ");
double c = double.Parse(Console.ReadLine());
Console.Write("Pls enter coefficient b2: ");
double d = double.Parse(Console.ReadLine());

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
        double x = Math.Round((d - b) / (a - c), 2);
        double y = Math.Round((x * c + d), 2);
        Console.Write($"\nk1 = {a}, b1 = {b}, " +
         $"k2 = {c}, b2 = {d} -> " +
         $" cross point coordinates ({x}; {y})");
    }
}

PrintResults();
