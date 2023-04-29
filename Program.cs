// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double [,] GetArray(int num, int column)
// {
//     double [,] arr = new double[num,column];
//     return arr;
// }

// double GetRandom()
// {
//     return Math.Round(new Random().NextDouble(), 1) + new Random().Next(-10, 11);
// }

// double [,] FillArray(double [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = GetRandom();
//         }
        
//     }
//     return arr;
// }

// void PrintArray(double [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i,j] + "    ");
//         }
//     Console.WriteLine(); 
//     }   
// }

// double [,] array = GetArray(3, 4);
// FillArray(array);
// PrintArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[] GetNums()
{
    Console.WriteLine("Введите через запятую позицию элемента в духмерном массиве");
    int [] num =  Array.ConvertAll<string,int>(Console.ReadLine().Split(','), 
    elem => { return Convert.ToInt32 (elem);});
    return num;
}

string FindNum(int[,] arr, int [] num)
{
    if (num[0] < arr.GetLength(0) && num[1] < arr.GetLength(1))
    {
        return Convert.ToString(arr[num[0], num[1]]);
    }
    else return "Такого элемента в массиве нет";      
}

int [,] array = {{1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4}};

Console.WriteLine(FindNum(array, GetNums()));


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] array = {{1,4,7,2},
//                  {5,9,2,3},
//                  {8,4,2,4}};
// double [] result = new double[array.GetLength(1)];

// for (int i = 0; i < array.GetLength(1); i++)
// {
//     double sum = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         sum += array[j,i];
//     }
//     result[i] = Math.Round(sum/array.GetLength(0), 1);
// }

// Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", result)}");
