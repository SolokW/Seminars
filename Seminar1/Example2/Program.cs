// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите день недели(1-7): ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
Console.Write("Monday");
}
else if (day == 2)
{
Console.Write("Tuesday");
}
else if (day == 3)
{
Console.Write("Wednesday");
}
else if (day == 4)
{
Console.Write("Thursday");
}
else if (day == 5)
{
Console.Write("Friday");
}
else if (day == 6)
{
Console.Write("Saturday");
}
else if (day == 7)
{
Console.Write("Sunday");
}
else
{
    Console.Write("Incorrect number");
}