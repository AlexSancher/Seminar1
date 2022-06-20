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




Console.Clear();
void listSqrt(int n){
    int count  = 1;
    Console.Write(n + " -> ");
    if(n > 0){
        while(count <=n){
            Console.Write(Math.Pow(count, 2) +", ");
            count++;
        }
    }else{
        count = -1;
        while(count >=n){
            Console.Write(Math.Pow(count, 2)+", ");
            count--;
        }
    }
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    listSqrt(num);
}