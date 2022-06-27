// Программа принимает на вход число (А) и выдает сумму чисел от 1 до А

// int sumToNum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));


// Программа принимает на вход число и выдает количество цифр в числе


// int numbers = 5532;
// int count = 0;

// while(numbers > 0)
// {
//     numbers = numbers / 10;
//     count++;
// }
// Console.WriteLine(count);



// int countnumbers (int num){
//     int count = 0;
//     while(num > 0)

// {
//     num = num / 10;
//     count++;
// }

// return(count);
// }
// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(countnumbers(numbers));


// int miltiplayToNum(int num)
// {
//     int miltiplay = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         miltiplay *= i;
//     }
//     return miltiplay;
// }

// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(miltiplayToNum (numbers));

// Программа выводит в массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


// int [] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(0,2);
//     }
//     return array;
// }



// // создаем массив из чисел
// int [] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Input " + i + "element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// // выводим значение элементов массива в одну строку через пробел

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int [] myRandomArray = CreateRandomArray (8, 0, 1);
// ShowArray(myRandomArray);






// ДЗ----------------------------------------------------


// #25

// Console.Clear();
// System.Console.WriteLine();

// System.Console.Write("Введите число:   ");
// string writeA = Console.ReadLine();
// int A = Convert.ToInt32(writeA);
// int GetNumbersSum (int A);
// {
//     int number = 1;
//     int sum = 0;
//     for (int i = 0; i < A; i++)
//     {
//         sum = sum + number;
//         number++;
//     }
//     return sum;
// }

// int NumbersSum = GetNumbersSum(A);
// System.Console.WriteLine($"Сумма чисел от 1 до {A} составляет {NumbersSum}");


// Console.Clear();
// System.Console.WriteLine();

// int number = 2;
// int exponent = 10;
// int count = 1;
// int result = number;

// while (count < exponent)
// {
//     result = result * number;
//     count++;
// }

// System.Console.WriteLine($"{number} ^ {exponent} = {result}");
// System.Console.WriteLine();


// #27--------------------------------------------------------------------

// Console.Clear();
// System.Console.WriteLine();

// int number = new Random().Next(1, 100000);
// int sumDigit = 0;
// System.Console.Write($"Сумма цифр числа {number} равна ");

// while (number > 0)
// {
//     int digit = number % 10;
//     sumDigit = sumDigit + digit;
//     number = number / 10;
// }

// System.Console.WriteLine(sumDigit);
// System.Console.WriteLine();


// #29----------------------------------------------


// int N = 8;

// int[] SetArray(int x)
// {
//     int[] arr = new int[x];
//     for (int i = 0; i < x; i++)
//     {
//         arr[i] = new Random().Next(1, 100);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         System.Console.Write($"{array[i]} ");
// }

// PrintArray(SetArray(N));