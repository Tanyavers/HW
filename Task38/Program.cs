// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Random rnd = new Random();
int a = rnd.Next(4, 10);
int[] b = new int[a];
int min = 100;
int max = 0;
for (int i = 0; i < b.Length; i++){
    b[i] = rnd.Next(0 , 100);
    if(b[i]<min)
        min=b[i];
    if(b[i]>max)
        max=b[i];
}
Console.Write("["+string.Join(" ", b)+"] -> "+(max-min));