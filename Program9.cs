
// ДЗ


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Clear();
// Console.WriteLine("");
// Console.WriteLine();
// int numberM = EnterUserData("Enter the start number M:");
// int numberN = EnterUserData("Enter the end number N:");
// int temp = 0;
// if (numberM > numberN)
// {
//     temp = numberM;
//     numberM = numberN;
//     numberN = temp;
// }
// Console.WriteLine();
// Console.Write($"Sum of all numbers from {numberM} to {numberN} = {SumFunction(numberM, numberN)}");
// Console.WriteLine();

// int SumFunction(int startValue, int endValue)
// {
//     if (startValue == endValue)
//     {
//         return startValue;
//     }
//     return SumFunction(startValue, endValue - 1) + endValue;
// }

// int EnterUserData(string nameUserData)
// {
//     Console.Write($"{nameUserData}");
//     return Convert.ToInt32(Console.ReadLine());
// }




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 



// Console.Clear();
// Console.WriteLine("This program solves Ackermann's function.");
// Console.WriteLine();
// int numberM = EnterUserData("Enter the start number M:");
// int numberN = EnterUserData("Enter the end number N:");
// if (numberM < 0 || numberN < 0)
// {
//     Console.WriteLine("Please enter positive numbers m and n.");
//     return;
// }
// int result = AckermannFunction(numberM, numberN);
// Console.WriteLine(result);

// int AckermannFunction(int numberM, int numberN)
// {
//     if (numberM == 0)
//     {
//         return numberN + 1;
//     }
//     else if (numberM > 0 && numberN == 0)
//     {
//         return AckermannFunction(numberM - 1, 1);
//     }
//     else if (numberM > 0 && numberN > 0)
//     {
//         return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
//     }
//     return AckermannFunction(numberM, numberN);
// }

// int EnterUserData(string nameUserData)
// {
//     Console.Write($"{nameUserData}");
//     return Convert.ToInt32(Console.ReadLine());
// }