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


int numbers = 5532;
int count = 0;

while(numbers > 0)
{
    numbers = numbers / 10;
    count++;
}
Console.WriteLine(count);