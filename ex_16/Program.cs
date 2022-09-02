Console.WriteLine("Input first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2){
    int result = number2 * number2;
    if (number1 == result) {
        Console.WriteLine("yes");
    }
    else Console.WriteLine("no");
}
else {
    int result = number1 * number1;
    if (number2 == result) {
        Console.WriteLine("yes");
    }
    else Console.WriteLine("no");
}