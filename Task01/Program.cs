// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите любое трехзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

int digit1 = digit/10;
int digit2 = digit1%10;
Console.WriteLine(digit2);
 
 

