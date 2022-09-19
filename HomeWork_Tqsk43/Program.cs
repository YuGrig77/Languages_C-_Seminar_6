// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Pls enter coefficients of {i + 1} equation (y = k * x + b):\n");
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Enter k: "); // k1 = coeff[0, 0], k2 = coeff[0, 1]
            else Console.Write($"Enter b: "); // b1 = coeff[0, 1], b2 = coeff[1, 1]
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Solution(double[,] coeff)
{
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]); // find x
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1]; // find y
    return crossPoint;
}

void PrintResults(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.Write($"\nStraight lines are combined");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.Write($"\nStraight lines are parallel");
    }
    else
    {
        Solution(coeff);
        Console.Write($"\nk1 = {coeff[0, 0]}, b1 = {coeff[0, 1]}, "+
         $"k2 = {coeff[1, 0]}, b2 = {coeff[1, 1]} -> "+
         $" cross point coordinates ({crossPoint[0]}; {crossPoint[1]})");
    }
}

InputCoefficients();
PrintResults(coeff);


