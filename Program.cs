// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();

//         int[,] GetArray(int m, int n, int minValue, int maxValue)
//         {
//             int[,] result = new int[m, n];
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     result[i, j] = new Random().Next(minValue, maxValue + 1);
//                 }
//             }
//             return result;
//         }

//         void PrintArray(int[,] inArray)
//         {
//             for (int row = 0; row < inArray.GetLength(0); row++)
//             {
//                 for (int column = 0; column < inArray.GetLength(1); column++)
//                 {
//                     Console.Write($"{inArray[row, column]} " + "\t");
//                 }
//                 Console.WriteLine();
//             }
//         }

//         void SortArray(int[,] array)
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     for (int t = j + 1; t < array.GetLength(1); t++)
//                     {
//                         if (array[i,t] < array[i,j])
//                         {
//                             int temp = array[i,j];
//                             array[i,j] = array[i,t];
//                             array[i,t] = temp;
//                         }
//                     }
//                 }
//             }

//         }

//         Console.Write("Введите количество строк массива: ");
//         int rows = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите количество столбцов массива: ");
//         int columns = Convert.ToInt32(Console.ReadLine());
//         int[,] array = GetArray(rows, columns, 0, 9);
//         PrintArray(array);
//         SortArray(array);
//         Console.WriteLine();
//         PrintArray(array);
//     }
// }       



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        int[,] GetArray(int m, int n, int minValue, int maxValue)
        {
            int[,] result = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = new Random().Next(minValue, maxValue + 1);
                }
            }
            return result;
        }

        void PrintArray(int[,] inArray)
        {
            for (int row = 0; row < inArray.GetLength(0); row++)
            {
                for (int column = 0; column < inArray.GetLength(1); column++)
                {
                    Console.Write($"{inArray[row, column]} " + "\t");
                }
                Console.WriteLine();
            }
        }

        int GetRowNumber(int [,] array)
        {
            int row = 0;
            int minsum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                minsum = minsum + array[0,i];
            }

            for (int i = 1; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum = sum + array[i,j];
                }
                if (minsum > sum)
                {
                    minsum = sum;
                    row = i;
                }
            }
            return row;
        }

        Console.Write("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] array = GetArray(rows, columns, 0, 9);
        PrintArray(array);

        Console.WriteLine($"Индекс строки с наименьшей суммой: {GetRowNumber(array)}");
    }
}     