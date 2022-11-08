// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine());
int c = 1;
for(int i = 1; i <= b; i++ ){
    c = c*a;
}
Console.Write(a+", "+b+" -> "+c);