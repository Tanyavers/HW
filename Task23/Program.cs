// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int[] b = new int[a];
for (int i = 1; i <= a; i++){
    int c = i*i*i;
    b[i - 1]= c;
}
Console.Write(a + " -> " + string.Join(", ", b));
