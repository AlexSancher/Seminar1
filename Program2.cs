void SnowNumber(){
    int num = new Random().Next(10, 100);
    int firstNum = num / 10;
    int secondNum = num % 10;
    Console.WriteLine(num + "->");
    if (firstNum > secondNum){
        Console.WriteLine(firstNum);
    }
    else{
        Console.WriteLine(secondNum);
    }
}
SnowNumber();