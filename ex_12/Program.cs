Console.WriteLine("Input first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2){
    int result = number1 % number2;

    if (result == 0) {
        Console.WriteLine("Кратно");
    }
    else Console.WriteLine($"Некратно, {result}");
}

else {
    int result = number2 % number1;
    if (result == 0) {
        Console.WriteLine("Кратно");
    }
    else Console.WriteLine($"Некратно, {result}");
}