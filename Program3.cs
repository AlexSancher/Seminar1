// void getDot (int x, int y){
//     if (x== 0 || y == 0){
//         Console.WriteLine("Нет возможности определить четверть");
//     }else{
//         if(x > 0 && y > 0)
//           Console.WriteLine("1 четверть");
//         if(x > 0 && y < 0)
//           Console.WriteLine("4 четверть");
//         if(x < 0 && y > 0)
//           Console.WriteLine("2 четверть");
//         if(x < 0 && y < 0)
//           Console.WriteLine("3 четверть");
//     }
// }

// Console.WriteLine("Введите две точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());

// getDot (x1, y1);




// Console.Clear();
// double distAB(int x1, int y1, int x2, int y2){
//     return Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2));
// }

// Console.WriteLine("Введите координат X1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координат Y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координат X2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координат Y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Длина отрезка: " + distAB(xA, yA, xB, yB));




// Console.Clear();
// void listSqrt(int n){
//     int count  = 1;
//     Console.Write(n + " -> ");
//     if(n > 0){
//         while(count <=n){
//             Console.Write(Math.Pow(count, 2) +", ");
//             count++;
//         }
//     }else{
//         count = -1;
//         while(count >=n){
//             Console.Write(Math.Pow(count, 2)+", ");
//             count--;
//         }
//     }
// }
//     Console.WriteLine("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     listSqrt(num);




// ДЗ


// №19

// ============================================================================================================================

// Console.Clear();
// System.Console.WriteLine();

// System.Console.Write("Введите целое число:   ");
// string number = Console.ReadLine();
// int length = number.Length;
// string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

// bool IsPalindrome()
// {
//     for (int i = 0; i < length / 2; i++)
//         while (number[i] == number[length - 1])
//         {
//             return true;
//         }
//     return false;
// }

// System.Console.WriteLine("Ответ при решении первым способом:");
// if (IsPalindrome()) System.Console.WriteLine($"1. Введный текст/число - {number} - является палиндромом");
// else System.Console.WriteLine($"1. Число {number} не является палиндромом");
// System.Console.WriteLine();


// №23
// ---------------------------------------------------------------------------------------------------------------------------

// 24. Найти кубы чисел от 1 до N

// Console.Clear();
// System.Console.WriteLine();

// System.Console.Write("Введите число:   ");
// string writeN = Console.ReadLine();
// int N = Convert.ToInt32(writeN);


// int[] GetCubeTable(int N)
// {
//     int[] cubs = new int[N];
//     int number = 1;
//     for (int i = 0; i < N; i++)
//     {
//         cubs[i] = number * number * number;
//         number++;
//     }
//     return cubs;
// }

// void PrintCubs(int[] array)
// {
//     int number = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{number} ^ 3 = ");
//         System.Console.WriteLine(array[i]);
//         number++;
//     }
// }

// int[] CubeTable = GetCubeTable(N);
// PrintCubs(CubeTable);



// №21

// ------------------------------------------------------------------------------------------------------------------------

Console.Clear();
System.Console.WriteLine();

int numPlan = 3;            // количество осей координат
int min = -5;               // минимальное значение диапазона для выбора случайных чисел
int max = 6;                // максимальное значение диапазона ...

int[] PointCoords(int numPlan)                  
{
    int[] coords = new int[numPlan];
    for (int i = 0; i < numPlan; i++)
    {
        coords[i] = new Random().Next(min, max);
    }
    return coords;
}

void PrintCoords(int[] array)
{
    System.Console.Write($"({array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]})");
}

double Distance(int[] arr1, int[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}

int[] PointA = PointCoords(numPlan);
int[] PointB = PointCoords(numPlan);

System.Console.Write($"Координаты точки А: ");
PrintCoords(PointA);
System.Console.Write($"Координаты точки B: ");
PrintCoords(PointB);

System.Console.WriteLine($"Расстояние между точками А и В: {Distance(PointA, PointB)}");
System.Console.WriteLine();
