// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int[] b = new int[a];
Random c = new Random();
for(int i = 0; i < b.Length; i++){
    b[i] = c.Next(1, 100);
}
Console.Write("N = "+ a + " -> получаем массив [" + string.Join(", ", b)+"]");
