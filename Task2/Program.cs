// // Задача 40: Напишите программу, которая принимает на 
// вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.


Console.Beep();
Console.Clear();
Console.Write($"Введите стороны a, b, c:");
string strNumber = Console.ReadLine();
string[] points = strNumber.Split(',');
int[] intP = new int[3];
int count = 0;

foreach (string el in points)
{
    intP[count] = int.Parse(el);
    count++;
}

if (Proverka(intP)) Console.WriteLine("Треугольник может существовать");
else Console.WriteLine("Треугольник НЕ может существовать");

bool Proverka(int[] intPoints)
{
    bool result = false;
    if (intPoints[0] < intPoints[1] + intPoints[2] && intPoints[1] < intPoints[2] + intPoints[0] && intPoints[2] < intPoints[0] + intPoints[1])
    {
        result = true;
    }
    return result;
}

//++ OR ++

// char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };

// double[] triangleSides = new double[3];
// bool[] checkStrings = new bool[3];

// do
// {
//     Console.WriteLine("Введите три числа: ");
//     string[] threeNumbers = Console.ReadLine().Split(delimiterChar);
//     //Console.WriteLine(", ");
//     if (threeNumbers.Length < 3) { continue; };
//     checkStrings[0] = double.TryParse(threeNumbers[0], out triangleSides[0]);
//     checkStrings[1] = double.TryParse(threeNumbers[1], out triangleSides[1]);
//     checkStrings[2] = double.TryParse(threeNumbers[2], out triangleSides[2]);
// }
// while (!checkStrings[0] || !checkStrings[1] || !checkStrings[2]);

// Console.Write(CheckTriangle(triangleSides)? $"может существовать ": $"не может существовать");

// bool CheckTriangle(double[] triangleArray)
// {
//     double a = triangleArray[0];
//     double b = triangleArray[1];
//     double c = triangleArray[2];

//     if (a < b + c && b < a + c && c < a + b)
//     { return true; }
//     else
//     { return false; }
// }




