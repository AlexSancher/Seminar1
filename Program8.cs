// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArrayTwo(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowArrayOne(int[] array)
// {
//     // Console.WriteLine();
//     // for (int i = 0; i < array.Length; i++)
//     // {
//     //     Console.Write(array[i] + " ");
//     // }
//     // Console.WriteLine();
//     Console.WriteLine(String.Join(" ", array));
// }

// int[] GetOneArray(int[,] arrayTwo)
// {
//     int[] arrayOne = new int[arrayTwo.GetLength(0) * arrayTwo.GetLength(1)];
//     int index = 0;

//     for (int i = 0; i < arrayTwo.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayTwo.GetLength(1); j++)
//         {
//             arrayOne[index] = arrayTwo[i, j];
//             index++;
//         }
//     }
//     return arrayOne;
// }

// void SortArray(int[] array)
// {
//     int buf = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[i] > array[j])
//             {
//                 buf = array[i];
//                 array[i] = array[j];
//                 array[j] = buf;
//             }
//         }
//     }
// }

// void PrintCounElement(int[] array)
// {
//     int count = 1;
//     int temp = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] != temp)
//         {
//             Console.WriteLine($"{temp} встречается {count} раз");
//             temp = array[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"{temp} встречается {count} раз");
// }

// Console.Clear();

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = CreateRandomArray(rows, columns, min, max);

// ShowArrayTwo(myArray);
// int[] arrayOne = GetOneArray(myArray);
// Console.WriteLine(String.Join(" ", arrayOne));
// SortArray(arrayOne);
// Console.WriteLine(String.Join(" ", arrayOne));
// PrintCounElement(arrayOne);





// ДЗ====================================================================


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Console.Clear();
// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }

// int[,] SortRowAscending(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int minPosition = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, minPosition]) minPosition = k;
//             }
//             int tmp = array[i, j];
//             array[i, j] = array[i, minPosition];
//             array[i, minPosition] = tmp;
//         }

//     }
//     return array;
// }

// void PrintTable(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 4;
// int col = 7;
// int min = 10;
// int max = 100;

// int[,] table = GetMatrix(row, col, min, max);
// PrintTable(table);

// System.Console.WriteLine();
// int[,] rowSort = SortRowAscending(table);
// PrintTable(rowSort);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] GetMatrix(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// int rowNumber(int[,] array)
// {
//     int index = 0;
//     int sum = 0;
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (i == 0) result = sum;
//         else if (sum < result)
//         {
//             result = sum;
//             index = i;
//         }
//     }
//     return index;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 5;
// int col = 8;
// int min = 1;
// int max = 10;

// int[,] matrix = GetMatrix(row, col, min, max);
// PrintMatrix(matrix);
// System.Console.WriteLine("---");
// int index = rowNumber(matrix);
// System.Console.WriteLine(index);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// int[,] CreateMatrix(int row, int col, int min, int max)
// {
//     int[,] matrix = new int[row, col];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }

// int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             product[i, j] = matrix1[i, j] * matrix2[i, j];
//         }
//     }
//     return product;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 3;
// int col = 5;

// int[,] matrix1 = CreateMatrix(row, col, 1, 10);
// int[,] matrix2 = CreateMatrix(row, col, 10, 20);
// int[,] product = MultiplyMatrix(matrix1, matrix2);
// PrintMatrix(matrix1);
// System.Console.WriteLine("---");
// PrintMatrix(matrix2);
// System.Console.WriteLine("---");
// PrintMatrix(product);



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// int[,,] CreateArray3D(int x, int y, int z)
// {
//     int[,,] array3D = new int[x, y, z];
//     int elem = 10;

//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         elem += i;
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             elem += j;
//             for (int q = 0; q < array3D.GetLength(2); q++)
//             {
//                 elem += q;
//                 array3D[i, j, q] = elem;
//             }
//         }
//     }
//     return array3D;
// }

// void PrintArray3D(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int q = 0; q < array.GetLength(2); q++)
//             {
//                 Console.Write($"({i},{j},{q}):- {array[i, j, q]} ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }


// int[,,] triD = CreateArray3D(3, 3, 3);
// PrintArray3D(triD);


// Задача 62: Заполните спирально массив 4 на 4.



// Console.WriteLine("Введите размер массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[n, n];
// int number = 1;
// for (int i = 0; i < n; i++)
// {
//     for (int j = i; j < n - i; j++) array[i, j] = number++;
//     for (int k = i + 1; k < n - i; k++) array[k, n - 1 - i] = number++;
//     for (int j = n - 2 - i; j >= i; j--) array[n - 1 - i, j] = number++;
//     for (int k = n - 2 - i; k > i; k--) array[k, i] = number++;
// }
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }