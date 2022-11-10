// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Random rnd = new Random();
int[] b = new int[4];
int c = 0;
for (int i = 0; i < b.Length; i++){
    b[i] = rnd.Next(-100, 100);
    if(i%2!=0)
        c=c+b[i];
}
Console.Write("["+string.Join(", ", b)+"] -> "+c);