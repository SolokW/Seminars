// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
int a = 456;
int b = 782;
int c = 918;

int result1 = a % 10;
int result2 = b % 10;
int result3 = c % 10;
Console.WriteLine($"{a} -> {result1}");
Console.WriteLine($"{b} -> {result2}");
Console.WriteLine($"{c} -> { result3}");


