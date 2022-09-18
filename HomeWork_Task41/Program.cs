// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write($"Pls enter intended ammount of numbers: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];

void InputNumbers(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Pls enter {i + 1} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int FindHowManyPositive(int[] resFHMP)
{
    int count = 0;
    for (int i = 0; i < resFHMP.Length; i++)
    {
        if (resFHMP[i] > 0) count += 1;
    }
    return count;
}

void PrintArray(int[] resPA)
{
    for (int i = 0; i < resPA.Length; i++)
    {
        Console.Write((i == resPA.Length - 1 ? $"{resPA[i]} " : $"{resPA[i]}, "));
    }
}

InputNumbers(count);
Console.WriteLine();
PrintArray(array);
Console.WriteLine($"-> {FindHowManyPositive(array)}\n");


