// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите b1: ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
float b2 = float.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
float k2 = float.Parse(Console.ReadLine());

float x=(b2 - b1)/(k1 - k2);
float y=k1 * (b2 - b1)/(k1 - k2) + b1;

Console.Write("b1 = "+b1+", k1 = "+k1+", b2 = "+b2+", k2 = "+k2+" -> ("+x+";"+y+")");
