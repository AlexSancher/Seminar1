// 1 Напишите программу, которая на вход принимает число и выдает его квадрат ( число умноженное само на себя)
// Console.WriteLine ( "input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is " + result);


// 2 Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// Console.WriteLine ( "input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ( "input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int square = num2 * num2;

// if (num1 == square){
//       Console.WriteLine ( "first number is a square of second number");
// }
// else{
//       Console.WriteLine ( "first number is not a square of second number");    
// }


// 3 Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Console.Write( "input number of a day: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 1 || day > 7){
//   Console.Write("incorrect day"); 
// }
// else {
//     if (day == 1){
//         Console.WriteLine("Monday");
//     }
//     if (day == 2){
//          Console.WriteLine("Tuesday");
//     }
//     if (day == 3){
//         Console.WriteLine("Wednesday");
//     }
//     if (day == 4){
//         Console.WriteLine("Thursday");
//     }
//     if (day == 5){
//         Console.WriteLine("Friday");
//     } 
//     if (day == 6){
//         Console.WriteLine("Saturday");
//     } 
//     if (day == 7){
//         Console.WriteLine("Sunday");
//     }
// }


// 4  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num < 0){
//    current = num;
//    num = num * (-1);
// }
// else{
//     current = -1 * num;
// }

//     while (current <= num){
//     Console.Write(current + " ");
//     current++;
// }


// 5  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(num % 10);





// Домашка СЕМИНАР 1




// 2 Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// System.Console.WriteLine();

// string[] txtNumber = { "первое", "второе" };
// int[] number = new int[2];

// for (int i = 0; i < 2; i++)
// {
//     System.Console.WriteLine($"Введите {txtNumber[i]} число:");
//     string writeNumber = Console.ReadLine();
//     number[i] = Convert.ToInt32(writeNumber);
// }
// int max = number.Max();
// int min = number.Min();

// if (max == min) System.Console.WriteLine("Введённые числа равны");
// else 
// {
//     System.Console.WriteLine($"Большее число {max}, меньшее число {min}");
// }
// System.Console.WriteLine();


// 4 Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

//int[] Numbers = { 44, 5, 78 };

//for (int i = 0; i < 3; i++)
// {
//    int max = Numbers[0];
    
//   if (Numbers[i] > max)
//    {
//         max = Numbers[i];
//         System.Console.WriteLine();
//        System.Console.WriteLine($"Максимальное число {max}");
//     }
// }
// System.Console.WriteLine();


// 6 Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Clear();
// System.Console.WriteLine();
// System.Console.Write("Введите число: ");
// string writeNumber = Console.ReadLine();
// int number = Convert.ToInt32(writeNumber);
// string result = $"Число {number} является чётным";

// if (number % 2 != 0) result = result.Replace("является", "не является");

// System.Console.WriteLine(result);
// System.Console.WriteLine();

// 8 Программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Clear();

// System.Console.Write("Введите число:   ");
// string txtN = Console.ReadLine();
// int endNum = Convert.ToInt32(txtN);
// int num = 0;
// System.Console.WriteLine($"Чётные числа из диапазона от 1 до {endNum}:");
// while (num < endNum)
// {
//     num++;
//     if (num % 2 == 0) System.Console.Write($"{num} ");
// }
// System.Console.WriteLine(); System.Console.WriteLine();