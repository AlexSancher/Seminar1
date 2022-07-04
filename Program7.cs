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
// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// int SumNumber(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i, j];
//             }
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);
// Console.WriteLine(SumNumber(myArray));





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

// void ShowArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0 && i !=0 && j != 0)
//                 Console.Write($" |{array[i, j]}| ");
//                 else
//                     Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();    
// }

// void EvenArray(int[,] array)
// {

//     for (int i = 2; i < array.GetLength(0); i++)
//     {
//         for (int j = 2; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 array[i, j] *= array[i, j];
//         }
//     }

// }

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max number: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = CreateRandomArray(rows, columns, min, max);

// ShowArray(myArray);
// EvenArray(myArray);
// ShowArray(myArray);





// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = i+j;
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
    
// }

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());



// int[,] myArray = CreateArray(rows, columns);

// ShowArray(myArray);





// ДЗ===========================================================================


// №47

// Console.Clear();
// System.Console.WriteLine();

// double[,] GetTableDouble(int m, int n)
// {
//     double[,] table = new double[m, n];
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = new Random().NextDouble() * 100;
//         }
//     }
//     return table;
// }

// void PrintTable(double[,] tab)
// {
//     for (int i = 0; i < tab.GetLength(0); i++)
//     {
//         for (int j = 0; j < tab.GetLength(1); j++)
//         {
//             System.Console.Write(tab[i, j] + "    ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int m = 8;
// int n = 4;
// double[,] TableDouble = GetTableDouble(m, n);
// PrintTable(TableDouble);



// #50



// Console.Clear();
// System.Console.WriteLine();

// int[,] CreateArray(int row, int col, int min, int max)
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

// int[] FindNumberPosition(int[,] arr, int number)
// {
//     int[] position = new int[2];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] == number)
//             {
//                 position[0] = i + 1;
//                 position[1] = j + 1;
//                 return position;
//             }
//         }
//     }
//     position[0] = -1;
//     position[1] = -1;
//     return position;
// }

// void PrintArray(int[,] array)
// {
//     System.Console.WriteLine("Массив:");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 1000 > 0) System.Console.Write($"{array[i, j]}   ");
//             else if (array[i, j] / 100 > 0) System.Console.Write($" {array[i, j]}   ");
//             else if (array[i, j] / 10 > 0) System.Console.Write($"  {array[i, j]}   ");
//             else System.Console.Write($"   {array[i, j]}   ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void PrintPosition(int[] pos, int num)
// {
//     System.Console.WriteLine();
//     if (pos[0] > 0 && pos[1] > 0) System.Console.WriteLine($"Число {num} находится в {pos[0]}-й строке, {pos[1]}-м столбце");
//     else System.Console.WriteLine($"Число {num} отсутствует в заданном массиве");
//     System.Console.WriteLine();
// }

// int GetNumerToFind()
// {
//     System.Console.WriteLine();
//     System.Console.Write("Введите число:   ");
//     string writeNumber = Console.ReadLine();
//     int number = Convert.ToInt32(writeNumber);
//     return number;
// }

// int row = 7;
// int col = 10;
// int min = 1;
// int max = 1000;

// int[,] array1 = CreateArray(row, col, min, max);
// PrintArray(array1);
// int number = GetNumerToFind();
// int[] position = FindNumberPosition(array1, number);
// PrintPosition(position, number);




// #52

Console.Clear();

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 10) System.Console.Write($" {array[i, j]}  ");
            else System.Console.Write($"  {array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

double[] GetArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("------------------------");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}

int row = 7;
int col = 5;
int min = 1;
int max = 10;

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
double[] arithmeticMean = GetArithmeticMean(matrix);
PrintArray(arithmeticMean);
System.Console.WriteLine();
System.Console.WriteLine();
