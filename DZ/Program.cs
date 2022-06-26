// Домашнее задание:
// ЗаданиеПример Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] massif = new int[7];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = new Random().Next(100, 999);
// }

// Print(massif);

// int count = 0;
// int CountEven(int[] collection)
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         if (collection[i] % 2 == 0) count++;
//     }
//     return count;
// }

// CountEven(massif);
// Console.WriteLine($"Количество четных чисел в массиеве: {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0

// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] massif = new int[5];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = new Random().Next(0, 10);
// }

// Print(massif);

// int sum = 0;
// int SumUnEvenPos(int[] collection)
// {
//     for (int i = 1; i < collection.Length; i+= 2)
//     {
//         sum += collection[i];
//     }
//     return sum;
// }

// SumUnEvenPos(massif);
// Console.WriteLine($"Количество четных чисел в массиеве: {sum}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// void Print(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }

// double[] massif = new double[5];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = Math.Round(new Random().NextDouble(), 1);
// }

// Print(massif);

// double max = 0;
// double min = 1;

// for (int i = 0; i < massif.Length; i++)
// {
//     if (massif[i] > max) max = massif[i];
//     if (massif[i] < min) min = massif[i];
// }
// Console.WriteLine($"Max: {max}  Min: {min}");
// Console.WriteLine("Разница между Max и Min:" + " " + (max - min));