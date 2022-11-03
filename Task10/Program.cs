// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
string a = Console.ReadLine();
char[] b = a.ToCharArray();
string c = a+" -> "+b[1];
Console.Write(c);