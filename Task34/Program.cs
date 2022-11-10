// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Random rnd = new Random();
int a = rnd.Next(4, 10);
int[] b = new int[a];
int c = 0;
for (int i = 0; i < b.Length; i++){
    b[i] = rnd.Next(100, 999);
    if(b[i]%2==0)
        c++;
}
Console.Write("["+string.Join(", ", b)+"] -> "+c);
