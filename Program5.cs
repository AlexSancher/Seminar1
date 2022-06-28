// int number = 23;
// string result = string.Format("{0:f}" , number);

// Console.WriteLine(result);

// double number2 = 45.08;
// string result2 = string.Format("{0:f}" , number2);
// Console.WriteLine(result2);


// string name = "Имя";
// int age = 99;

// Console.WriteLine($"Имя: {name, -10} Возраст: {age}");  // пробелы после
// Console.WriteLine($"Имя: {name, 15} Возраст: {age}");  // пробелы до




// int [] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }


// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i] > 0)
//     sum_pos += myArray[i];
//     else
//     sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");




// ДЗ=========================================================================

// №34

// Console.Clear();
// System.Console.WriteLine();

// int size = 20;

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintResult(int[] array)
// {
//     int even = 0;
//     int uneven = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//         if (array[i] % 2 == 0) even++;
//         else uneven++;
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
//     System.Console.WriteLine();
// }

// PrintResult(FillArray(size));




// №36

// Console.Clear();

// int size = 20;

// int[] FillArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     int sum = 0;
//     System.Console.WriteLine();
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//         if (i % 2 > 0) sum += arr[i];
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
//     System.Console.WriteLine();
// }

// PrintArray(FillArray(size));





// №38

// Console.Clear();
// System.Console.WriteLine();

// int size = new Random().Next(1, 11);

// System.Console.WriteLine($"Количество элементов массива: {size}");

// double[] FillSourceArray(int size)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().NextDouble() * 100;
//     }
//     return array;
// }

// void PrintDiffMinMax(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.WriteLine(arr[i]);
//     }
//     double difference = arr.Max() - arr.Min();
//     System.Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
//     System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
//     System.Console.WriteLine();
// }

// PrintDiffMinMax(FillSourceArray(size));
// System.Console.WriteLine();
