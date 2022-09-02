using System;

int number = new Random().Next(100, 1000);    // number = число
Console.WriteLine(number);

int digit1 = number / 100;   // digit = цифра
int digit3 = (number % 10);

Console.Write(digit1);
Console.Write(digit3);
// Console.Write($"{number / 100}{number % 10}");