// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
// int[] Array = GetArray(5, 100, 1000);
// Console.WriteLine(String.Join(" ", Array));

// int count = 0;

// for (int i = 0; i < Array.Length; i++)
// {
//     if (Array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Кол-во чётных чисел в массиве: {count}");

// int[] GetArray(int size, int MinValue, int MaxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(MinValue, MaxValue + 1);
//     }
//     return res;
// }

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] Array = GetArray(7, 0, 10);
// Console.WriteLine(String.Join(" ", Array));

// int sum = 0;

// for (int i = 0; i < Array.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         sum += Array[i];
//     }
// }
// Console.WriteLine($"Сумма элементов массива на нечетных позициях: {sum}");

// int[] GetArray(int size, int MinValue, int MaxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(MinValue, MaxValue + 1);
//     }
//     return res;
// }

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76

// int[] Array = GetArray(7, 1, 25);
// Console.WriteLine(String.Join(" ", Array));
// int i = 0;
// int max = Array[i];
// int min = Array[i];
// for (i = 0; i < Array.Length; i++)
// {
//     if (Array[i] > max)
//     {
//         max = Array[i];
//     }
//     if (Array[i] < min)
//     {
//         min = Array[i];
//     }
// }
// int dif=max-(min);
// Console.WriteLine($"Разница между {max} и {min}: {dif}");

// int[] GetArray(int size, int MinValue, int MaxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(MinValue, MaxValue + 1);
//     }
//     return res;
// }