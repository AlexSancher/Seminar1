// void SnowNumber(){
//     int num = new Random().Next(10, 100);
//     int firstNum = num / 10;
//     int secondNum = num % 10;
//     Console.WriteLine(num + "->");
//     if (firstNum > secondNum){
//         Console.WriteLine(firstNum);
//     }
//     else{
//         Console.WriteLine(secondNum);
//     }
// }
// SnowNumber();




// int NumberWithoutSecDig(int Number){
//     int NewNumber = 0;
//     NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
// }
// int Number = new Random().Next(100, 1000);
// int a  = NumberWithoutSecDig(Number);
// Console.WriteLine(a + " " + Number);




// void MultiNum(int a, int b){
//     if(b%a ==0){
//         Console.WriteLine(b + " кратно " + a);
//     }else{
//         Console.WriteLine(b + " не кратно " + a + ", остаток " + b%a);
//     }
// }

// Console.Write("Введите последовательно два числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// MultiNum(num1, num2);


// дз

// 1

// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывают вторую цифру этого  числа. 

// Console.Clear();
// System.Console.WriteLine();
// int number = new Random().Next(100, 1000);

// System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

// System.Console.WriteLine();




// 2

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет


// Console.Clear();
// System.Console.WriteLine();

// int Number = new Random().Next(1, 1400);
// System.Console.WriteLine();
// System.Console.WriteLine($"Дано число: {Number}");
// while(Number > 999){Number/= 10;}
// if (Number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number% 10}");
// else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

// System.Console.WriteLine();



// 3



// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным


// Console.Clear();
// System.Console.WriteLine();

// int dayNumber = new Random().Next(1, 8);
// string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
// string txtResult = "";

// if (dayNumber > 5) txtResult = $". Ура! Это выходной день!";
// else txtResult = $", рабочий день.";

// System.Console.WriteLine();
// System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
// System.Console.WriteLine();
