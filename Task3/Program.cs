// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Convert(10);

int Convert(int Number)
{
    int temp = 0;
    if (Number > 0)
    {
        temp = Number % 2;
        Number = Number / 2;
        //Console.Write($"{Number} ");
        Number = Convert(Number);
        Console.Write($"{temp}");
    }
    return Number;
}

// ++OR++

// Console.Clear();
// Console.WriteLine("Введите число:");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число:");
// int b = int.Parse(Console.ReadLine());


// static void Main(int num10, int hoh)
// {
//         int num2it = 0; // num2it - остаток после % деления из которого формируется число в 
//                      //    двоичной системе исчисления
//         int i = 0;
 
//         int[] array = new int[hoh]; // массив с помощью которого двоичное число позже 
//                                  //будет выведено с конца для правильного отображения 
 
//         while (num10 >= 1)
//         {
//             num2it = num10 % 2;
//             array[i] = num2it;
//             i++;
 
//             num10 = num10 / 2;
 
//             Console.Write(num2it);
//         };
 
//         Console.WriteLine();
 
//         for (i = (array.Length - 1); i >= 0; i--)
//         {
//             Console.Write($"{array[i]} ");
//         }
 
//         Console.WriteLine();
// }

// Main(a, b);
