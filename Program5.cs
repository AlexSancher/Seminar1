// int number = 23;
// string result = string.Format("{0:f}" , number);

// Console.WriteLine(result);

// double number2 = 45.08;
// string result2 = string.Format("{0:f}" , number2);
// Console.WriteLine(result2);


string name = "Имя";
int age = 99;

Console.WriteLine($"Имя: {name, -10} Возраст: {age}");  // пробелы после
Console.WriteLine($"Имя: {name, 15} Возраст: {age}");  // пробелы до