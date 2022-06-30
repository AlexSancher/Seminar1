// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SwapArray(int[] array)
// {
//     int buf = 0;

//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         buf = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = buf;
//     }

//     ShowArray(array);
// }

// void SwapArray1(int[] array)
// {
//     int[] arr = new int[array.Length];

//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         arr[i] = array[j];
//     }

//     ShowArray(arr);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomArray(size);

// ShowArray(arr);

// Console.WriteLine();
// SwapArray(arr);
// SwapArray1(arr);



// ДЗ===========================================================

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Clear();
// System.Console.WriteLine();
// int volume = 10;                // количество ввода чисел
// int count = 0;

// while (volume > 0)
// {
//     System.Console.Write("Введите число:   ");
//     string num = Console.ReadLine();
//     int number = Convert.ToInt32(num);
//     if (number > 0) count++;
//     volume--;
// }

// System.Console.WriteLine($"Количество чисел больше 0: {count}");


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.Clear();
// System.Console.WriteLine();
// System.Console.Write("Введите число:   ");
// string writeNum = Console.ReadLine();
// int number = Convert.ToInt32(writeNum);

// int[] ConvertToBinary(int num)
// {
//     int num2 = num;
//     int size = 0;
//     while (num > 0)
//     {
//         num = num / 2;
//         size++;
//     }

//     int[] binary = new int[size];
//     for (int i = size - 1; i >= 0; i--)
//     {
//         binary[i] = num2 % 2;
//         num2 = num2 / 2;
//     }
//     return binary;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//     }
// }

// PrintArray(ConvertToBinary(number));


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Console.Clear();
// System.Console.WriteLine();

// int N = new Random().Next(1, 40);
// System.Console.WriteLine($"Количество чисел Фибоначчи: {N}");

// int[] GetFibonacci(int N)
// {
//     int prev1 = 1;
//     int prev2 = 1;
//     int[] fib = new int[N];
//     fib[0] = 1;
//     fib[1] = 1;
//     for (int i = 2; i < N; i++)
//     {
//         fib[i] = prev1 + prev2;
//         prev2 = prev1;
//         prev1 = fib[i];
//     }
//     return fib;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// PrintArray(GetFibonacci(N));
// System.Console.WriteLine();
