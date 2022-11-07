// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine();
string b = new string(a.Reverse().ToArray());
string c = a + " -> ";
if (a == b)
    Console.Write(c + "да");
else
    Console.Write(c + "нет");
