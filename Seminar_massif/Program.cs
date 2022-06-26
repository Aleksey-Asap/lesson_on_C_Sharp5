// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// int[] massif = new int[12];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = new Random().Next(-9, 10);
// }

// for (int i = 0; i < massif.Length; i++)
// {
//     Console.Write(massif[i] + " ");
// }
// Console.WriteLine();

// int sumPos = 0;
// int sumNeg = 0;

// for (int i = 0; i < massif.Length; i++)
// {
//     if (massif[i] > 0)
//     {
//         sumPos += massif[i];
//     }
//     else
//     {
//         sumNeg += massif[i];
//     }
// }

// Console.WriteLine("Положительные: " + sumPos);
// Console.WriteLine("Отрицательные: " + sumNeg);


// Способ 2
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.
//
// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(); 
// }
// int[] massif = new int[12];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = new Random().Next(-9, 10);
// }
// Print(massif);

// int sumPos = 0;
// int sumNeg = 0;

// for (int i = 0; i < massif.Length; i++)
// {
//     if (massif[i] > 0)
//     {
//         sumPos += massif[i];
//     }
//     else
//     {
//         sumNeg += massif[i];
//     }
// }

// Console.WriteLine("Положительные: " + sumPos);
// Console.WriteLine("Отрицательные: " + sumNeg);





// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(); 
// }
// int[] massif = new int[12];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = new Random().Next(-9, 10);
// }
// Print(massif);

// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] *= -1;
// }

// Print(massif);


// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(); 
// }
// int[] massif = new int[8];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = new Random().Next(0, 10);
// }
// Print(massif);

// bool exist = false;

// Console.WriteLine("Введите число:");
// int A = int.Parse(Console.ReadLine());

// for (int i = 0; i < massif.Length; i++)
// {
//     if (massif[i] == A)
//     {
//         exist = true;
//         break;
//     }
// }
// if (exist == true) Console.WriteLine("Элемент найден");
// else Console.WriteLine("Элемент не найден");




// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 
// 123 [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5

// // void Print(int[] arr)
// // {
// //     for (int i = 0; i < arr.Length; i++)
// //     {
// //         Console.Write(arr[i] + " ");
// //     }
// //     Console.WriteLine(); 
// // }

// int[] massif = new int[123];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = new Random().Next(0, 200);
// }

// // Print(massif);

// int count = 0;

// for (int i = 0; i < massif.Length; i++)
// {
//     if (massif[i] >= 10 & massif[i] <= 99) count++;
// }

// Console.WriteLine($" Число эллементов массива, входящих в отрезок (10,99): {count}");



// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21

// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(); 
// }

// int[] massif = new int[9];
// for (int i = 0; i < massif.Length; i++)
// {
//     massif[i] = new Random().Next(0, 10);
// }

// Print(massif);

// int [] mass = new int[(1 + massif.Length) /2];

// for (int i = 0; i < mass.Length; i++)
// {
//     mass[i]= massif[i] * massif[massif.Length - i- 1];
// }

// if (massif.Length % 2 == 1) mass[mass.Length -1] = massif[massif.Length / 2];
// Print(mass);