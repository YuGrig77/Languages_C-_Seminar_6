// Задача 45: Напишите программу, которая будет 
// создавать копию заданного массива с помощью поэлементного 
// копирования.
// 20

Console.Clear();

int [] CreateArray()
{
    int N = new Random().Next(0,10);
    int[] arr = new int[N];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,101);
}
return arr;
}

int [] CreateCopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    copyArr[i] = arr[i];
}
return copyArr;
}

void PrintArray (int [] array)
{ 
    Console.WriteLine();
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
}

int [] array = CreateArray();
PrintArray(array);

int [] copyArray = CreateCopyArray(array);
PrintArray(copyArray);



// ++ OR ++

// Console.Clear();
// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));
// int[] copyArray = CopyArray(array);
// Console.WriteLine(String.Join(" ", copyArray));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }

// int[] CopyArray(int[] inputArray)
// {
//     int len = inputArray.Length;
//     int[] copyArray = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         copyArray[i] = inputArray[i];
//     }
//     return copyArray;
// }

