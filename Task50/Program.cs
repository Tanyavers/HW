// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите позицию: ");
string m = Console.ReadLine();
int[,] array = new int[,] {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
int a = (int)Char.GetNumericValue(m[0]);
int b = (int)Char.GetNumericValue(m[1]);
 if (a > array.GetLength(0) || b>array.GetLength(1))
 Console.WriteLine(m+" -> такого числа в массиве нет");
    else {
        Console.WriteLine(m+" -> "+array.GetValue(a,b));
    }
