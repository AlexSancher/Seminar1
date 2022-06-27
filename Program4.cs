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


int miltiplayToNum(int num)
{
    int miltiplay = 1;
    for (int i = 1; i <= num; i++)
    {
        miltiplay *= i;
    }
    return miltiplay;
}

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(miltiplayToNum (number));